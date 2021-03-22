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
    public partial class frmCanta : Form
    {
        public frmCanta()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCanta_Load(object sender, EventArgs e)
        {
            u1.pictureBox2.Image = Properties.Resources.c1;
            u2.pictureBox2.Image = Properties.Resources.c2;
            u3.pictureBox2.Image = Properties.Resources.c3;
            u4.pictureBox2.Image = Properties.Resources.c4;
            u5.pictureBox2.Image = Properties.Resources.c5;
            u6.pictureBox2.Image = Properties.Resources.c6;
            u7.pictureBox2.Image = Properties.Resources.c7;
            u8.pictureBox2.Image = Properties.Resources.c8;
            u9.pictureBox2.Image = Properties.Resources.c9;
            u10.pictureBox2.Image = Properties.Resources.c10;
            u11.pictureBox2.Image = Properties.Resources.c11;
            u12.pictureBox2.Image = Properties.Resources.c12;
            u13.pictureBox2.Image = Properties.Resources.c13;
            u14.pictureBox2.Image = Properties.Resources.c14;
            u15.pictureBox2.Image = Properties.Resources.c15;

            // ürün bilgileri

            u1.label1.Text = "Stradivarius";
            u1.label2.Text = "179.90 ₺";
            u2.label1.Text = "Lebina";
            u2.label2.Text = "69.90 ₺";
            u3.label1.Text = "Marica";
            u3.label2.Text = "186.16 ₺";
            u4.label1.Text = "Moda Azze";
            u4.label2.Text = "49.99";
            u5.label1.Text = "CityCenterFashion";
            u5.label2.Text = "84.90 ₺";
            u6.label1.Text = "Bags Mavi";
            u6.label2.Text = "59.99 ₺";
            u7.label1.Text = "Di Polo";
            u7.label2.Text = "94.99 ₺";
            u8.label1.Text = "Slater";
            u8.label2.Text = "83.56 ₺";
            u9.label1.Text = "Madamra";
            u9.label2.Text = "89.99 ₺";
            u10.label1.Text = "Matmazel";
            u10.label2.Text = "186.16 ₺";
            u11.label1.Text = "Top All";
            u11.label2.Text = "26.75 ₺";
            u12.label1.Text = "Bags Siyah";
            u12.label2.Text = "59.99 ₺";
            u13.label1.Text = "Shule Bags";
            u13.label2.Text = "74.50 ₺";
            u14.label1.Text = "Liberty";
            u14.label2.Text = "151.96 ₺";
            u15.label1.Text = "Nike BackKp";
            u15.label2.Text = "134.75 ₺";
        }

        private void u2_Load(object sender, EventArgs e)
        {

        }
    }
}
