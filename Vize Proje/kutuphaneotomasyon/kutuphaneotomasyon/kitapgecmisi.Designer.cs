namespace kutuphaneotomasyon
{
    partial class kitapgecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapgecmisi));
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdKitapAdi = new System.Windows.Forms.RadioButton();
            this.rdNumaraGore = new System.Windows.Forms.RadioButton();
            this.rdİsmeGore = new System.Windows.Forms.RadioButton();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(54, 6);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(161, 20);
            this.txtArama.TabIndex = 0;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdKitapAdi);
            this.groupBox3.Controls.Add(this.rdNumaraGore);
            this.groupBox3.Controls.Add(this.rdİsmeGore);
            this.groupBox3.Location = new System.Drawing.Point(221, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 93);
            this.groupBox3.TabIndex = 1000;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Koşullu Arama";
            // 
            // rdKitapAdi
            // 
            this.rdKitapAdi.AutoSize = true;
            this.rdKitapAdi.Location = new System.Drawing.Point(6, 65);
            this.rdKitapAdi.Name = "rdKitapAdi";
            this.rdKitapAdi.Size = new System.Drawing.Size(124, 17);
            this.rdKitapAdi.TabIndex = 10;
            this.rdKitapAdi.TabStop = true;
            this.rdKitapAdi.Text = "Kitap Adına Göre Ara";
            this.rdKitapAdi.UseVisualStyleBackColor = true;
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
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToResizeColumns = false;
            this.datagrid.AllowUserToResizeRows = false;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(12, 105);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(521, 172);
            this.datagrid.TabIndex = 1001;
            this.datagrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagrid_DataBindingComplete);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(536, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(23, 289);
            this.toolStrip1.TabIndex = 1002;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(22, 20);
            this.toolStripButton1.Text = "Anasayfa";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // kitapgecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 289);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "kitapgecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Geçmişi";
            this.Load += new System.EventHandler(this.kitapgecmisi_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdKitapAdi;
        private System.Windows.Forms.RadioButton rdNumaraGore;
        private System.Windows.Forms.RadioButton rdİsmeGore;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}