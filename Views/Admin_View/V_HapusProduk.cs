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
    public partial class V_HapusProduk : Form
    {
        private void HapusProduk_Load(object sender, EventArgs e)
        {
            flowHapusProduk.Controls.Clear();

            ProductController pc = new ProductController();
            List<Product> produkList = pc.GetAllProduct();

            foreach (var p in produkList)
            {
                Panel wrapper = new Panel();
                wrapper.Size = new Size(1100, 200);
                wrapper.BackColor = Color.Transparent;
                wrapper.Margin = new Padding(0, 10, 0, 10);

                CheckBox cb = new CheckBox();
                cb.Size = new Size(25, 25);
                cb.Location = new Point(5, 85);
                cb.Tag = p.ProductId;
                cb.Visible = true;
                wrapper.Controls.Add(cb);

                Panel card = new Panel();
                card.Size = new Size(1000, 180);
                card.BackColor = Color.White;
                card.Location = new Point(45, 0); 
                card.Margin = new Padding(0);

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
                lblJenis.Location = new Point(180, 50);
                lblJenis.Font = new Font("Segoe UI", 10);
                lblJenis.AutoSize = true;

                Label lblKriteria = new Label();
                lblKriteria.Text = "Kriteria: " + p.KriteriaProduk;
                lblKriteria.Location = new Point(180, 75);
                lblKriteria.Font = new Font("Segoe UI", 10);
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

                wrapper.Controls.Add(card);

                flowHapusProduk.Controls.Add(wrapper);
            }
        }


        public V_HapusProduk()
        {
            InitializeComponent();
        }

        private void flowHapusProduk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHapusProdukFix_Click(object sender, EventArgs e)
        {
            ProductController pc = new ProductController();
            List<int> selectedIds = new List<int>();

            foreach (Control card in flowHapusProduk.Controls)
            {
                foreach (Control c in card.Controls)
                {
                    if (c is CheckBox cb && cb.Checked)
                    {
                        selectedIds.Add((int)cb.Tag);
                    }
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Pilih produk yang ingin dihapus.");
                return;
            }

            foreach (int id in selectedIds)
            {
                pc.DeleteProduct(id);
            }

            MessageBox.Show("Produk berhasil dihapus!");

            var daftar = new V_DaftarProdukAdm();
            daftar.Show();
            this.Hide();
        }

        private void btnHomehapusproduk_Click(object sender, EventArgs e)
        {
            var hpsproduk = new BerandaAdm();
            hpsproduk.Show();
            this.Hide();
        }

        private void btnProdukhpsproduk_Click(object sender, EventArgs e)
        {
            var produkhapus = new V_DaftarProdukAdm();
            produkhapus.Show();
            this.Hide();
        }
    }
}
