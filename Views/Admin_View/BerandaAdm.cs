using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngofee.Id.Views.Admin_View
{
    public partial class BerandaAdm : Form
    {
        public BerandaAdm()
        {
            InitializeComponent();
            btnSee.Click += btnSee_Click;
        }

        private void BerandaAdm_Load(object sender, EventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            var seeproduct = new V_DaftarProdukAdm();
            seeproduct.Show();
            this.Hide();
        }

        private void btnProdukAdm_Click(object sender, EventArgs e)
        {
            var halamanberanda = new V_DaftarProdukAdm();
            halamanberanda.Show();
            this.Hide();
        }
    }
}
