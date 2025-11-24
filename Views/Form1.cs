namespace Ngofee.Id
{
    public partial class V_FormLogin : Form
    {
        public V_FormLogin()
        {
            InitializeComponent();
            button1.MouseEnter += (s, e) => button1.BackgroundImage = Properties.Resources.loginEnter;
            button1.MouseLeave += (s, e) => button1.BackgroundImage = Properties.Resources.loginLeave;
        }

        private void V_FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelRgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
