using Ngofee.Id.Controllers;
using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngofee.Id.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            btnRegister.MouseEnter += (s, e) => btnRegister.BackgroundImage = Properties.Resources.registerEnter;
            btnRegister.MouseLeave += (s, e) => btnRegister.BackgroundImage = Properties.Resources.registerLeave;

        }

        private void TBUsernameRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = new AuthController();

                var user = new UserModel
                {
                    Username = TBUsernameRg.Text,
                    Password = TBPasswordRg.Text,
                    Email = TBEmailRg.Text,
                    NoTelepon = TBNoTeleponRg.Text,
                    Role = UserRole.pembeli
                };

                bool success = auth.Register(user);

                if (success)
                {
                    MessageBox.Show("Register berhasil!");

                    var loginForm = new V_FormLogin();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Register gagal!\nPeriksa koneksi atau input.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error saat register: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
