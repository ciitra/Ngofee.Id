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
            SuspendLayout();
            // 
            // btnBeliSekarang
            // 
            btnBeliSekarang.BackColor = Color.Transparent;
            btnBeliSekarang.BackgroundImage = Properties.Resources.btnBeliSekarang;
            btnBeliSekarang.BackgroundImageLayout = ImageLayout.Zoom;
            btnBeliSekarang.FlatAppearance.BorderSize = 0;
            btnBeliSekarang.FlatStyle = FlatStyle.Flat;
            btnBeliSekarang.Location = new Point(488, 609);
            btnBeliSekarang.Name = "btnBeliSekarang";
            btnBeliSekarang.Size = new Size(296, 63);
            btnBeliSekarang.TabIndex = 0;
            btnBeliSekarang.UseVisualStyleBackColor = false;
            // 
            // LihatProdukPbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LihatProdukPbl;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnBeliSekarang);
            Name = "LihatProdukPbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LihatProdukPbl";
            Load += this.LihatProdukPbl_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBeliSekarang;
    }
}