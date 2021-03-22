namespace eCommerce
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anaPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKozmetik = new System.Windows.Forms.Button();
            this.btnPet = new System.Windows.Forms.Button();
            this.btnAksesuar = new System.Windows.Forms.Button();
            this.btnCanta = new System.Windows.Forms.Button();
            this.btnAyakkabi = new System.Windows.Forms.Button();
            this.btnSpor = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.anaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(65)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnKozmetik);
            this.panel1.Controls.Add(this.btnPet);
            this.panel1.Controls.Add(this.btnAksesuar);
            this.panel1.Controls.Add(this.btnCanta);
            this.panel1.Controls.Add(this.btnAyakkabi);
            this.panel1.Controls.Add(this.btnSpor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 610);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(65)))), ((int)(((byte)(165)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 37);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(184, 567);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 43);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tüm hakları saklıdır © 2021 Geliştirici Alikper İslam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // anaPanel
            // 
            this.anaPanel.Controls.Add(this.pictureBox4);
            this.anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaPanel.Location = new System.Drawing.Point(184, 37);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.Size = new System.Drawing.Size(725, 530);
            this.anaPanel.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(693, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(663, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnKozmetik
            // 
            this.btnKozmetik.FlatAppearance.BorderSize = 0;
            this.btnKozmetik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKozmetik.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKozmetik.ForeColor = System.Drawing.Color.White;
            this.btnKozmetik.Image = ((System.Drawing.Image)(resources.GetObject("btnKozmetik.Image")));
            this.btnKozmetik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKozmetik.Location = new System.Drawing.Point(4, 391);
            this.btnKozmetik.Margin = new System.Windows.Forms.Padding(4);
            this.btnKozmetik.Name = "btnKozmetik";
            this.btnKozmetik.Size = new System.Drawing.Size(173, 72);
            this.btnKozmetik.TabIndex = 5;
            this.btnKozmetik.Text = "Kozmetik";
            this.btnKozmetik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKozmetik.UseVisualStyleBackColor = true;
            this.btnKozmetik.Click += new System.EventHandler(this.btnKozmetik_Click);
            // 
            // btnPet
            // 
            this.btnPet.FlatAppearance.BorderSize = 0;
            this.btnPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPet.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPet.ForeColor = System.Drawing.Color.White;
            this.btnPet.Image = ((System.Drawing.Image)(resources.GetObject("btnPet.Image")));
            this.btnPet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPet.Location = new System.Drawing.Point(4, 465);
            this.btnPet.Margin = new System.Windows.Forms.Padding(4);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(173, 72);
            this.btnPet.TabIndex = 4;
            this.btnPet.Text = "Petshop";
            this.btnPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPet.UseVisualStyleBackColor = true;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnAksesuar
            // 
            this.btnAksesuar.FlatAppearance.BorderSize = 0;
            this.btnAksesuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAksesuar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAksesuar.ForeColor = System.Drawing.Color.White;
            this.btnAksesuar.Image = ((System.Drawing.Image)(resources.GetObject("btnAksesuar.Image")));
            this.btnAksesuar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAksesuar.Location = new System.Drawing.Point(4, 317);
            this.btnAksesuar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAksesuar.Name = "btnAksesuar";
            this.btnAksesuar.Size = new System.Drawing.Size(173, 72);
            this.btnAksesuar.TabIndex = 3;
            this.btnAksesuar.Text = "Aksesuar";
            this.btnAksesuar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAksesuar.UseVisualStyleBackColor = true;
            this.btnAksesuar.Click += new System.EventHandler(this.btnAksesuar_Click);
            // 
            // btnCanta
            // 
            this.btnCanta.FlatAppearance.BorderSize = 0;
            this.btnCanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanta.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCanta.ForeColor = System.Drawing.Color.White;
            this.btnCanta.Image = ((System.Drawing.Image)(resources.GetObject("btnCanta.Image")));
            this.btnCanta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCanta.Location = new System.Drawing.Point(4, 243);
            this.btnCanta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCanta.Name = "btnCanta";
            this.btnCanta.Size = new System.Drawing.Size(173, 72);
            this.btnCanta.TabIndex = 2;
            this.btnCanta.Text = "Çanta";
            this.btnCanta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanta.UseVisualStyleBackColor = true;
            this.btnCanta.Click += new System.EventHandler(this.btnCanta_Click);
            // 
            // btnAyakkabi
            // 
            this.btnAyakkabi.FlatAppearance.BorderSize = 0;
            this.btnAyakkabi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyakkabi.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyakkabi.ForeColor = System.Drawing.Color.White;
            this.btnAyakkabi.Image = ((System.Drawing.Image)(resources.GetObject("btnAyakkabi.Image")));
            this.btnAyakkabi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyakkabi.Location = new System.Drawing.Point(4, 169);
            this.btnAyakkabi.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyakkabi.Name = "btnAyakkabi";
            this.btnAyakkabi.Size = new System.Drawing.Size(173, 72);
            this.btnAyakkabi.TabIndex = 1;
            this.btnAyakkabi.Text = "Saat";
            this.btnAyakkabi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyakkabi.UseVisualStyleBackColor = true;
            this.btnAyakkabi.Click += new System.EventHandler(this.btnAyakkabi_Click);
            // 
            // btnSpor
            // 
            this.btnSpor.FlatAppearance.BorderSize = 0;
            this.btnSpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpor.ForeColor = System.Drawing.Color.White;
            this.btnSpor.Image = ((System.Drawing.Image)(resources.GetObject("btnSpor.Image")));
            this.btnSpor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpor.Location = new System.Drawing.Point(4, 95);
            this.btnSpor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpor.Name = "btnSpor";
            this.btnSpor.Size = new System.Drawing.Size(173, 72);
            this.btnSpor.TabIndex = 0;
            this.btnSpor.Text = "Spor Giyim";
            this.btnSpor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpor.UseVisualStyleBackColor = true;
            this.btnSpor.Click += new System.EventHandler(this.btnSpor_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(725, 530);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 610);
            this.Controls.Add(this.anaPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.anaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKozmetik;
        private System.Windows.Forms.Button btnPet;
        private System.Windows.Forms.Button btnAksesuar;
        private System.Windows.Forms.Button btnCanta;
        private System.Windows.Forms.Button btnAyakkabi;
        private System.Windows.Forms.Button btnSpor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel anaPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

