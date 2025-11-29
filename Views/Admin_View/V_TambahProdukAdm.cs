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
    public partial class V_TambahProdukAdm : Form
    {
        public V_TambahProdukAdm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotoProduk.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            if (pbFotoProduk.Image == null)
            {
                MessageBox.Show("Silakan upload gambar produk.");
                return;
            }

            try
            {
                byte[] fotoBytes = ImageHelper.ImageToBinary(pbFotoProduk.Image);

                Product newProduct = new Product
                {
                    NamaProduk = txtNamaKopi.Text.Trim(),
                    JenisProduk = txtJenisKopi.Text.Trim(),
                    KriteriaProduk = txtKriteriaProduk.Text.Trim(),
                    Harga = int.Parse(txtHargaProduk.Text),
                    Stok = int.Parse(txtStok.Text),
                    FotoProduk = fotoBytes,
                    UserId = AppSession.CurrentUser.UserId  // admin inputnya
                };

                ProductController pc = new ProductController();
                pc.CreateProduct(newProduct);

                MessageBox.Show("Produk berhasil ditambahkan!");

                // kembali ke halaman daftar produk admin
                var daftar = new V_DaftarProdukAdm();
                daftar.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menambah produk: " + ex.Message);
            }
        }

        private void V_TambahProdukAdm_Load(object sender, EventArgs e)
        {

        }

        private void pbFotoProduk_Click(object sender, EventArgs e)
        {

        }

        private void btnHometambahproduk_Click(object sender, EventArgs e)
        {
            var hometambahproduk = new BerandaAdm();
            hometambahproduk.Show();
            this.Hide();
        }
    }
}
