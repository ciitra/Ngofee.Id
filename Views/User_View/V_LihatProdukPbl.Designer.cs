namespace Ngofee.Id.Views.User_View
{
    partial class LihatProdukPbl
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
            btnBeliSekarang = new Button();
            btnHome = new Button();
            btnRiwayatPbl_lihatproduk = new Button();
            FlowProduk = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnBeliSekarang
            // 
            btnBeliSekarang.BackColor = Color.Transparent;
            btnBeliSekarang.BackgroundImage = Properties.Resources.btnBeliSekarang;
            btnBeliSekarang.BackgroundImageLayout = ImageLayout.Zoom;
            btnBeliSekarang.FlatAppearance.BorderSize = 0;
            btnBeliSekarang.FlatStyle = FlatStyle.Flat;
            btnBeliSekarang.Location = new Point(475, 619);
            btnBeliSekarang.Name = "btnBeliSekarang";
            btnBeliSekarang.Size = new Size(296, 63);
            btnBeliSekarang.TabIndex = 0;
            btnBeliSekarang.UseVisualStyleBackColor = false;
            btnBeliSekarang.Click += btnBeliSekarang_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.Transparent;
            btnHome.Location = new Point(1045, 34);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 1;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnRiwayatPbl_lihatproduk
            // 
            btnRiwayatPbl_lihatproduk.BackColor = Color.Transparent;
            btnRiwayatPbl_lihatproduk.BackgroundImageLayout = ImageLayout.Center;
            btnRiwayatPbl_lihatproduk.FlatAppearance.BorderSize = 0;
            btnRiwayatPbl_lihatproduk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRiwayatPbl_lihatproduk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRiwayatPbl_lihatproduk.FlatStyle = FlatStyle.Flat;
            btnRiwayatPbl_lihatproduk.ForeColor = Color.Transparent;
            btnRiwayatPbl_lihatproduk.Location = new Point(688, 34);
            btnRiwayatPbl_lihatproduk.Name = "btnRiwayatPbl_lihatproduk";
            btnRiwayatPbl_lihatproduk.Size = new Size(196, 29);
            btnRiwayatPbl_lihatproduk.TabIndex = 2;
            btnRiwayatPbl_lihatproduk.UseVisualStyleBackColor = false;
            btnRiwayatPbl_lihatproduk.Click += btnRiwayatPbl_lihatproduk_Click;
            // 
            // FlowProduk
            // 
            FlowProduk.AutoScroll = true;
            FlowProduk.BackColor = Color.Transparent;
            FlowProduk.Location = new Point(83, 89);
            FlowProduk.Margin = new Padding(0);
            FlowProduk.Name = "FlowProduk";
            FlowProduk.Padding = new Padding(20, 10, 20, 10);
            FlowProduk.Size = new Size(1100, 497);
            FlowProduk.TabIndex = 3;
            FlowProduk.Paint += flowLayoutPanel1_Paint;
            FlowProduk.FlowDirection = FlowDirection.LeftToRight;
            FlowProduk.WrapContents = true;
            FlowProduk.AutoSize = false;
            FlowProduk.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // 
            // LihatProdukPbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LihatProdukPbl;
            ClientSize = new Size(1262, 703);
            Controls.Add(FlowProduk);
            Controls.Add(btnRiwayatPbl_lihatproduk);
            Controls.Add(btnHome);
            Controls.Add(btnBeliSekarang);
            Location = new Point(120, 150);
            Name = "LihatProdukPbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LihatProdukPbl";
            Load += LihatProdukPbl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBeliSekarang;
        private Button btnHome;
        private Button btnRiwayatPbl_lihatproduk;
        private FlowLayoutPanel FlowProduk;
    }
}