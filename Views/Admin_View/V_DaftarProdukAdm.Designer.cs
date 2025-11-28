namespace Ngofee.Id.Views.Admin_View
{
    partial class V_DaftarProdukAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DaftarProdukAdm));
            flowAdminProduk = new FlowLayoutPanel();
            btnTambahProdukBefore = new Button();
            btnHapusProdukBefore = new Button();
            btnHomeDaftarProdukAdm = new Button();
            SuspendLayout();
            // 
            // flowAdminProduk
            // 
            flowAdminProduk.AutoScroll = true;
            flowAdminProduk.BackColor = Color.Transparent;
            flowAdminProduk.FlowDirection = FlowDirection.TopDown;
            flowAdminProduk.Location = new Point(73, 194);
            flowAdminProduk.Name = "flowAdminProduk";
            flowAdminProduk.Size = new Size(1120, 443);
            flowAdminProduk.TabIndex = 0;
            flowAdminProduk.WrapContents = false;
            flowAdminProduk.Paint += flowAdminProduk_Paint;
            // 
            // btnTambahProdukBefore
            // 
            btnTambahProdukBefore.BackColor = Color.Transparent;
            btnTambahProdukBefore.FlatAppearance.BorderSize = 0;
            btnTambahProdukBefore.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTambahProdukBefore.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTambahProdukBefore.FlatStyle = FlatStyle.Flat;
            btnTambahProdukBefore.ForeColor = Color.White;
            btnTambahProdukBefore.Location = new Point(1032, 100);
            btnTambahProdukBefore.Name = "btnTambahProdukBefore";
            btnTambahProdukBefore.Size = new Size(194, 41);
            btnTambahProdukBefore.TabIndex = 1;
            btnTambahProdukBefore.UseVisualStyleBackColor = false;
            btnTambahProdukBefore.Click += btnTambahProdukBefore_Click;
            // 
            // btnHapusProdukBefore
            // 
            btnHapusProdukBefore.BackColor = Color.Transparent;
            btnHapusProdukBefore.FlatAppearance.BorderSize = 0;
            btnHapusProdukBefore.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHapusProdukBefore.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHapusProdukBefore.FlatStyle = FlatStyle.Flat;
            btnHapusProdukBefore.Location = new Point(884, 100);
            btnHapusProdukBefore.Name = "btnHapusProdukBefore";
            btnHapusProdukBefore.Size = new Size(130, 41);
            btnHapusProdukBefore.TabIndex = 2;
            btnHapusProdukBefore.UseVisualStyleBackColor = false;
            btnHapusProdukBefore.Click += btnHapusProdukBefore_Click;
            // 
            // btnHomeDaftarProdukAdm
            // 
            btnHomeDaftarProdukAdm.BackColor = Color.Transparent;
            btnHomeDaftarProdukAdm.FlatAppearance.BorderSize = 0;
            btnHomeDaftarProdukAdm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHomeDaftarProdukAdm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHomeDaftarProdukAdm.FlatStyle = FlatStyle.Flat;
            btnHomeDaftarProdukAdm.Location = new Point(1151, 34);
            btnHomeDaftarProdukAdm.Name = "btnHomeDaftarProdukAdm";
            btnHomeDaftarProdukAdm.Size = new Size(75, 30);
            btnHomeDaftarProdukAdm.TabIndex = 3;
            btnHomeDaftarProdukAdm.UseVisualStyleBackColor = false;
            btnHomeDaftarProdukAdm.Click += btnHomeDaftarProdukAdm_Click;
            // 
            // V_DaftarProdukAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
            Controls.Add(btnHomeDaftarProdukAdm);
            Controls.Add(btnHapusProdukBefore);
            Controls.Add(btnTambahProdukBefore);
            Controls.Add(flowAdminProduk);
            Name = "V_DaftarProdukAdm";
            Load += V_DaftarProdukAdm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowAdminProduk;
        private Button btnTambahProdukBefore;
        private Button btnHapusProdukBefore;
        private Button btnHomeDaftarProdukAdm;
    }
}