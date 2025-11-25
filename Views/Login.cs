using Ngofee.Id.Views;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelRgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();

        }
    }
}
