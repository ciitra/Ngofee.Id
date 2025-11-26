namespace Ngofee.Id
{
    partial class V_FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TBUsername = new TextBox();
            TBPassword = new TextBox();
            btnLogin = new Button();
            linkLabelRgt = new LinkLabel();
            SuspendLayout();
            // 
            // TBUsername
            // 
            TBUsername.BackColor = Color.White;
            TBUsername.BorderStyle = BorderStyle.None;
            TBUsername.Location = new Point(830, 302);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(333, 20);
            TBUsername.TabIndex = 0;
            // 
            // TBPassword
            // 
            TBPassword.BackColor = Color.White;
            TBPassword.BorderStyle = BorderStyle.None;
            TBPassword.Location = new Point(830, 388);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(333, 20);
            TBPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = Properties.Resources.loginLeave;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(817, 470);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(360, 46);
            btnLogin.TabIndex = 2;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabelRgt
            // 
            linkLabelRgt.AutoSize = true;
            linkLabelRgt.BackColor = Color.Transparent;
            linkLabelRgt.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelRgt.LinkColor = Color.FromArgb(64, 0, 0);
            linkLabelRgt.Location = new Point(1034, 519);
            linkLabelRgt.Name = "linkLabelRgt";
            linkLabelRgt.Size = new Size(57, 17);
            linkLabelRgt.TabIndex = 3;
            linkLabelRgt.TabStop = true;
            linkLabelRgt.Text = "Register";
            linkLabelRgt.LinkClicked += linkLabelRgt_LinkClicked;
            // 
            // V_FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login__6_;
            ClientSize = new Size(1262, 673);
            Controls.Add(linkLabelRgt);
            Controls.Add(btnLogin);
            Controls.Add(TBPassword);
            Controls.Add(TBUsername);
            Name = "V_FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += V_FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBUsername;
        private TextBox TBPassword;
        private Button btnLogin;
        private LinkLabel linkLabelRgt;
    }
}
