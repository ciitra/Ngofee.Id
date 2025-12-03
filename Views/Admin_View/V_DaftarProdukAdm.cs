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

namespace Ngofee.Id.Views.Admin_View
{
    public partial class V_DaftarProdukAdm : Form
    {
        public V_DaftarProdukAdm()
        {
            InitializeComponent();
        }

        private void V_DaftarProdukAdm_Load(object sender, EventArgs e)
        {
            ProductController pc = new ProductController();
            List<Product> produkList = pc.GetAllProduct();

            foreach (var p in produkList)
            {
                Panel card = new Panel();
                card.Size = new Size(1000, 180);
                card.BackColor = Color.White;
                card.Margin = new Padding(20, 10, 20, 10);
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Cursor = Cursors.Hand;

                PictureBox img = new PictureBox();
                img.Size = new Size(140, 140);
                img.Location = new Point(20, 20);
                img.SizeMode = PictureBoxSizeMode.Zoom;

                if (p.FotoProduk != null)
                    img.Image = ImageHelper.BinaryToImage(p.FotoProduk);

                Label lblNama = new Label();
                lblNama.Text = p.NamaProduk;
                lblNama.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNama.Location = new Point(180, 20);
                lblNama.AutoSize = true;

                Label lblJenis = new Label();
                lblJenis.Text = "Jenis Kopi: " + p.JenisProduk;
                lblJenis.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblJenis.Location = new Point(180, 50);
                lblJenis.AutoSize = true;

                Label lblKriteria = new Label();
                lblKriteria.Text = "Kriteria: " + p.KriteriaProduk;
                lblKriteria.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblKriteria.Location = new Point(180, 75);
                lblKriteria.AutoSize = true;

                Label lblHarga = new Label();
                lblHarga.Text = "Rp. " + p.Harga.ToString("N0");
                lblHarga.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblHarga.Location = new Point(800, 130);
                lblHarga.AutoSize = true;

                card.Controls.Add(img);
                card.Controls.Add(lblNama);
                card.Controls.Add(lblJenis);
                card.Controls.Add(lblKriteria);
                card.Controls.Add(lblHarga);


                flowAdminProduk.Controls.Add(card);
            }
        }

        private void flowAdminProduk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTambahProdukBefore_Click(object sender, EventArgs e)
        {
            var tambah = new V_TambahProdukAdm();
            tambah.Show();
            this.Hide();
        }

        private void btnHapusProdukBefore_Click(object sender, EventArgs e)
        {
            var halamanHapus = new V_HapusProduk();
            halamanHapus.Show();
            this.Hide();
        }

        private void btnHomeDaftarProdukAdm_Click(object sender, EventArgs e)
        {
            var daftarproduct = new BerandaAdm();
            daftarproduct.Show();
            this.Hide();
        }

        private void btnTransaksidaftarproduk_Click(object sender, EventArgs e)
        {
            var transaksidaftarproduk = new V_StatusPesananAdm();
            transaksidaftarproduk.Show();
            this.Hide();
        }
    }
}
