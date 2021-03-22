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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void panelGetir(Form frm)
        {
            anaPanel.Controls.Clear();
            frm.MdiParent = this;
            anaPanel.Controls.Add(frm);
            frm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpor_Click(object sender, EventArgs e)
        {
            frmSpor fr = new frmSpor();
            panelGetir(fr);
        }

        private void btnAyakkabi_Click(object sender, EventArgs e)
        {
            frmAyakkabı fr1 = new frmAyakkabı();
            panelGetir(fr1);
        }

        private void btnCanta_Click(object sender, EventArgs e)
        {
            frmCanta fr2 = new frmCanta();
            panelGetir(fr2);
        }

        private void btnAksesuar_Click(object sender, EventArgs e)
        {
            frmAksesuar fr3 = new frmAksesuar();
            panelGetir(fr3);
        }

        private void btnKozmetik_Click(object sender, EventArgs e)
        {
            frmKozmetik fr4 = new frmKozmetik();
            panelGetir(fr4);
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            frmPet fr5 = new frmPet();
            panelGetir(fr5);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
