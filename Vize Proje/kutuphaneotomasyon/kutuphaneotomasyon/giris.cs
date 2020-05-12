using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class giris : Form
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        public giris()
        {
            InitializeComponent();

        }
        public static string kuladi = "";
        public static string sifre = "";
        private void giris_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.kuladi != string.Empty)
            {
                txtGKuladi.Text = Properties.Settings.Default.kuladi;
                txtGSifre.Text = Properties.Settings.Default.sifre;
            }
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            baglanti.Open();
            komut = new OleDbCommand("select count(*) from root", baglanti);
            if (komut.ExecuteScalar().ToString() == "0")
            {
                pRoot.Visible = true;
                pGiris.Visible = false;
                this.Text = "Root Oluşturma Ekranı";
            }
            else
            {
                pGiris.Visible = true;
                pRoot.Visible = false;
                this.Text = "Giriş";
            }
            baglanti.Close();
        }
        private void btnKayitRoot_Click(object sender, EventArgs e)
        {
            if (txtRKadi.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtRSifre.Text == "")
                {
                    MessageBox.Show("Şifre boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    baglanti.Open();
                    komut = new OleDbCommand("insert into root (rkuladi, rkulsifre) values ('" + txtRKadi.Text + "', '" + txtRSifre.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    pRoot.Visible = false;
                    pGiris.Visible = true;
                    this.Text = "Giriş";
                }
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb"); baglanti.Open();
            komut = new OleDbCommand("select count(*) from root where rkuladi='" + txtGKuladi.Text + "' and rkulsifre='" + txtGSifre.Text + "'", baglanti);
            if (komut.ExecuteScalar().ToString() != "0")
            {
                kuladi = txtGKuladi.Text;
                sifre = txtGSifre.Text;
                this.Hide();
                root root = new root();
                root.Show();
            }
            else
            {
                komut = new OleDbCommand("select count(*) from kullanici where kkuladi='" + txtGKuladi.Text + "' and ksifre='" + txtGSifre.Text + "'", baglanti);
                if (komut.ExecuteScalar().ToString() != "0")
                {
                    kuladi = txtGKuladi.Text;
                    sifre = txtGSifre.Text;
                    this.Hide();
                    anasayfa anasayfa = new anasayfa();
                    anasayfa.Show();
                }
                else
                {
                    MessageBox.Show("Giriş bilgileriniz hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (checkHatirla.Checked)
            {
                kutuphaneotomasyon.Properties.Settings.Default.kuladi = txtGKuladi.Text;
                kutuphaneotomasyon.Properties.Settings.Default.sifre = txtGSifre.Text;
                kutuphaneotomasyon.Properties.Settings.Default.Save();
            }
            else if (!checkHatirla.Checked)
            {
                kutuphaneotomasyon.Properties.Settings.Default.kuladi = "";
                kutuphaneotomasyon.Properties.Settings.Default.sifre = "";
                kutuphaneotomasyon.Properties.Settings.Default.Save();
            }
            baglanti.Close();
        }
        private void txtGKuladi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtGSifre.Focus();
            }
        }
        private void txtGSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGiris.PerformClick();
            }
        }
        private void txtRKadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtRSifre.Focus();
            }
        }

        private void txtRSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnKayitRoot.PerformClick();
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtRSifre.PasswordChar = '\0';
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtRSifre.PasswordChar = '*';
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtGSifre.PasswordChar = '\0';
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtGSifre.PasswordChar = '*';
        }
    }
}
