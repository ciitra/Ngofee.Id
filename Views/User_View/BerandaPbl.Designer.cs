namespace Ngofee.Id.Views
{
    partial class BerandaPbl
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
            btnBuy = new Button();
            btnProduk = new Button();
            btnRiwayatPbl = new Button();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Transparent;
            btnBuy.BackgroundImage = Properties.Resources.btnBuyLeave__1_;
            btnBuy.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.ForeColor = Color.Transparent;
            btnBuy.Location = new Point(90, 450);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(160, 49);
            btnBuy.TabIndex = 0;
            btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnProduk
            // 
            btnProduk.BackColor = Color.Transparent;
            btnProduk.FlatAppearance.BorderSize = 0;
            btnProduk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProduk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProduk.FlatStyle = FlatStyle.Flat;
            btnProduk.ImageAlign = ContentAlignment.TopCenter;
            btnProduk.Location = new Point(917, 34);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(98, 29);
            btnProduk.TabIndex = 1;
            btnProduk.UseVisualStyleBackColor = false;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnRiwayatPbl
            // 
            btnRiwayatPbl.BackColor = Color.Transparent;
            btnRiwayatPbl.BackgroundImageLayout = ImageLayout.Center;
            btnRiwayatPbl.FlatAppearance.BorderSize = 0;
            btnRiwayatPbl.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRiwayatPbl.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRiwayatPbl.FlatStyle = FlatStyle.Flat;
            btnRiwayatPbl.ForeColor = Color.Teal;
            btnRiwayatPbl.Location = new Point(679, 35);
            btnRiwayatPbl.Name = "btnRiwayatPbl";
            btnRiwayatPbl.Size = new Size(210, 29);
            btnRiwayatPbl.TabIndex = 2;
            btnRiwayatPbl.UseVisualStyleBackColor = false;
            btnRiwayatPbl.Click += btnRiwayatPbl_Click;
            // 
            // BerandaPbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BerandaPbl__1_;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnRiwayatPbl);
            Controls.Add(btnProduk);
            Controls.Add(btnBuy);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            Name = "BerandaPbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BerandaPbl";
            Load += BerandaPbl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuy;
        private Button btnProduk;
        private Button btnRiwayatPbl;
    }
}