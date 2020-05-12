namespace kutuphaneotomasyon
{
    partial class anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapGeçmişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grKitap = new System.Windows.Forms.GroupBox();
            this.checkEmanet = new System.Windows.Forms.CheckBox();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapDataGrid = new System.Windows.Forms.DataGridView();
            this.comboSirala = new System.Windows.Forms.ComboBox();
            this.grOgrenci = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTumunuGoster = new System.Windows.Forms.RadioButton();
            this.radioSuresiGecenler = new System.Windows.Forms.RadioButton();
            this.radioKitapAlanlar = new System.Windows.Forms.RadioButton();
            this.ogrenciDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdNumaraGore = new System.Windows.Forms.RadioButton();
            this.rdİsmeGore = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblEmanet = new System.Windows.Forms.Label();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataGrid)).BeginInit();
            this.grOgrenci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 100000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kitapİşlemleriToolStripMenuItem,
            this.öğrenciİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.kitapGeçmişiToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            this.kitapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİşlemleriToolStripMenuItem_Click);
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            this.öğrenciİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciİşlemleriToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kitapGeçmişiToolStripMenuItem
            // 
            this.kitapGeçmişiToolStripMenuItem.Name = "kitapGeçmişiToolStripMenuItem";
            this.kitapGeçmişiToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.kitapGeçmişiToolStripMenuItem.Text = "Kitap Geçmişi";
            this.kitapGeçmişiToolStripMenuItem.Click += new System.EventHandler(this.kitapGeçmişiToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(78, 19);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(152, 20);
            this.txtOgrenci.TabIndex = 124254;
            this.txtOgrenci.TextChanged += new System.EventHandler(this.txtOgrenci_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Kitap Ara:";
            // 
            // grKitap
            // 
            this.grKitap.Controls.Add(this.checkEmanet);
            this.grKitap.Controls.Add(this.txtKitapAra);
            this.grKitap.Controls.Add(this.label2);
            this.grKitap.Controls.Add(this.kitapDataGrid);
            this.grKitap.Controls.Add(this.comboSirala);
            this.grKitap.Controls.Add(this.label1);
            this.grKitap.Location = new System.Drawing.Point(12, 28);
            this.grKitap.Name = "grKitap";
            this.grKitap.Size = new System.Drawing.Size(531, 213);
            this.grKitap.TabIndex = 5588;
            this.grKitap.TabStop = false;
            this.grKitap.Text = "Kitap Listesi";
            // 
            // checkEmanet
            // 
            this.checkEmanet.AutoSize = true;
            this.checkEmanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkEmanet.Location = new System.Drawing.Point(16, 46);
            this.checkEmanet.Name = "checkEmanet";
            this.checkEmanet.Size = new System.Drawing.Size(122, 17);
            this.checkEmanet.TabIndex = 3;
            this.checkEmanet.Text = "Emanetleri de göster";
            this.checkEmanet.UseVisualStyleBackColor = true;
            this.checkEmanet.CheckedChanged += new System.EventHandler(this.checkEmanet_CheckedChanged);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(65, 20);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(160, 20);
            this.txtKitapAra.TabIndex = 0;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sırala:";
            // 
            // kitapDataGrid
            // 
            this.kitapDataGrid.AllowUserToAddRows = false;
            this.kitapDataGrid.AllowUserToDeleteRows = false;
            this.kitapDataGrid.AllowUserToResizeColumns = false;
            this.kitapDataGrid.AllowUserToResizeRows = false;
            this.kitapDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapDataGrid.Location = new System.Drawing.Point(9, 69);
            this.kitapDataGrid.MultiSelect = false;
            this.kitapDataGrid.Name = "kitapDataGrid";
            this.kitapDataGrid.ReadOnly = true;
            this.kitapDataGrid.RowHeadersVisible = false;
            this.kitapDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kitapDataGrid.Size = new System.Drawing.Size(513, 138);
            this.kitapDataGrid.TabIndex = 999;
            this.kitapDataGrid.TabStop = false;
            this.kitapDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitapDataGrid_CellClick);
            this.kitapDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.kitapDataGrid_DataBindingComplete);
            // 
            // comboSirala
            // 
            this.comboSirala.FormattingEnabled = true;
            this.comboSirala.Items.AddRange(new object[] {
            "İsme Göre (A-Z)",
            "İsme Göre (Z-A)",
            "Türe Göre (A-Z)",
            "Türe Göre (Z-A)"});
            this.comboSirala.Location = new System.Drawing.Point(293, 20);
            this.comboSirala.Name = "comboSirala";
            this.comboSirala.Size = new System.Drawing.Size(121, 21);
            this.comboSirala.TabIndex = 2;
            this.comboSirala.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grOgrenci
            // 
            this.grOgrenci.Controls.Add(this.groupBox1);
            this.grOgrenci.Controls.Add(this.ogrenciDataGrid);
            this.grOgrenci.Controls.Add(this.groupBox3);
            this.grOgrenci.Controls.Add(this.label3);
            this.grOgrenci.Controls.Add(this.txtOgrenci);
            this.grOgrenci.Location = new System.Drawing.Point(12, 295);
            this.grOgrenci.Name = "grOgrenci";
            this.grOgrenci.Size = new System.Drawing.Size(531, 236);
            this.grOgrenci.TabIndex = 0;
            this.grOgrenci.TabStop = false;
            this.grOgrenci.Text = "Öğrenci Listesi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTumunuGoster);
            this.groupBox1.Controls.Add(this.radioSuresiGecenler);
            this.groupBox1.Controls.Add(this.radioKitapAlanlar);
            this.groupBox1.Location = new System.Drawing.Point(380, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 88);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koşullu Gösterme";
            // 
            // radioTumunuGoster
            // 
            this.radioTumunuGoster.AutoSize = true;
            this.radioTumunuGoster.Checked = true;
            this.radioTumunuGoster.Location = new System.Drawing.Point(6, 15);
            this.radioTumunuGoster.Name = "radioTumunuGoster";
            this.radioTumunuGoster.Size = new System.Drawing.Size(96, 17);
            this.radioTumunuGoster.TabIndex = 10;
            this.radioTumunuGoster.TabStop = true;
            this.radioTumunuGoster.Text = "Tümünü göster";
            this.radioTumunuGoster.UseVisualStyleBackColor = true;
            this.radioTumunuGoster.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioSuresiGecenler
            // 
            this.radioSuresiGecenler.AutoSize = true;
            this.radioSuresiGecenler.Location = new System.Drawing.Point(6, 61);
            this.radioSuresiGecenler.Name = "radioSuresiGecenler";
            this.radioSuresiGecenler.Size = new System.Drawing.Size(132, 17);
            this.radioSuresiGecenler.TabIndex = 9;
            this.radioSuresiGecenler.Text = "Süresi geçenleri göster";
            this.radioSuresiGecenler.UseVisualStyleBackColor = true;
            this.radioSuresiGecenler.CheckedChanged += new System.EventHandler(this.radioSuresiGecenler_CheckedChanged);
            // 
            // radioKitapAlanlar
            // 
            this.radioKitapAlanlar.AutoSize = true;
            this.radioKitapAlanlar.Location = new System.Drawing.Point(6, 38);
            this.radioKitapAlanlar.Name = "radioKitapAlanlar";
            this.radioKitapAlanlar.Size = new System.Drawing.Size(117, 17);
            this.radioKitapAlanlar.TabIndex = 8;
            this.radioKitapAlanlar.Text = "Kitap alanları göster";
            this.radioKitapAlanlar.UseVisualStyleBackColor = true;
            this.radioKitapAlanlar.CheckedChanged += new System.EventHandler(this.radioKitapAlanlar_CheckedChanged);
            // 
            // ogrenciDataGrid
            // 
            this.ogrenciDataGrid.AllowUserToAddRows = false;
            this.ogrenciDataGrid.AllowUserToDeleteRows = false;
            this.ogrenciDataGrid.AllowUserToResizeColumns = false;
            this.ogrenciDataGrid.AllowUserToResizeRows = false;
            this.ogrenciDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrenciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciDataGrid.Location = new System.Drawing.Point(9, 94);
            this.ogrenciDataGrid.MultiSelect = false;
            this.ogrenciDataGrid.Name = "ogrenciDataGrid";
            this.ogrenciDataGrid.ReadOnly = true;
            this.ogrenciDataGrid.RowHeadersVisible = false;
            this.ogrenciDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ogrenciDataGrid.Size = new System.Drawing.Size(513, 135);
            this.ogrenciDataGrid.TabIndex = 999;
            this.ogrenciDataGrid.TabStop = false;
            this.ogrenciDataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ogrenciDataGrid_DataBindingComplete);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdNumaraGore);
            this.groupBox3.Controls.Add(this.rdİsmeGore);
            this.groupBox3.Location = new System.Drawing.Point(236, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 69);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Koşullu Arama";
            // 
            // rdNumaraGore
            // 
            this.rdNumaraGore.AutoSize = true;
            this.rdNumaraGore.Location = new System.Drawing.Point(6, 42);
            this.rdNumaraGore.Name = "rdNumaraGore";
            this.rdNumaraGore.Size = new System.Drawing.Size(118, 17);
            this.rdNumaraGore.TabIndex = 9;
            this.rdNumaraGore.TabStop = true;
            this.rdNumaraGore.Text = "Numaraya Göre Ara";
            this.rdNumaraGore.UseVisualStyleBackColor = true;
            // 
            // rdİsmeGore
            // 
            this.rdİsmeGore.AutoSize = true;
            this.rdİsmeGore.Checked = true;
            this.rdİsmeGore.Location = new System.Drawing.Point(6, 19);
            this.rdİsmeGore.Name = "rdİsmeGore";
            this.rdİsmeGore.Size = new System.Drawing.Size(92, 17);
            this.rdİsmeGore.TabIndex = 8;
            this.rdİsmeGore.TabStop = true;
            this.rdİsmeGore.Text = "İsme Göre Ara";
            this.rdİsmeGore.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Öğrenci Ara:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(21, 247);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(513, 44);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapVer.Location = new System.Drawing.Point(329, 538);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(97, 36);
            this.btnKitapVer.TabIndex = 11;
            this.btnKitapVer.Text = "Kitabı Ver";
            this.btnKitapVer.UseVisualStyleBackColor = true;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(141, 537);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(182, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblEmanet
            // 
            this.lblEmanet.AutoSize = true;
            this.lblEmanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmanet.Location = new System.Drawing.Point(18, 548);
            this.lblEmanet.Name = "lblEmanet";
            this.lblEmanet.Size = new System.Drawing.Size(122, 17);
            this.lblEmanet.TabIndex = 13;
            this.lblEmanet.Text = "Emanet Süresi (1)";
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAl.Location = new System.Drawing.Point(437, 538);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(97, 36);
            this.btnKitapAl.TabIndex = 12;
            this.btnKitapAl.Text = "Kitabı Al";
            this.btnKitapAl.UseVisualStyleBackColor = true;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 586);
            this.Controls.Add(this.btnKitapAl);
            this.Controls.Add(this.lblEmanet);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnKitapVer);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.grOgrenci);
            this.Controls.Add(this.grKitap);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grKitap.ResumeLayout(false);
            this.grKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDataGrid)).EndInit();
            this.grOgrenci.ResumeLayout(false);
            this.grOgrenci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.TextBox txtOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grKitap;
        private System.Windows.Forms.GroupBox grOgrenci;
        private System.Windows.Forms.ComboBox comboSirala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView kitapDataGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdNumaraGore;
        private System.Windows.Forms.RadioButton rdİsmeGore;
        private System.Windows.Forms.DataGridView ogrenciDataGrid;
        public System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblEmanet;
        private System.Windows.Forms.CheckBox checkEmanet;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.ToolStripMenuItem kitapGeçmişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSuresiGecenler;
        private System.Windows.Forms.RadioButton radioKitapAlanlar;
        private System.Windows.Forms.RadioButton radioTumunuGoster;
    }
}