namespace Ngofee.Id.Views
{
    partial class LandingPage
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
            btnLoginLp = new Button();
            SuspendLayout();
            // 
            // btnLoginLp
            // 
            btnLoginLp.BackColor = Color.Transparent;
            btnLoginLp.BackgroundImage = Properties.Resources.LoginLeaveLp;
            btnLoginLp.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoginLp.FlatAppearance.BorderSize = 0;
            btnLoginLp.FlatStyle = FlatStyle.Flat;
            btnLoginLp.ForeColor = Color.Transparent;
            btnLoginLp.Location = new Point(110, 444);
            btnLoginLp.Name = "btnLoginLp";
            btnLoginLp.Size = new Size(177, 48);
            btnLoginLp.TabIndex = 0;
            btnLoginLp.UseVisualStyleBackColor = false;
            // 
            // LandingPage
            // 
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.LandingPage1;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnLoginLp);
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LandingPage_Load;
            ResumeLayout(false);

        }

        #endregion

        private Button btnLoginLp;
    }
}