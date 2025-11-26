using Ngofee.Id.Views.User_View;
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
    public partial class BerandaPbl : Form
    {
        public BerandaPbl()
        {
            InitializeComponent();
            btnBuy.MouseLeave += (s, e) => btnBuy.BackgroundImage = Properties.Resources.btnBuyLeave__1_;
            btnBuy.Click += btnBuy_Click;
        }

        private void BerandaPbl_Load(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var berandapbl = new LihatProdukPbl();
            berandapbl.Show();
            this.Hide();
        }
    }
}
