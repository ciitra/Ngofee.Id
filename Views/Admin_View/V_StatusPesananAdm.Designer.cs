namespace Ngofee.Id.Views.Admin_View
{
    partial class V_StatusPesananAdm
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowTransaksi;

        private void InitializeComponent()
        {
            flowTransaksi = new FlowLayoutPanel();
            btnLaporanKeuanganstatuspesanan = new Button();
            btnProdukstatuspesanan = new Button();
            btnHomestatuspesanan = new Button();
            SuspendLayout();
            // 
            // flowTransaksi
            // 
            flowTransaksi.AutoScroll = true;
            flowTransaksi.Location = new Point(50, 150);
            flowTransaksi.Name = "flowTransaksi";
            flowTransaksi.Size = new Size(1150, 500);
            flowTransaksi.TabIndex = 0;
            // 
            // btnLaporanKeuanganstatuspesanan
            // 
            btnLaporanKeuanganstatuspesanan.BackColor = Color.Transparent;
            btnLaporanKeuanganstatuspesanan.FlatAppearance.BorderSize = 0;
            btnLaporanKeuanganstatuspesanan.FlatStyle = FlatStyle.Flat;
            btnLaporanKeuanganstatuspesanan.Location = new Point(598, 36);
            btnLaporanKeuanganstatuspesanan.Name = "btnLaporanKeuanganstatuspesanan";
            btnLaporanKeuanganstatuspesanan.Size = new Size(211, 26);
            btnLaporanKeuanganstatuspesanan.TabIndex = 2;
            btnLaporanKeuanganstatuspesanan.UseVisualStyleBackColor = false;
            btnLaporanKeuanganstatuspesanan.Click += btnLaporanKeuanganstatuspesanan_Click;
            // 
            // btnProdukstatuspesanan
            // 
            btnProdukstatuspesanan.BackColor = Color.Transparent;
            btnProdukstatuspesanan.FlatAppearance.BorderSize = 0;
            btnProdukstatuspesanan.FlatStyle = FlatStyle.Flat;
            btnProdukstatuspesanan.Location = new Point(1003, 36);
            btnProdukstatuspesanan.Name = "btnProdukstatuspesanan";
            btnProdukstatuspesanan.Size = new Size(90, 26);
            btnProdukstatuspesanan.TabIndex = 3;
            btnProdukstatuspesanan.UseVisualStyleBackColor = false;
            btnProdukstatuspesanan.Click += btnProdukstatuspesanan_Click;
            // 
            // btnHomestatuspesanan
            // 
            btnHomestatuspesanan.BackColor = Color.Transparent;
            btnHomestatuspesanan.FlatAppearance.BorderSize = 0;
            btnHomestatuspesanan.FlatStyle = FlatStyle.Flat;
            btnHomestatuspesanan.Location = new Point(1139, 36);
            btnHomestatuspesanan.Name = "btnHomestatuspesanan";
            btnHomestatuspesanan.Size = new Size(61, 26);
            btnHomestatuspesanan.TabIndex = 4;
            btnHomestatuspesanan.UseVisualStyleBackColor = false;
            btnHomestatuspesanan.Click += btnHomestatuspesanan_Click;
            // 
            // V_StatusPesananAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Transaksi_Masuk__1_1;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnHomestatuspesanan);
            Controls.Add(btnProdukstatuspesanan);
            Controls.Add(btnLaporanKeuanganstatuspesanan);
            Controls.Add(flowTransaksi);
            Name = "V_StatusPesananAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Status Pesanan Admin";
            Load += V_StatusPesananAdm_Load;
            ResumeLayout(false);
        }
        private Button button1;
        private Button btnLaporanKeuanganstatuspesanan;
        private Button btnProdukstatuspesanan;
        private Button btnHomestatuspesanan;
    }
}
