namespace Ngofee.Id.Views.Admin_View
{
    partial class V_HapusProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HapusProduk));
            flowHapusProduk = new FlowLayoutPanel();
            btnHapusProdukAfter = new Button();
            btnHapusProdukFix = new Button();
            btnHomehapusproduk = new Button();
            btnProdukhpsproduk = new Button();
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
            // btnHomehapusproduk
            // 
            btnHomehapusproduk.BackColor = Color.Transparent;
            btnHomehapusproduk.FlatAppearance.BorderSize = 0;
            btnHomehapusproduk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHomehapusproduk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHomehapusproduk.FlatStyle = FlatStyle.Flat;
            btnHomehapusproduk.Location = new Point(1156, 34);
            btnHomehapusproduk.Name = "btnHomehapusproduk";
            btnHomehapusproduk.Size = new Size(66, 29);
            btnHomehapusproduk.TabIndex = 3;
            btnHomehapusproduk.UseVisualStyleBackColor = false;
            btnHomehapusproduk.Click += btnHomehapusproduk_Click;
            // 
            // btnProdukhpsproduk
            // 
            btnProdukhpsproduk.BackColor = Color.Transparent;
            btnProdukhpsproduk.FlatAppearance.BorderSize = 0;
            btnProdukhpsproduk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProdukhpsproduk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProdukhpsproduk.FlatStyle = FlatStyle.Flat;
            btnProdukhpsproduk.Location = new Point(1027, 34);
            btnProdukhpsproduk.Name = "btnProdukhpsproduk";
            btnProdukhpsproduk.Size = new Size(83, 29);
            btnProdukhpsproduk.TabIndex = 4;
            btnProdukhpsproduk.UseVisualStyleBackColor = false;
            btnProdukhpsproduk.Click += btnProdukhpsproduk_Click;
            // 
            // HapusProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 703);
            Controls.Add(btnProdukhpsproduk);
            Controls.Add(btnHomehapusproduk);
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
        private Button btnHomehapusproduk;
        private Button btnProdukhpsproduk;
    }
}