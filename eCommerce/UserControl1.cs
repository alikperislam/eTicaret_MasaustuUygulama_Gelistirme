using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerce
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btnSatınAl.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnSatınAl.Visible = false;
        }
    }
}
