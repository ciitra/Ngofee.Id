namespace Ngofee.Id.Views.Admin_View
{
    partial class HapusProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HapusProduk));
            flowHapusProduk = new FlowLayoutPanel();
            btnHapusProdukAfter = new Button();
            btnHapusProdukFix = new Button();
            SuspendLayout();
            // 
            // flowHapusProduk
            // 
            flowHapusProduk.AutoScroll = true;
            flowHapusProduk.BackColor = Color.Transparent;
            flowHapusProduk.FlowDirection = FlowDirection.TopDown;
            flowHapusProduk.Location = new Point(93, 176);
            flowHapusProduk.Name = "flowHapusProduk";
            flowHapusProduk.Size = new Size(1081, 425);
            flowHapusProduk.TabIndex = 0;
            flowHapusProduk.WrapContents = false;
            flowHapusProduk.Paint += flowHapusProduk_Paint;
            // 
            // btnHapusProdukAfter
            // 
            btnHapusProdukAfter.BackColor = Color.Transparent;
            btnHapusProdukAfter.BackgroundImageLayout = ImageLayout.None;
            btnHapusProdukAfter.FlatAppearance.BorderSize = 0;
            btnHapusProdukAfter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHapusProdukAfter.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHapusProdukAfter.FlatStyle = FlatStyle.Flat;
            btnHapusProdukAfter.Location = new Point(882, 99);
            btnHapusProdukAfter.Name = "btnHapusProdukAfter";
            btnHapusProdukAfter.Size = new Size(120, 42);
            btnHapusProdukAfter.TabIndex = 1;
            btnHapusProdukAfter.UseVisualStyleBackColor = false;
            // 
            // btnHapusProdukFix
            // 
            btnHapusProdukFix.BackColor = Color.Transparent;
            btnHapusProdukFix.BackgroundImageLayout = ImageLayout.None;
            btnHapusProdukFix.FlatAppearance.BorderSize = 0;
            btnHapusProdukFix.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHapusProdukFix.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHapusProdukFix.FlatStyle = FlatStyle.Flat;
            btnHapusProdukFix.Location = new Point(1067, 631);
            btnHapusProdukFix.Name = "btnHapusProdukFix";
            btnHapusProdukFix.Size = new Size(183, 42);
            btnHapusProdukFix.TabIndex = 2;
            btnHapusProdukFix.UseVisualStyleBackColor = false;
            btnHapusProdukFix.Click += btnHapusProdukFix_Click;
            // 
            // HapusProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 703);
            Controls.Add(btnHapusProdukFix);
            Controls.Add(btnHapusProdukAfter);
            Controls.Add(flowHapusProduk);
            Name = "HapusProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HapusProduk";
            Load += HapusProduk_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowHapusProduk;
        private Button btnHapusProdukAfter;
        private Button btnHapusProdukFix;
    }
}