using Ngofee.Id.Controllers;
using Ngofee.Id.Helpers;
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
    public partial class V_RiwayatTransaksiPbl : Form
    {
        public V_RiwayatTransaksiPbl()
        {
            InitializeComponent();
        }

        private void V_RiwayatTransaksiPbl_Load(object sender, EventArgs e)
        {
            flowRiwayatPbl.Controls.Clear();

            var ctrl = new OrderController();
            var orders = ctrl.GetHistoryByUser(AppSession.CurrentUser.UserId);

            foreach (var order in orders)
            {
                Panel card = new Panel();
                card.Width = 1050;
                card.Height = 160 + (order.Items.Count * 70);
                card.BackColor = Color.White;
                card.Padding = new Padding(15);
                card.Margin = new Padding(0, 0, 0, 15);
                card.BorderStyle = BorderStyle.FixedSingle;

                // Tanggal - Status
                Label lblTop = new Label();
                lblTop.Text = $"{order.Tanggal:dd MMM yyyy}    |    Status: {order.Status}";
                lblTop.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblTop.Location = new Point(10, 10);
                lblTop.AutoSize = true;
                card.Controls.Add(lblTop);

                int y = 40;

                foreach (var item in order.Items)
                {
                    PictureBox img = new PictureBox();
                    img.Size = new Size(60, 60);
                    img.Location = new Point(20, y);
                    img.SizeMode = PictureBoxSizeMode.Zoom;

                    if (item.FotoProduk != null)
                        img.Image = ImageHelper.BinaryToImage(item.FotoProduk);

                    card.Controls.Add(img);

                    Label lblNama = new Label();
                    lblNama.Text = item.NamaProduk;
                    lblNama.Location = new Point(100, y + 10);
                    lblNama.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblNama.AutoSize = true;
                    card.Controls.Add(lblNama);

                    Label lblQty = new Label();
                    lblQty.Text = $"Jumlah: {item.Quantity}";
                    lblQty.Location = new Point(100, y + 35);
                    lblQty.AutoSize = true;
                    card.Controls.Add(lblQty);

                    Label lblHarga = new Label();
                    lblHarga.Text = "Rp " + item.Subtotal.ToString("N0");
                    lblHarga.Location = new Point(300, y + 20);
                    lblHarga.AutoSize = true;
                    lblHarga.ForeColor = Color.FromArgb(90, 60, 40);
                    card.Controls.Add(lblHarga);

                    y += 70;
                }

                // Total Order
                Label lblTotal = new Label();
                lblTotal.Text = "Total: Rp " + order.TotalHarga.ToString("N0");
                lblTotal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblTotal.Location = new Point(20, y + 10);
                lblTotal.AutoSize = true;
                card.Controls.Add(lblTotal);

                flowRiwayatPbl.Controls.Add(card);
            }
        }

        private void btnHomeriwayatpbl_Click(object sender, EventArgs e)
        {
            var homeriwayatpbl = new BerandaPbl();
            homeriwayatpbl.Show();
            this.Hide();
        }

        private void btnProdukriwayarpbl_Click(object sender, EventArgs e)
        {
            var produkriwayarpbl = new LihatProdukPbl();
            produkriwayarpbl.Show();
            this.Hide();
        }

        private void btnRiwayatpesananpbl_Click(object sender, EventArgs e)
        {
            var riwayatpesananpbl = new V_RiwayatTransaksiPbl();
            riwayatpesananpbl.Show();
            this.Hide();
        }
    }
}
