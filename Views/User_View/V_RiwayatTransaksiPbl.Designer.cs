namespace Ngofee.Id.Views.User_View
{
    partial class V_RiwayatTransaksiPbl
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatTransaksiPbl));
            flowRiwayatPbl = new FlowLayoutPanel();
            btnHomeriwayatpbl = new Button();
            btnProdukriwayarpbl = new Button();
            btnRiwayatpesananpbl = new Button();
            SuspendLayout();
            // 
            // flowRiwayatPbl
            // 
            flowRiwayatPbl.AutoScroll = true;
            flowRiwayatPbl.Location = new Point(80, 180);
            flowRiwayatPbl.Name = "flowRiwayatPbl";
            flowRiwayatPbl.Size = new Size(1100, 460);
            flowRiwayatPbl.TabIndex = 0;
            // 
            // btnHomeriwayatpbl
            // 
            btnHomeriwayatpbl.BackColor = Color.Transparent;
            btnHomeriwayatpbl.FlatAppearance.BorderSize = 0;
            btnHomeriwayatpbl.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHomeriwayatpbl.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHomeriwayatpbl.FlatStyle = FlatStyle.Flat;
            btnHomeriwayatpbl.Location = new Point(1059, 36);
            btnHomeriwayatpbl.Name = "btnHomeriwayatpbl";
            btnHomeriwayatpbl.Size = new Size(64, 24);
            btnHomeriwayatpbl.TabIndex = 1;
            btnHomeriwayatpbl.UseVisualStyleBackColor = false;
            btnHomeriwayatpbl.Click += btnHomeriwayatpbl_Click;
            // 
            // btnProdukriwayarpbl
            // 
            btnProdukriwayarpbl.BackColor = Color.Transparent;
            btnProdukriwayarpbl.FlatAppearance.BorderSize = 0;
            btnProdukriwayarpbl.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProdukriwayarpbl.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProdukriwayarpbl.FlatStyle = FlatStyle.Flat;
            btnProdukriwayarpbl.Location = new Point(927, 36);
            btnProdukriwayarpbl.Name = "btnProdukriwayarpbl";
            btnProdukriwayarpbl.Size = new Size(83, 24);
            btnProdukriwayarpbl.TabIndex = 2;
            btnProdukriwayarpbl.UseVisualStyleBackColor = false;
            btnProdukriwayarpbl.Click += btnProdukriwayarpbl_Click;
            // 
            // btnRiwayatpesananpbl
            // 
            btnRiwayatpesananpbl.BackColor = Color.Transparent;
            btnRiwayatpesananpbl.FlatAppearance.BorderSize = 0;
            btnRiwayatpesananpbl.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRiwayatpesananpbl.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRiwayatpesananpbl.FlatStyle = FlatStyle.Flat;
            btnRiwayatpesananpbl.Location = new Point(690, 36);
            btnRiwayatpesananpbl.Name = "btnRiwayatpesananpbl";
            btnRiwayatpesananpbl.Size = new Size(189, 24);
            btnRiwayatpesananpbl.TabIndex = 3;
            btnRiwayatpesananpbl.UseVisualStyleBackColor = false;
            btnRiwayatpesananpbl.Click += btnRiwayatpesananpbl_Click;
            // 
            // V_RiwayatTransaksiPbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
            Controls.Add(btnRiwayatpesananpbl);
            Controls.Add(btnProdukriwayarpbl);
            Controls.Add(btnHomeriwayatpbl);
            Controls.Add(flowRiwayatPbl);
            Name = "V_RiwayatTransaksiPbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat Pembelian";
            Load += V_RiwayatTransaksiPbl_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowRiwayatPbl;
        private Button btnHomeriwayatpbl;
        private Button btnProdukriwayarpbl;
        private Button btnRiwayatpesananpbl;
    }
}