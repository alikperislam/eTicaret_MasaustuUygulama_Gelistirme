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
    public partial class frmKozmetik : Form
    {
        public frmKozmetik()
        {
            InitializeComponent();
        }

        private void frmKozmetik_Load(object sender, EventArgs e)
        {
            u1.pictureBox2.Image = Properties.Resources.ko1;
            u2.pictureBox2.Image = Properties.Resources.ko2;
            u3.pictureBox2.Image = Properties.Resources.ko3;
            u4.pictureBox2.Image = Properties.Resources.ko4;
            u5.pictureBox2.Image = Properties.Resources.ko5;
            u6.pictureBox2.Image = Properties.Resources.ko6;
            u7.pictureBox2.Image = Properties.Resources.ko7;
            u8.pictureBox2.Image = Properties.Resources.ko8;
            u9.pictureBox2.Image = Properties.Resources.ko9;
            u10.pictureBox2.Image = Properties.Resources.ko10;
            u11.pictureBox2.Image = Properties.Resources.ko11;
            u12.pictureBox2.Image = Properties.Resources.ko12;
            u13.pictureBox2.Image = Properties.Resources.ko13;
            u14.pictureBox2.Image = Properties.Resources.ko14;
            u15.pictureBox2.Image = Properties.Resources.ko15;

            // ürün bilgileri

            u1.label1.Text = "Lo'real Paris";
            u1.label2.Text = "57.45 ₺";
            u2.label1.Text = "Kolajen Serum";
            u2.label2.Text = "109.90 ₺";
            u3.label1.Text = "Jowe";
            u3.label2.Text = "89.90 ₺";
            u4.label1.Text = "Diş Beyazlatıcı";
            u4.label2.Text = "59.90 ₺";
            u5.label1.Text = "Sinoz";
            u5.label2.Text = "129.90 ₺";
            u6.label1.Text = "The Purest";
            u6.label2.Text = "99.90 ₺";
            u7.label1.Text = "Herbal";
            u7.label2.Text = "58.80 ₺";
            u8.label1.Text = "Maybelline";
            u8.label2.Text = "74.90 ₺";
            u9.label1.Text = "Lash Paradise";
            u9.label2.Text = "66.45 ₺";
            u10.label1.Text = "Avon Dress";
            u10.label2.Text = "84.50 ₺";
            u11.label1.Text = "Butter Cream";
            u11.label2.Text = "58.80 ₺";
            u12.label1.Text = "Mascara";
            u12.label2.Text = "34.50 ₺";
            u13.label1.Text = "Kaş-Kirpik";
            u13.label2.Text = "37.90 ₺";
            u14.label1.Text = "Velvet";
            u14.label2.Text = "121.00 ₺";
            u15.label1.Text = "Mara Manikür";
            u15.label2.Text = "49.90 ₺";
        }

        private void u3_Load(object sender, EventArgs e)
        {

        }
    }
}
