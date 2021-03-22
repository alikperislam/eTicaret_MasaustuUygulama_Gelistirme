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
    public partial class frmPet : Form
    {
        public frmPet()
        {
            InitializeComponent();
        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            u1.pictureBox2.Image = Properties.Resources.p1;
            u2.pictureBox2.Image = Properties.Resources.p2;
            u3.pictureBox2.Image = Properties.Resources.p3;
            u4.pictureBox2.Image = Properties.Resources.p4;
            u5.pictureBox2.Image = Properties.Resources.p5;
            u6.pictureBox2.Image = Properties.Resources.p6;
            u7.pictureBox2.Image = Properties.Resources.p7;
            u8.pictureBox2.Image = Properties.Resources.p8;
            u9.pictureBox2.Image = Properties.Resources.p9;
            u10.pictureBox2.Image = Properties.Resources.p10;
            u11.pictureBox2.Image = Properties.Resources.p11;
            u12.pictureBox2.Image = Properties.Resources.p12;
            u13.pictureBox2.Image = Properties.Resources.p13;
            u14.pictureBox2.Image = Properties.Resources.p14;
            u15.pictureBox2.Image = Properties.Resources.p15;

            // ürün bilgileri

            u1.label1.Text = "Jungle";
            u1.label2.Text = "118.00 ₺";
            u2.label1.Text = "Enjoy Tavuklu";
            u2.label2.Text = "131.60 ₺";
            u3.label1.Text = "Whiskas Yaş mama";
            u3.label2.Text = "134.99 ₺";
            u4.label1.Text = "Kedi Maltı";
            u4.label2.Text = "126.00 ₺";
            u5.label1.Text = "Proline Mama";
            u5.label2.Text = "178.00 ₺";
            u6.label1.Text = "Trendline Biftek";
            u6.label2.Text = "107.90 ₺";
            u7.label1.Text = "Kedi Çantası";
            u7.label2.Text = "79.90 ₺";
            u8.label1.Text = "Champions";
            u8.label2.Text = "84.99 ₺";
            u9.label1.Text = "Kedi Tuvaleti";
            u9.label2.Text = "113.00 ₺";
            u10.label1.Text = "Proline Kum";
            u10.label2.Text = "56.90 ₺";
            u11.label1.Text = "Proline Tavuklu";
            u11.label2.Text = "236.00 ₺";
            u12.label1.Text = "Pawmas ";
            u12.label2.Text = "84.90 ₺";
            u13.label1.Text ="Royal Canin";
            u13.label2.Text = "141.90 ₺";
            u14.label1.Text = "7'li Yaş Mama";
            u14.label2.Text = "49.90 ₺";
            u15.label1.Text = "Köpek Maması";
            u15.label2.Text = "96.80 ₺";

        }

        private void u2_Load(object sender, EventArgs e)
        {

        }

        private void u3_Load(object sender, EventArgs e)
        {

        }
    }
}
