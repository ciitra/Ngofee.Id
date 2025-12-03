using Ngofee.Id.Controllers;
using Ngofee.Id.Helpers;
using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ngofee.Id.Views.Admin_View
{
    public partial class V_StatusPesananAdm : Form
    {
        public V_StatusPesananAdm()
        {
            InitializeComponent();
        }

        private void V_StatusPesananAdm_Load(object sender, EventArgs e)
        {
            LoadTransaksi();
        }

        private void LoadDataAdmin()
        {
            flowTransaksi.Controls.Clear();
            LoadTransaksi();
        }

        private void LoadTransaksi()
        {
            OrderController oc = new OrderController();
            var data = oc.GetAllOrdersForAdmin();

            flowTransaksi.Controls.Clear();

            foreach (var order in data)
            {
                flowTransaksi.Controls.Add(CreateOrderCard(order));
            }
        }

        private Panel CreateOrderCard(AdminOrder order)
        {
            Panel card = new Panel();
            card.Size = new Size(1100, 350);
            card.BackColor = Color.White;
            card.Padding = new Padding(15);
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;

            Panel left = new Panel();
            left.Size = new Size(350, 260);
            left.Location = new Point(10, 10);
            left.BackColor = Color.White;

            left.Controls.Add(CreateLabel("Nama Penerima : " + order.NamaPenerima, 0));
            left.Controls.Add(CreateLabel("Alamat : " + order.AlamatTujuan, 30));
            left.Controls.Add(CreateLabel("Pembayaran : " + order.MetodePembayaran, 60));
            left.Controls.Add(CreateLabel("Pengiriman : " + order.MetodePengiriman, 90));
            left.Controls.Add(CreateLabel("Status : " + order.Status, 130));
            left.Controls.Add(CreateLabel("Tanggal : " + order.Tanggal.ToString("dd MMM yyyy"), 160));

            FlowLayoutPanel kanan = new FlowLayoutPanel();
            kanan.Location = new Point(380, 10);
            kanan.Size = new Size(700, 230);
            kanan.AutoScroll = true;

            foreach (var item in order.Items)
            {
                kanan.Controls.Add(CreateItemCard(item));
            }

            OrderController oCtrl = new OrderController();

            Button btnProses = new Button()
            {
                Text = "pending",
                Width = 90,
                Height = 35,
                Location = new Point(380, 260)
            };

            Button btnKirim = new Button()
            {
                Text = "processing",
                Width = 90,
                Height = 35,
                Location = new Point(480, 260)
            };

            Button btnSelesai = new Button()
            {
                Text = "done",
                Width = 90,
                Height = 35,
                Location = new Point(580, 260)
            };

            btnProses.Click += (s, e) =>
            {
                oCtrl.UpdateStatus(order.OrderId, "pending");
                MessageBox.Show("Status diperbarui menjadi PENDING");
                LoadDataAdmin();
            };

            btnKirim.Click += (s, e) =>
            {
                oCtrl.UpdateStatus(order.OrderId, "processing");
                MessageBox.Show("Status diperbarui menjadi DIPROSES");
                LoadDataAdmin();
            };

            btnSelesai.Click += (s, e) =>
            {
                oCtrl.UpdateStatus(order.OrderId, "done");
                MessageBox.Show("Status diperbarui menjadi SELESAI");
                LoadDataAdmin();
            };

            card.Controls.Add(left);
            card.Controls.Add(kanan);
            card.Controls.Add(btnProses);
            card.Controls.Add(btnKirim);
            card.Controls.Add(btnSelesai);

            return card;
        }

        private Label CreateLabel(string txt, int y)
        {
            return new Label()
            {
                Text = txt,
                Location = new Point(0, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };
        }

        private Panel CreateItemCard(AdminOrderItem item)
        {
            Panel p = new Panel();
            p.Size = new Size(300, 120);
            p.BackColor = Color.White;
            p.Margin = new Padding(10);
            p.BorderStyle = BorderStyle.FixedSingle;

            PictureBox img = new PictureBox();
            img.Size = new Size(80, 80);
            img.Location = new Point(10, 20);
            img.SizeMode = PictureBoxSizeMode.Zoom;

            if (item.FotoProduk != null)
                img.Image = ImageHelper.BinaryToImage(item.FotoProduk);

            Label nama = new Label()
            {
                Text = item.NamaProduk,
                Location = new Point(100, 20),
                AutoSize = true
            };

            Label harga = new Label()
            {
                Text = "Rp " + item.Subtotal.ToString("N0"),
                Location = new Point(100, 55),
                AutoSize = true
            };

            p.Controls.Add(img);
            p.Controls.Add(nama);
            p.Controls.Add(harga);

            return p;
        }

        private void btnLaporanKeuanganstatuspesanan_Click(object sender, EventArgs e)
        {
            var laporanKeuanganstatuspesanan = new V_LaporanKeuanganAdm();
            laporanKeuanganstatuspesanan.Show();
            this.Hide();
        }

        private void btnProdukstatuspesanan_Click(object sender, EventArgs e)
        {
            var produkstatuspesanan = new V_StatusPesananAdm();
            produkstatuspesanan.Show();
            this.Hide();
        }

        private void btnHomestatuspesanan_Click(object sender, EventArgs e)
        {
            var homestatuspesanan = new BerandaAdm();
            homestatuspesanan.Show();
            this.Hide();
        }
    }
}
