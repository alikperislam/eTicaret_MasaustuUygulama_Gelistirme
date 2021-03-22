using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerce
{
    public partial class frmAyakkabı : Form
    {
        public frmAyakkabı()
        {
            InitializeComponent();
        }

        private void frmAyakkabı_Load(object sender, EventArgs e)
        {
            u1.pictureBox2.Image = Properties.Resources.sa1;
            u2.pictureBox2.Image = Properties.Resources.sa2;
            u3.pictureBox2.Image = Properties.Resources.sa3;
            u4.pictureBox2.Image = Properties.Resources.sa4;
            u5.pictureBox2.Image = Properties.Resources.sa5;
            u6.pictureBox2.Image = Properties.Resources.sa6;
            u7.pictureBox2.Image = Properties.Resources.sa7;
            u8.pictureBox2.Image = Properties.Resources.sa8;
            u9.pictureBox2.Image = Properties.Resources.sa9;
            u10.pictureBox2.Image = Properties.Resources.sa10;
            u11.pictureBox2.Image = Properties.Resources.sa11;
            u12.pictureBox2.Image = Properties.Resources.sa12;
            u13.pictureBox2.Image = Properties.Resources.sa13;
            u14.pictureBox2.Image = Properties.Resources.sa14;
            u15.pictureBox2.Image = Properties.Resources.sa15;

            // ürün bilgileri

            u1.label1.Text = "Forentina";
            u1.label2.Text = "93.47 ₺";
            u2.label1.Text = "Tulpar";
            u2.label2.Text = "134.99 ₺";
            u3.label1.Text = "Spectrum";
            u3.label2.Text = "67.05 ₺";
            u4.label1.Text = "Smartwatch As";
            u4.label2.Text = "198.00 ₺";
            u5.label1.Text = "Aqua Di Polo";
            u5.label2.Text = "64.99 ₺";
            u6.label1.Text = "Di Polo Pink";
            u6.label2.Text = "64.99 ₺";
            u7.label1.Text = "DeepWell";
            u7.label2.Text = "129.00 ₺";
            u8.label1.Text = "Polo Flower";
            u8.label2.Text = "39.99 ₺";
            u9.label1.Text = "Polo Air";
            u9.label2.Text = "77.40 ₺";
            u10.label1.Text = "Polo 1987";
            u10.label2.Text = "59.99 ₺";
            u11.label1.Text = "Polo Siyah";
            u11.label2.Text = "49.99 ₺";
            u12.label1.Text = "Huawei Watch";
            u12.label2.Text = "1214.73 ₺";
            u13.label1.Text = "Duke Nicle";
            u13.label2.Text = "69.90 ₺";
            u14.label1.Text = "Gold Time";
            u14.label2.Text = "124.94 ₺";
            u15.label1.Text = "SmartWatch";
            u15.label2.Text = "169.99 ₺";
        }

        private void u2_Load(object sender, EventArgs e)
        {

        }
    }
}
