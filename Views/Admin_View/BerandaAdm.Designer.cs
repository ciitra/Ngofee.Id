namespace Ngofee.Id.Views.Admin_View
{
    partial class BerandaAdm
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
            btnSee = new Button();
            btnProdukAdm = new Button();
            btnTransaksiAdm = new Button();
            btnLaporanKeuanganberandaadm = new Button();
            SuspendLayout();
            // 
            // btnSee
            // 
            btnSee.BackColor = Color.Transparent;
            btnSee.BackgroundImage = Properties.Resources.btnSee;
            btnSee.BackgroundImageLayout = ImageLayout.Zoom;
            btnSee.FlatAppearance.BorderSize = 0;
            btnSee.FlatStyle = FlatStyle.Flat;
            btnSee.ForeColor = Color.Transparent;
            btnSee.Location = new Point(91, 448);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(173, 51);
            btnSee.TabIndex = 0;
            btnSee.UseVisualStyleBackColor = false;
            btnSee.Click += btnSee_Click;
            // 
            // btnProdukAdm
            // 
            btnProdukAdm.BackColor = Color.Transparent;
            btnProdukAdm.FlatAppearance.BorderSize = 0;
            btnProdukAdm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProdukAdm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProdukAdm.FlatStyle = FlatStyle.Flat;
            btnProdukAdm.Location = new Point(924, 34);
            btnProdukAdm.Name = "btnProdukAdm";
            btnProdukAdm.Size = new Size(87, 27);
            btnProdukAdm.TabIndex = 1;
            btnProdukAdm.UseVisualStyleBackColor = false;
            btnProdukAdm.Click += btnProdukAdm_Click;
            // 
            // btnTransaksiAdm
            // 
            btnTransaksiAdm.BackColor = Color.Transparent;
            btnTransaksiAdm.FlatAppearance.BorderSize = 0;
            btnTransaksiAdm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTransaksiAdm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTransaksiAdm.FlatStyle = FlatStyle.Flat;
            btnTransaksiAdm.Location = new Point(762, 34);
            btnTransaksiAdm.Name = "btnTransaksiAdm";
            btnTransaksiAdm.Size = new Size(131, 29);
            btnTransaksiAdm.TabIndex = 2;
            btnTransaksiAdm.UseVisualStyleBackColor = false;
            btnTransaksiAdm.Click += btnTransaksiAdm_Click;
            // 
            // btnLaporanKeuanganberandaadm
            // 
            btnLaporanKeuanganberandaadm.BackColor = Color.Transparent;
            btnLaporanKeuanganberandaadm.FlatAppearance.BorderSize = 0;
            btnLaporanKeuanganberandaadm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLaporanKeuanganberandaadm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLaporanKeuanganberandaadm.FlatStyle = FlatStyle.Flat;
            btnLaporanKeuanganberandaadm.Location = new Point(515, 34);
            btnLaporanKeuanganberandaadm.Name = "btnLaporanKeuanganberandaadm";
            btnLaporanKeuanganberandaadm.Size = new Size(213, 29);
            btnLaporanKeuanganberandaadm.TabIndex = 3;
            btnLaporanKeuanganberandaadm.UseVisualStyleBackColor = false;
            btnLaporanKeuanganberandaadm.Click += btnLaporanKeuanganberandaadm_Click;
            // 
            // BerandaAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Beranda_Admin;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnLaporanKeuanganberandaadm);
            Controls.Add(btnTransaksiAdm);
            Controls.Add(btnProdukAdm);
            Controls.Add(btnSee);
            Name = "BerandaAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BerandaAdm";
            Load += BerandaAdm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSee;
        private Button btnProdukAdm;
        private Button btnTransaksiAdm;
        private Button btnLaporanKeuanganberandaadm;
    }
}