namespace kutuphaneotomasyon
{
    partial class giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.pRoot = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRHata = new System.Windows.Forms.Label();
            this.txtRSifre = new System.Windows.Forms.TextBox();
            this.txtRKadi = new System.Windows.Forms.TextBox();
            this.btnKayitRoot = new System.Windows.Forms.Button();
            this.pGiris = new System.Windows.Forms.Panel();
            this.checkHatirla = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGSifre = new System.Windows.Forms.TextBox();
            this.txtGKuladi = new System.Windows.Forms.TextBox();
            this.pRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pRoot
            // 
            this.pRoot.Controls.Add(this.pictureBox1);
            this.pRoot.Controls.Add(this.label2);
            this.pRoot.Controls.Add(this.label1);
            this.pRoot.Controls.Add(this.lblRHata);
            this.pRoot.Controls.Add(this.txtRSifre);
            this.pRoot.Controls.Add(this.txtRKadi);
            this.pRoot.Controls.Add(this.btnKayitRoot);
            this.pRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRoot.Location = new System.Drawing.Point(0, 0);
            this.pRoot.Name = "pRoot";
            this.pRoot.Size = new System.Drawing.Size(243, 199);
            this.pRoot.TabIndex = 1;
            this.pRoot.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // lblRHata
            // 
            this.lblRHata.AutoSize = true;
            this.lblRHata.Location = new System.Drawing.Point(50, 145);
            this.lblRHata.Name = "lblRHata";
            this.lblRHata.Size = new System.Drawing.Size(0, 13);
            this.lblRHata.TabIndex = 3;
            // 
            // txtRSifre
            // 
            this.txtRSifre.Location = new System.Drawing.Point(84, 92);
            this.txtRSifre.Name = "txtRSifre";
            this.txtRSifre.PasswordChar = '*';
            this.txtRSifre.Size = new System.Drawing.Size(100, 20);
            this.txtRSifre.TabIndex = 1;
            this.txtRSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRSifre_KeyPress);
            // 
            // txtRKadi
            // 
            this.txtRKadi.Location = new System.Drawing.Point(84, 66);
            this.txtRKadi.Name = "txtRKadi";
            this.txtRKadi.Size = new System.Drawing.Size(100, 20);
            this.txtRKadi.TabIndex = 0;
            this.txtRKadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRKadi_KeyPress);
            // 
            // btnKayitRoot
            // 
            this.btnKayitRoot.Location = new System.Drawing.Point(83, 118);
            this.btnKayitRoot.Name = "btnKayitRoot";
            this.btnKayitRoot.Size = new System.Drawing.Size(100, 28);
            this.btnKayitRoot.TabIndex = 2;
            this.btnKayitRoot.Text = "Kayıt";
            this.btnKayitRoot.UseVisualStyleBackColor = true;
            this.btnKayitRoot.Click += new System.EventHandler(this.btnKayitRoot_Click);
            // 
            // pGiris
            // 
            this.pGiris.Controls.Add(this.checkHatirla);
            this.pGiris.Controls.Add(this.pictureBox2);
            this.pGiris.Controls.Add(this.label3);
            this.pGiris.Controls.Add(this.btnGiris);
            this.pGiris.Controls.Add(this.label4);
            this.pGiris.Controls.Add(this.txtGSifre);
            this.pGiris.Controls.Add(this.txtGKuladi);
            this.pGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGiris.Location = new System.Drawing.Point(0, 0);
            this.pGiris.Name = "pGiris";
            this.pGiris.Size = new System.Drawing.Size(243, 199);
            this.pGiris.TabIndex = 0;
            this.pGiris.Visible = false;
            // 
            // checkHatirla
            // 
            this.checkHatirla.AutoSize = true;
            this.checkHatirla.Checked = true;
            this.checkHatirla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHatirla.Location = new System.Drawing.Point(95, 114);
            this.checkHatirla.Name = "checkHatirla";
            this.checkHatirla.Size = new System.Drawing.Size(80, 17);
            this.checkHatirla.TabIndex = 9;
            this.checkHatirla.Text = "Beni Hatırla";
            this.checkHatirla.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(176, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(95, 137);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(99, 28);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // txtGSifre
            // 
            this.txtGSifre.Location = new System.Drawing.Point(95, 88);
            this.txtGSifre.Name = "txtGSifre";
            this.txtGSifre.PasswordChar = '*';
            this.txtGSifre.Size = new System.Drawing.Size(100, 20);
            this.txtGSifre.TabIndex = 1;
            this.txtGSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGSifre_KeyPress);
            // 
            // txtGKuladi
            // 
            this.txtGKuladi.Location = new System.Drawing.Point(95, 62);
            this.txtGKuladi.Name = "txtGKuladi";
            this.txtGKuladi.Size = new System.Drawing.Size(100, 20);
            this.txtGKuladi.TabIndex = 0;
            this.txtGKuladi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGKuladi_KeyPress);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 199);
            this.Controls.Add(this.pGiris);
            this.Controls.Add(this.pRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            this.pRoot.ResumeLayout(false);
            this.pRoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pGiris.ResumeLayout(false);
            this.pGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pRoot;
        private System.Windows.Forms.Panel pGiris;
        private System.Windows.Forms.TextBox txtRSifre;
        private System.Windows.Forms.TextBox txtRKadi;
        private System.Windows.Forms.Button btnKayitRoot;
        private System.Windows.Forms.Label lblRHata;
        private System.Windows.Forms.TextBox txtGSifre;
        private System.Windows.Forms.TextBox txtGKuladi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkHatirla;
    }
}