namespace Ngofee.Id.Views
{
    partial class Register
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
            TBNamaRg = new TextBox();
            TBPasswordRg = new TextBox();
            TBEmailRg = new TextBox();
            TBNoTeleponRg = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // TBNamaRg
            // 
            TBNamaRg.BorderStyle = BorderStyle.None;
            TBNamaRg.Location = new Point(838, 238);
            TBNamaRg.Name = "TBNamaRg";
            TBNamaRg.Size = new Size(354, 20);
            TBNamaRg.TabIndex = 0;
            // 
            // TBPasswordRg
            // 
            TBPasswordRg.BorderStyle = BorderStyle.None;
            TBPasswordRg.Location = new Point(838, 327);
            TBPasswordRg.Name = "TBPasswordRg";
            TBPasswordRg.Size = new Size(354, 20);
            TBPasswordRg.TabIndex = 1;
            // 
            // TBEmailRg
            // 
            TBEmailRg.BorderStyle = BorderStyle.None;
            TBEmailRg.Location = new Point(838, 404);
            TBEmailRg.Name = "TBEmailRg";
            TBEmailRg.Size = new Size(354, 20);
            TBEmailRg.TabIndex = 2;
            // 
            // TBNoTeleponRg
            // 
            TBNoTeleponRg.BorderStyle = BorderStyle.None;
            TBNoTeleponRg.Location = new Point(838, 491);
            TBNoTeleponRg.Name = "TBNoTeleponRg";
            TBNoTeleponRg.Size = new Size(354, 20);
            TBNoTeleponRg.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BackgroundImage = Properties.Resources.registerLeave;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(832, 563);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(375, 46);
            btnRegister.TabIndex = 4;
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Register;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnRegister);
            Controls.Add(TBNoTeleponRg);
            Controls.Add(TBEmailRg);
            Controls.Add(TBPasswordRg);
            Controls.Add(TBNamaRg);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBNamaRg;
        private TextBox TBPasswordRg;
        private TextBox TBEmailRg;
        private TextBox TBNoTeleponRg;
        private Button btnRegister;
    }
}