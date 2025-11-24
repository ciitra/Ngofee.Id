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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            linkLabelRgt = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(830, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 20);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(830, 388);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 20);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(817, 470);
            button1.Name = "button1";
            button1.Size = new Size(360, 46);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
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
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "V_FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += V_FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkLabelRgt;
    }
}
