using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class kitapgecmisi : Form
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        public kitapgecmisi()
        {
            InitializeComponent();
        }
        void listele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            DataTable dt = new DataTable();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("select * from kitapgecmisi", baglanti);
            da.Fill(dt);
            datagrid.DataSource = dt;
            datagrid.ClearSelection();
            datagrid.Columns["oadi"].HeaderText = "Öğrenci Adı";
            datagrid.Columns["osoyadi"].HeaderText = "Öğrenci Soyadı";
            datagrid.Columns["onumara"].HeaderText = "Öğrenci Numara";
            datagrid.Columns["badi"].HeaderText = "Kitap Adı";
            datagrid.Columns["kgid"].Visible = false;
            datagrid.Columns["kkuladi"].Visible = false;
        }

        private void kitapgecmisi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            baglanti.Open();
            if (rdİsmeGore.Checked)
            {
                da = new OleDbDataAdapter("select * from kitapgecmisi where oadi like '" + txtArama.Text + "%' and kkuladi='" + giris.kuladi + "'", baglanti);
                da.Fill(dt);
                datagrid.DataSource = dt;
            }
            else if (rdNumaraGore.Checked)
            {
                da = new OleDbDataAdapter("select * from kitapgecmisi where onumara like '" + txtArama.Text + "%' and kkuladi='" + giris.kuladi + "'", baglanti);
                da.Fill(dt);
                datagrid.DataSource = dt;
            }
            else if (rdKitapAdi.Checked)
            {
                da = new OleDbDataAdapter("select * from kitapgecmisi where badi like '" + txtArama.Text + "%' and kkuladi='" + giris.kuladi + "'", baglanti);
                da.Fill(dt);
                datagrid.DataSource = dt;
            }
            baglanti.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
            this.Hide();
        }

        private void datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagrid.ClearSelection();
        }
    }
}
