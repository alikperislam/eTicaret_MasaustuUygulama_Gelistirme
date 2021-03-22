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
    public partial class frmAksesuar : Form
    {
        public frmAksesuar()
        {
            InitializeComponent();
        }

        private void frmAksesuar_Load(object sender, EventArgs e)
        {
            u1.pictureBox2.Image = Properties.Resources.k1;
            u2.pictureBox2.Image = Properties.Resources.k2;
            u3.pictureBox2.Image = Properties.Resources.k3;
            u4.pictureBox2.Image = Properties.Resources.k4;
            u5.pictureBox2.Image = Properties.Resources.k5;
            u6.pictureBox2.Image = Properties.Resources.k6;
            u7.pictureBox2.Image = Properties.Resources.k7;
            u8.pictureBox2.Image = Properties.Resources.k8;
            u9.pictureBox2.Image = Properties.Resources.k9;
            u10.pictureBox2.Image = Properties.Resources.k10;
            u11.pictureBox2.Image = Properties.Resources.k11;
            u12.pictureBox2.Image = Properties.Resources.k12;
            u13.pictureBox2.Image = Properties.Resources.k13;
            u14.pictureBox2.Image = Properties.Resources.k14;
            u15.pictureBox2.Image = Properties.Resources.k15;

            // ürün bilgileri

            u1.label1.Text = "Siyah Kanat";
            u1.label2.Text = "39.90 ₺";
            u2.label1.Text = "Zincir Gold";
            u2.label2.Text = "77.30 ₺";
            u3.label1.Text = "Pırlanta";
            u3.label2.Text = "30.10 ₺";
            u4.label1.Text = "Melek";
            u4.label2.Text = "39.90 ₺";
            u5.label1.Text = "yonca";
            u5.label2.Text = "46.80 ₺";
            u6.label1.Text = "Sonsuzluk";
            u6.label2.Text = "49.90 ₺";
            u7.label1.Text = "Kar";
            u7.label2.Text = "39.90 ₺";
            u8.label1.Text = "Nazar";
            u8.label2.Text = "23.30 ₺";
            u9.label1.Text = "Baget Taşlı";
            u9.label2.Text = "40.26 ₺";
            u10.label1.Text = "Turkuaz";
            u10.label2.Text = "31.29 ₺";
            u11.label1.Text = "Tektaş";
            u11.label2.Text = "901.82 ₺";
            u12.label1.Text = "Kristal";
            u12.label2.Text = "47.39 ₺";
            u13.label1.Text = "Baloncuklu";
            u13.label2.Text = "29.90 ₺";
            u14.label1.Text = "Altın kaplama";
            u14.label2.Text = "117.25 ₺";
            u15.label1.Text = "Zirkon";
            u15.label2.Text = "24.90 ₺";

        }

        private void u3_Load(object sender, EventArgs e)
        {

        }

        private void u2_Load(object sender, EventArgs e)
        {

        }
    }
}
