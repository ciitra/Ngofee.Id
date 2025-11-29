namespace Ngofee.Id.Views.Admin_View
{
    partial class V_StatusPesananAdm
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowTransaksi;

        private void InitializeComponent()
        {
            flowTransaksi = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowTransaksi
            // 
            flowTransaksi.AutoScroll = true;
            flowTransaksi.Location = new Point(50, 150);
            flowTransaksi.Name = "flowTransaksi";
            flowTransaksi.Size = new Size(1150, 500);
            flowTransaksi.TabIndex = 0;
            // 
            // V_StatusPesananAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Transaksi_Masuk__1_1;
            ClientSize = new Size(1264, 681);
            Controls.Add(flowTransaksi);
            Name = "V_StatusPesananAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Status Pesanan Admin";
            Load += V_StatusPesananAdm_Load;
            ResumeLayout(false);
        }
    }
}
