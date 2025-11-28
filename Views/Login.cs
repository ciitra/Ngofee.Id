using Ngofee.Id.Controllers;
using Ngofee.Id.Helpers;
using Ngofee.Id.Models;
using Ngofee.Id.Views;
using Ngofee.Id.Views.Admin_View;

namespace Ngofee.Id
{
    public partial class V_FormLogin : Form
    {
        public V_FormLogin()
        {
            InitializeComponent();
            btnLogin.MouseEnter += (s, e) => btnLogin.BackgroundImage = Properties.Resources.loginEnter;
            btnLogin.MouseLeave += (s, e) => btnLogin.BackgroundImage = Properties.Resources.loginLeave;
        }
        private void V_FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = new AuthController();

                var user = new UserModel
                {
                    Username = TBUsername.Text,
                    Password = TBPassword.Text
                };

                var result = auth.Login(user);

                if (result != null)
                {
                    AppSession.SetUser(result);
                    MessageBox.Show("Login berhasil!");

                    if (result.Role == UserRole.admin)
                    {
                        var adminHome = new BerandaAdm();
                        this.Hide();
                        adminHome.Show();
                    }
                    else
                    {
                        var pembeliHome = new BerandaPbl();
                        this.Hide();
                        pembeliHome.Show();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi error saat login:\n" + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void linkLabelRgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
