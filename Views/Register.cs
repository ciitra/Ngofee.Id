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
    }
}
