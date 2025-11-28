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
    public partial class LihatProdukPbl : Form
    {
        public LihatProdukPbl()
        {
            InitializeComponent();
        }

        private void LihatProdukPbl_Load(object sender, EventArgs e)
        {
            ProductController pc = new ProductController();
            List<Product> produkList = pc.GetAllProduct();

            foreach (var p in produkList)
            {
                // Panel Card
                Panel card = new Panel();
                card.Size = new Size(500, 200);
                card.BackColor = Color.White;
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;

                // Gambar Produk
                PictureBox img = new PictureBox();
                img.Size = new Size(160, 160);
                img.Location = new Point(20, 20);
                img.SizeMode = PictureBoxSizeMode.Zoom;

                if (p.FotoProduk != null)
                {
                    img.Image = ImageHelper.BinaryToImage(p.FotoProduk);
                }

                // Nama Produk
                Label lblNama = new Label();
                lblNama.Text = p.NamaProduk;
                lblNama.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNama.Location = new Point(200, 20);
                lblNama.AutoSize = true;

                // Jenis Produk
                Label lblJenis = new Label();
                lblJenis.Text = "Jenis: " + p.JenisProduk;
                lblJenis.Location = new Point(200, 60);
                lblJenis.AutoSize = true;

                // Kriteria Produk
                Label lblKriteria = new Label();
                lblKriteria.Text = "Kriteria: " + p.KriteriaProduk;
                lblKriteria.Location = new Point(200, 90);
                lblKriteria.AutoSize = true;

                // Harga
                Label lblHarga = new Label();
                lblHarga.Text = "Harga: Rp " + p.Harga;
                lblHarga.Location = new Point(200, 120);
                lblHarga.AutoSize = true;

                // Stok
                Label lblStok = new Label();
                lblStok.Text = "Stok: " + p.Stok;
                lblStok.Location = new Point(200, 150);
                lblStok.AutoSize = true;

                // Tombol -
                Button btnMinus = new Button();
                btnMinus.Text = "-";
                btnMinus.Size = new Size(30, 30);
                btnMinus.Location = new Point(200, 170);

                // Qty
                Label lblQty = new Label();
                lblQty.Text = "0";
                lblQty.Location = new Point(240, 175);
                lblQty.AutoSize = true;

                // Tombol +
                Button btnPlus = new Button();
                btnPlus.Text = "+";
                btnPlus.Size = new Size(30, 30);
                btnPlus.Location = new Point(270, 170);

                // Event tombol + -
                btnPlus.Click += (s, args) =>
                {
                    int qty = int.Parse(lblQty.Text);
                    lblQty.Text = (qty + 1).ToString();
                };

                btnMinus.Click += (s, args) =>
                {
                    int qty = int.Parse(lblQty.Text);
                    if (qty > 0) lblQty.Text = (qty - 1).ToString();
                };

                // Masukkan semua ke card
                card.Controls.Add(img);
                card.Controls.Add(lblNama);
                card.Controls.Add(lblJenis);
                card.Controls.Add(lblKriteria);
                card.Controls.Add(lblHarga);
                card.Controls.Add(lblStok);
                card.Controls.Add(btnMinus);
                card.Controls.Add(lblQty);
                card.Controls.Add(btnPlus);

                // Terakhir → tambah card ke FlowPanel
                FlowProduk.Controls.Add(card);
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            var home = new BerandaPbl();
            home.Show();
            this.Hide();
        }

        private void btnRiwayatPbl_lihatproduk_Click(object sender, EventArgs e)
        {
            var riwayatPage = new V_RiwayatTransaksiPbl();
            riwayatPage.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}