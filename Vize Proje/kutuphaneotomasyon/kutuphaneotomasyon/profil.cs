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
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        private void profil_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb"); da = new OleDbDataAdapter("select * from ogrenci", baglanti);
            baglanti.Open();
            komut = new OleDbCommand();
            komut.CommandText = "select * from kullanici where kkuladi='" + giris.kuladi + "'";
            komut.Connection = baglanti;
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr["kkuladi"].ToString();
                textBox2.Text = dr["ksifre"].ToString();
                textBox3.Text = dr["kokul"].ToString();
                textBox4.Text = dr["kyerleske"].ToString();
                textBox5.Text = dr["kkaydedilmetarihi"].ToString();
            }
            dr.Close();
            dr.Dispose();
            baglanti.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
            this.Hide();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
