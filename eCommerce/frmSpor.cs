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
    public partial class frmSpor : Form
    {
        public frmSpor()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSpor_Load(object sender, EventArgs e)
        {
            // ürün görselleri 

            u1.pictureBox2.Image = Properties.Resources.sp1;
            u2.pictureBox2.Image = Properties.Resources.sp2;
            u3.pictureBox2.Image = Properties.Resources.sp3;
            u4.pictureBox2.Image = Properties.Resources.sp4;
            u5.pictureBox2.Image = Properties.Resources.sp5;
            u6.pictureBox2.Image = Properties.Resources.sp6;
            u7.pictureBox2.Image = Properties.Resources.sp7;
            u8.pictureBox2.Image = Properties.Resources.sp8;
            u9.pictureBox2.Image = Properties.Resources.sp9;
            u10.pictureBox2.Image = Properties.Resources.sp10;
            u11.pictureBox2.Image = Properties.Resources.sp11;
            u12.pictureBox2.Image = Properties.Resources.sp12;
            u13.pictureBox2.Image = Properties.Resources.sp13;
            u14.pictureBox2.Image = Properties.Resources.sp14;
            u15.pictureBox2.Image = Properties.Resources.sp15;
            
            // ürün bilgileri

            u1.label1.Text = "Nike Ply";
            u1.label2.Text = "332.10 ₺";
            u2.label1.Text = "Nike Nsw";
            u2.label2.Text = "494.10 ₺";
            u3.label1.Text = "Nike Wnk";
            u3.label2.Text = "329.99 ₺";
            u4.label1.Text = "Nike Bv36Uni";
            u4.label2.Text = "539.90 ₺";
            u5.label1.Text = "Nike Drifit";
            u5.label2.Text = "166.24 ₺";
            u6.label1.Text = "Nike Eşofman";
            u6.label2.Text = "274.88 ₺";
            u7.label1.Text = "Nike Nsw Fz";
            u7.label2.Text = "412.49 ₺";
            u8.label1.Text = "Nike Jordan";
            u8.label2.Text = "335.92 ₺";
            u9.label1.Text = "Nike Trk S";
            u9.label2.Text = "530.91 ₺";
            u10.label1.Text = "Nike suit siyah";
            u10.label2.Text = "530.91 ₺";
            u11.label1.Text = "Nike Suit kadın";
            u11.label2.Text = "993.75 ₺";
            u12.label1.Text = "Boston Celtics";
            u12.label2.Text = "449.10 ₺";
            u13.label1.Text = "Nike Basic";
            u13.label2.Text = "749.55 ₺";
            u14.label1.Text = "Nike Hoodie";
            u14.label2.Text = "454.90 ₺";
            u15.label1.Text = "Nike Fleece";
            u15.label2.Text = "336.75 ₺";


        }
        UserControl1 user = new UserControl1();
        private void userControl12_Load(object sender, EventArgs e)
        {
            
        }

        private void u1_Load(object sender, EventArgs e)
        {

        }
    }
}
