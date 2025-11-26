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
            // BerandaPbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BerandaPbl__1_;
            ClientSize = new Size(1262, 673);
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
    }
}