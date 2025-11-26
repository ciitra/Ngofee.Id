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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            btnLoginLp.MouseEnter += (s, e) => btnLoginLp.BackgroundImage = Properties.Resources.LoginEnterLp;
            btnLoginLp.MouseLeave += (s, e) => btnLoginLp.BackgroundImage = Properties.Resources.LoginLeaveLp;
            btnLoginLp.Click += btnLoginLp_Click;
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
        private void btnLoginLp_Click(object sender, EventArgs e)
        {
            var login = new V_FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
