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
    public partial class V_LaporanKeuanganAdm : Form
    {
        public V_LaporanKeuanganAdm()
        {
            InitializeComponent();
        }

        private void V_LaporanKeuanganAdm_Load(object sender, EventArgs e)
        {
            var f = new FinancialController();

            // Summary
            var summary = f.GetIncomeSummary();
            lblHarian.Text = $"Pendapatan Hari Ini ({summary.TanggalHariIni}): Rp {summary.PendapatanHarian:N0}";
            lblBulanan.Text = $"Pendapatan Bulan {summary.BulanIni}: Rp {summary.PendapatanBulanan:N0}";

            // Detail transaksi
            var list = f.GetFinancialHistory();
            flowLaporan.Controls.Clear();

            foreach (var l in list)
                flowLaporan.Controls.Add(CreateCard(l));
        }

        private Panel CreateCard(AdminFinancialReport data)
        {
            Panel card = new Panel();
            card.Size = new Size(1000, 140);
            card.BackColor = Color.White;
            card.Margin = new Padding(10);
            card.Padding = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;

            // ==== FOTO PRODUK ====
            PictureBox img = new PictureBox();
            img.Size = new Size(90, 90);
            img.Location = new Point(10, 20);
            img.SizeMode = PictureBoxSizeMode.Zoom;

            if (data.FotoProduk != null)
                img.Image = ImageHelper.BinaryToImage(data.FotoProduk);

            // ==== PRODUK UTAMA TANPA KOMA ====
            string produkUtama = data.ProdukList.Split(',')[0].Trim();

            Label produk = new Label();
            produk.Text = produkUtama;
            produk.Location = new Point(120, 15);
            produk.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            produk.AutoSize = true;

            // ==== PENDAPATAN ====
            Label income = new Label();
            income.Text = $"Pendapatan: Rp {data.TotalIncome:N0}";
            income.Location = new Point(120, 45);
            income.AutoSize = true;

            // ==== TANGGAL ====
            Label tgl = new Label();
            tgl.Text = data.Tanggal.ToString("dd MMM yyyy");
            tgl.Location = new Point(120, 70);
            tgl.AutoSize = true;

            // ==== MASUKKAN KE CARD ====
            card.Controls.Add(img);
            card.Controls.Add(produk);
            card.Controls.Add(income);
            card.Controls.Add(tgl);

            return card;
        }
    }
}
