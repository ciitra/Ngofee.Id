using Ngofee.Id.Controllers;
using Ngofee.Id.Helpers;
using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngofee.Id.Views.User_View
{
    public partial class V_FormTransaksi : Form
    {
        public V_FormTransaksi()
        {
            InitializeComponent();
        }

        private void V_FormTransaksi_Load(object sender, EventArgs e)
        {
            txtPengiriman.Text = "JNE";
            txtPengiriman.ReadOnly = true;

            flowPesanan.Controls.Clear();   

            int totalQty = 0;
            int totalHarga = 0;

            if (Order.Items.Count == 0)
            {
                MessageBox.Show("Tidak ada produk yang dipilih.", "Peringatan");
                this.Hide();
                new LihatProdukPbl().Show();
                return;
            }

            foreach (var item in Order.Items)
            {
                Panel card = new Panel();
                card.Size = new Size(500, 150);
                card.BackColor = Color.White;
                card.Margin = new Padding(10);

                PictureBox img = new PictureBox();
                img.Size = new Size(120, 120);
                img.Location = new Point(15, 15);
                img.SizeMode = PictureBoxSizeMode.Zoom;

                if (item.FotoProduk != null)
                    img.Image = ImageHelper.BinaryToImage(item.FotoProduk);

                Label lblNama = new Label();
                lblNama.Text = item.NamaProduk;
                lblNama.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblNama.Location = new Point(150, 20);
                lblNama.AutoSize = true;

                Label lblQty = new Label();
                lblQty.Text = "Jumlah: " + item.Quantity;
                lblQty.Location = new Point(150, 60);
                lblQty.AutoSize = true;

                Label lblSub = new Label();
                lblSub.Text = "Rp. " + (item.Harga * item.Quantity).ToString("N0");
                lblSub.Location = new Point(150, 90);
                lblSub.AutoSize = true;

                card.Controls.Add(img);
                card.Controls.Add(lblNama);
                card.Controls.Add(lblQty);
                card.Controls.Add(lblSub);

                flowPesanan.Controls.Add(card);

                totalQty += item.Quantity;
                totalHarga += item.Harga * item.Quantity;
            }

            lblTotalJumlah.Text = totalQty.ToString();
            lblTotalHarga.Text = totalHarga.ToString("N0");
        }

        private void btnUploadBukti_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbBuktiPembayaran.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaPenerima.Text))
                {
                    MessageBox.Show("Nama penerima wajib diisi.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAlamat.Text))
                {
                    MessageBox.Show("Alamat wajib diisi.");
                    return;
                }

                if (pbBuktiPembayaran.Image == null)
                {
                    MessageBox.Show("Silakan upload bukti pembayaran.");
                    return;
                }

                if (Order.Items.Count == 0)
                {
                    MessageBox.Show("Tidak ada item dalam pesanan.");
                    return;
                }

                Order order = new Order
                {
                    UserId = AppSession.CurrentUser.UserId,
                    NamaPenerima = txtNamaPenerima.Text,
                    AlamatTujuan = txtAlamat.Text,
                    MetodePembayaran = "QRIS",
                    MetodePengiriman = "JNE",
                    BuktiPembayaran = ImageHelper.ImageToBinary(pbBuktiPembayaran.Image),
                    Status = "pending"
                };

                var oCtrl = new OrderController();
                var oiCtrl = new OrderItemController();

                int newOrderId = oCtrl.CreateOrder(order);

                foreach (var item in Order.Items)
                {
                    item.OrderId = newOrderId;
                    oiCtrl.InsertOrderItem(item);
                }

                MessageBox.Show("Pesanan berhasil dibuat! Silakan tunggu konfirmasi admin.");

                Order.Clear();

                var home = new BerandaPbl();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat membuat pesanan: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
