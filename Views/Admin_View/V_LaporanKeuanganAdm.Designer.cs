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
            // V_LaporanKeuanganAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
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
    }
}