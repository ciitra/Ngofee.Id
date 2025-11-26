namespace Ngofee.Id.Views.Admin_View
{
    partial class BerandaAdm
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
            btnSee = new Button();
            SuspendLayout();
            // 
            // btnSee
            // 
            btnSee.BackColor = Color.Transparent;
            btnSee.BackgroundImage = Properties.Resources.btnSee;
            btnSee.BackgroundImageLayout = ImageLayout.Zoom;
            btnSee.FlatAppearance.BorderSize = 0;
            btnSee.FlatStyle = FlatStyle.Flat;
            btnSee.ForeColor = Color.Transparent;
            btnSee.Location = new Point(91, 448);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(173, 51);
            btnSee.TabIndex = 0;
            btnSee.UseVisualStyleBackColor = false;
            // 
            // BerandaAdm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Beranda_Admin;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnSee);
            Name = "BerandaAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BerandaAdm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSee;
    }
}