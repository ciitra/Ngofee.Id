namespace Ngofee.Id.Views.Admin_View
{
    partial class V_LaporanKeuanganAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LaporanKeuanganAdm));
            lblHarian = new Label();
            lblBulanan = new Label();
            flowLaporan = new FlowLayoutPanel();
            btnTranskasiLaporan = new Button();
            btnProdukLaporan = new Button();
            btnHomeLaporan = new Button();
            SuspendLayout();
            // 
            // lblHarian
            // 
            lblHarian.AutoSize = true;
            lblHarian.BackColor = Color.Transparent;
            lblHarian.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarian.ForeColor = SystemColors.ControlDarkDark;
            lblHarian.Location = new Point(109, 167);
            lblHarian.Name = "lblHarian";
            lblHarian.Size = new Size(179, 23);
            lblHarian.TabIndex = 0;
            lblHarian.Text = "Pendapatan Hari Ini";
            // 
            // lblBulanan
            // 
            lblBulanan.AutoSize = true;
            lblBulanan.BackColor = Color.Transparent;
            lblBulanan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBulanan.ForeColor = SystemColors.ControlDarkDark;
            lblBulanan.Location = new Point(109, 197);
            lblBulanan.Name = "lblBulanan";
            lblBulanan.Size = new Size(189, 23);
            lblBulanan.TabIndex = 1;
            lblBulanan.Text = "Pendapatan Bulan Ini";
            // 
            // flowLaporan
            // 
            flowLaporan.AutoScroll = true;
            flowLaporan.Location = new Point(109, 240);
            flowLaporan.Name = "flowLaporan";
            flowLaporan.Size = new Size(1050, 409);
            flowLaporan.TabIndex = 2;
            // 
            // btnTranskasiLaporan
            // 
            btnTranskasiLaporan.BackColor = Color.Transparent;
            btnTranskasiLaporan.BackgroundImageLayout = ImageLayout.None;
            btnTranskasiLaporan.FlatAppearance.BorderSize = 0;
            btnTranskasiLaporan.FlatStyle = FlatStyle.Flat;
            btnTranskasiLaporan.Location = new Point(863, 34);
            btnTranskasiLaporan.Name = "btnTranskasiLaporan";
            btnTranskasiLaporan.Size = new Size(122, 29);
            btnTranskasiLaporan.TabIndex = 3;
            btnTranskasiLaporan.UseVisualStyleBackColor = false;
            btnTranskasiLaporan.Click += btnTranskasiLaporan_Click;
            // 
            // btnProdukLaporan
            // 
            btnProdukLaporan.BackColor = Color.Transparent;
            btnProdukLaporan.BackgroundImageLayout = ImageLayout.None;
            btnProdukLaporan.FlatAppearance.BorderSize = 0;
            btnProdukLaporan.FlatStyle = FlatStyle.Flat;
            btnProdukLaporan.Location = new Point(1023, 34);
            btnProdukLaporan.Name = "btnProdukLaporan";
            btnProdukLaporan.Size = new Size(89, 29);
            btnProdukLaporan.TabIndex = 4;
            btnProdukLaporan.UseVisualStyleBackColor = false;
            btnProdukLaporan.Click += btnProdukLaporan_Click;
            // 
            // btnHomeLaporan
            // 
            btnHomeLaporan.BackColor = Color.Transparent;
            btnHomeLaporan.BackgroundImageLayout = ImageLayout.None;
            btnHomeLaporan.FlatAppearance.BorderSize = 0;
            btnHomeLaporan.FlatStyle = FlatStyle.Flat;
            btnHomeLaporan.Location = new Point(1157, 34);
            btnHomeLaporan.Name = "btnHomeLaporan";
            btnHomeLaporan.Size = new Size(65, 29);
            btnHomeLaporan.TabIndex = 5;
            btnHomeLaporan.UseVisualStyleBackColor = false;
            btnHomeLaporan.Click += btnHomeLaporan_Click;
            // 
            // V_LaporanKeuanganAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
            Controls.Add(btnHomeLaporan);
            Controls.Add(btnProdukLaporan);
            Controls.Add(btnTranskasiLaporan);
            Controls.Add(flowLaporan);
            Controls.Add(lblBulanan);
            Controls.Add(lblHarian);
            Name = "V_LaporanKeuanganAdm";
            Text = "V_LaporanKeuanganAdm";
            Load += V_LaporanKeuanganAdm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHarian;
        private Label lblBulanan;
        private FlowLayoutPanel flowLaporan;
        private Button btnTranskasiLaporan;
        private Button btnProdukLaporan;
        private Button btnHomeLaporan;
    }
}