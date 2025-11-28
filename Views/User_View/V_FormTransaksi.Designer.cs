namespace Ngofee.Id.Views.User_View
{
    partial class V_FormTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_FormTransaksi));
            flowPesanan = new FlowLayoutPanel();
            lblTotalJumlah = new Label();
            lblTotalHarga = new Label();
            namaPenerima = new Label();
            txtNamaPenerima = new TextBox();
            alamatTujuan = new Label();
            txtAlamat = new TextBox();
            metodePengiriman = new Label();
            txtPengiriman = new TextBox();
            kodePembayaran = new Label();
            pbQris = new PictureBox();
            buktiBaayar = new Label();
            pbBuktiPembayaran = new PictureBox();
            btnUploadBukti = new Button();
            btnBuatPesanan = new Button();
            qris = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQris).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuktiPembayaran).BeginInit();
            SuspendLayout();
            // 
            // flowPesanan
            // 
            flowPesanan.AutoScroll = true;
            flowPesanan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPesanan.Location = new Point(92, 143);
            flowPesanan.Name = "flowPesanan";
            flowPesanan.Size = new Size(517, 390);
            flowPesanan.TabIndex = 0;
            // 
            // lblTotalJumlah
            // 
            lblTotalJumlah.AutoSize = true;
            lblTotalJumlah.Location = new Point(489, 565);
            lblTotalJumlah.Name = "lblTotalJumlah";
            lblTotalJumlah.Size = new Size(0, 20);
            lblTotalJumlah.TabIndex = 1;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Location = new Point(489, 591);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(0, 20);
            lblTotalHarga.TabIndex = 2;
            // 
            // namaPenerima
            // 
            namaPenerima.AutoSize = true;
            namaPenerima.BackColor = Color.Transparent;
            namaPenerima.FlatStyle = FlatStyle.Flat;
            namaPenerima.Font = new Font("Microsoft Sans Serif", 10.2F);
            namaPenerima.Location = new Point(681, 118);
            namaPenerima.Name = "namaPenerima";
            namaPenerima.Size = new Size(129, 20);
            namaPenerima.TabIndex = 3;
            namaPenerima.Text = "Nama Penerima";
            // 
            // txtNamaPenerima
            // 
            txtNamaPenerima.BackColor = Color.Gainsboro;
            txtNamaPenerima.BorderStyle = BorderStyle.None;
            txtNamaPenerima.Font = new Font("Arial", 10.2F);
            txtNamaPenerima.Location = new Point(685, 143);
            txtNamaPenerima.Multiline = true;
            txtNamaPenerima.Name = "txtNamaPenerima";
            txtNamaPenerima.Size = new Size(464, 25);
            txtNamaPenerima.TabIndex = 4;
            // 
            // alamatTujuan
            // 
            alamatTujuan.AutoSize = true;
            alamatTujuan.BackColor = Color.Transparent;
            alamatTujuan.FlatStyle = FlatStyle.Flat;
            alamatTujuan.Font = new Font("Microsoft Sans Serif", 10.2F);
            alamatTujuan.Location = new Point(685, 173);
            alamatTujuan.Name = "alamatTujuan";
            alamatTujuan.Size = new Size(116, 20);
            alamatTujuan.TabIndex = 5;
            alamatTujuan.Text = "Alamat Tujuan";
            // 
            // txtAlamat
            // 
            txtAlamat.BackColor = Color.Gainsboro;
            txtAlamat.BorderStyle = BorderStyle.None;
            txtAlamat.Font = new Font("Arial", 10.2F);
            txtAlamat.Location = new Point(685, 196);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(464, 53);
            txtAlamat.TabIndex = 6;
            // 
            // metodePengiriman
            // 
            metodePengiriman.AutoSize = true;
            metodePengiriman.BackColor = Color.Transparent;
            metodePengiriman.FlatStyle = FlatStyle.Flat;
            metodePengiriman.Font = new Font("Microsoft Sans Serif", 10.2F);
            metodePengiriman.Location = new Point(685, 254);
            metodePengiriman.Name = "metodePengiriman";
            metodePengiriman.Size = new Size(153, 20);
            metodePengiriman.TabIndex = 7;
            metodePengiriman.Text = "Metode Pengiriman";
            // 
            // txtPengiriman
            // 
            txtPengiriman.BackColor = Color.Gainsboro;
            txtPengiriman.BorderStyle = BorderStyle.None;
            txtPengiriman.Font = new Font("Arial", 10.2F);
            txtPengiriman.Location = new Point(685, 277);
            txtPengiriman.Multiline = true;
            txtPengiriman.Name = "txtPengiriman";
            txtPengiriman.Size = new Size(464, 30);
            txtPengiriman.TabIndex = 8;
            // 
            // kodePembayaran
            // 
            kodePembayaran.AutoSize = true;
            kodePembayaran.BackColor = Color.Transparent;
            kodePembayaran.FlatStyle = FlatStyle.Flat;
            kodePembayaran.Font = new Font("Microsoft Sans Serif", 10.2F);
            kodePembayaran.Location = new Point(685, 318);
            kodePembayaran.Name = "kodePembayaran";
            kodePembayaran.Size = new Size(145, 20);
            kodePembayaran.TabIndex = 9;
            kodePembayaran.Text = "Kode Pembayaran";
            // 
            // pbQris
            // 
            pbQris.BackgroundImage = (Image)resources.GetObject("pbQris.BackgroundImage");
            pbQris.BackgroundImageLayout = ImageLayout.Zoom;
            pbQris.Location = new Point(685, 348);
            pbQris.Name = "pbQris";
            pbQris.Size = new Size(191, 203);
            pbQris.TabIndex = 10;
            pbQris.TabStop = false;
            // 
            // buktiBaayar
            // 
            buktiBaayar.AutoSize = true;
            buktiBaayar.BackColor = Color.Transparent;
            buktiBaayar.FlatStyle = FlatStyle.Flat;
            buktiBaayar.Font = new Font("Microsoft Sans Serif", 10.2F);
            buktiBaayar.Location = new Point(947, 318);
            buktiBaayar.Name = "buktiBaayar";
            buktiBaayar.Size = new Size(202, 20);
            buktiBaayar.TabIndex = 11;
            buktiBaayar.Text = "Upload Bukti Pembayaran";
            // 
            // pbBuktiPembayaran
            // 
            pbBuktiPembayaran.Location = new Point(947, 348);
            pbBuktiPembayaran.Name = "pbBuktiPembayaran";
            pbBuktiPembayaran.Size = new Size(194, 135);
            pbBuktiPembayaran.TabIndex = 12;
            pbBuktiPembayaran.TabStop = false;
            // 
            // btnUploadBukti
            // 
            btnUploadBukti.BackColor = Color.Transparent;
            btnUploadBukti.FlatStyle = FlatStyle.Flat;
            btnUploadBukti.Location = new Point(997, 396);
            btnUploadBukti.Name = "btnUploadBukti";
            btnUploadBukti.Size = new Size(94, 29);
            btnUploadBukti.TabIndex = 13;
            btnUploadBukti.Text = "Upload Bukti";
            btnUploadBukti.UseVisualStyleBackColor = false;
            btnUploadBukti.Click += btnUploadBukti_Click;
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.BackColor = Color.Transparent;
            btnBuatPesanan.FlatAppearance.BorderSize = 0;
            btnBuatPesanan.FlatStyle = FlatStyle.Flat;
            btnBuatPesanan.Location = new Point(927, 632);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(240, 50);
            btnBuatPesanan.TabIndex = 14;
            btnBuatPesanan.UseVisualStyleBackColor = false;
            btnBuatPesanan.Click += btnBuatPesanan_Click;

            // 
            // qris
            // 
            qris.AutoSize = true;
            qris.BackColor = Color.Transparent;
            qris.FlatStyle = FlatStyle.Flat;
            qris.Font = new Font("Microsoft Sans Serif", 10.2F);
            qris.Location = new Point(754, 555);
            qris.Name = "qris";
            qris.Size = new Size(49, 20);
            qris.TabIndex = 15;
            qris.Text = "QRIS";
            // 
            // V_FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 710);
            Controls.Add(qris);
            Controls.Add(btnBuatPesanan);
            Controls.Add(btnUploadBukti);
            Controls.Add(pbBuktiPembayaran);
            Controls.Add(buktiBaayar);
            Controls.Add(pbQris);
            Controls.Add(kodePembayaran);
            Controls.Add(txtPengiriman);
            Controls.Add(metodePengiriman);
            Controls.Add(txtAlamat);
            Controls.Add(alamatTujuan);
            Controls.Add(txtNamaPenerima);
            Controls.Add(namaPenerima);
            Controls.Add(lblTotalHarga);
            Controls.Add(lblTotalJumlah);
            Controls.Add(flowPesanan);
            Name = "V_FormTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_FormTransaksi";
            Load += V_FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)pbQris).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBuktiPembayaran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPesanan;
        private Label lblTotalJumlah;
        private Label lblTotalHarga;
        private Label namaPenerima;
        private TextBox txtNamaPenerima;
        private Label alamatTujuan;
        private TextBox txtAlamat;
        private Label metodePengiriman;
        private TextBox txtPengiriman;
        private Label kodePembayaran;
        private PictureBox pbQris;
        private Label buktiBaayar;
        private PictureBox pbBuktiPembayaran;
        private Button btnUploadBukti;
        private Button btnBuatPesanan;
        private Label qris;
    }
}