using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class root : Form
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        DataSet ds;
        void temizle()
        {
            txtKuladi.Text = "";
            txtOkul.Text = "";
            txtSifre.Text = "";
            txtYerleske.Text = "";
        }

        void listele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=database.accdb");
            da = new OleDbDataAdapter("select * from kullanici", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kullanici");
            dataGridView1.DataSource = ds.Tables["kullanici"];
            dataGridView1.ClearSelection();
            dataGridView1.Columns["kid"].Visible = false;
            dataGridView1.Columns["kkuladi"].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns["ksifre"].HeaderText = "Şifre";
            dataGridView1.Columns["kokul"].HeaderText = "Okul";
            dataGridView1.Columns["kyerleske"].HeaderText = "Yerleşke";
            dataGridView1.Columns["kkaydedilmetarihi"].HeaderText = "Kaydedilme Tarihi";
            dataGridView1.Columns["kguncellenmetarihi"].HeaderText = "Güncellenme Tarihi";
            dataGridView1.Columns["kkuladi"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["ksifre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["kokul"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["kyerleske"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["kkaydedilmetarihi"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["kguncellenmetarihi"].SortMode = DataGridViewColumnSortMode.NotSortable;
            baglanti.Close();
            temizle();
        }
        private void root_Load(object sender, EventArgs e)
        {
            listele();
        }
        public root()
        {
            InitializeComponent();
        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            string kuladi = giris.kuladi;
            string sifre = giris.sifre;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            komut = new OleDbCommand("select count(*) from kullanici where kkuladi='" + txtKuladi.Text + "'", baglanti);
            baglanti.Open();
            if (txtKuladi.Text == kuladi.ToString() && txtSifre.Text == sifre.ToString())
            {
                MessageBox.Show("Root kullanıcı adı ve şifresi kullanılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtKuladi.Text == "" || txtOkul.Text == "" || txtSifre.Text == "" || txtYerleske.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı, şifre, okul ve yerleşke boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (komut.ExecuteScalar().ToString() != "0")
                    {
                        MessageBox.Show("Böyle bir kullanıcı adı zaten bulunmakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        komut = new OleDbCommand("insert into kullanici (kkuladi, ksifre, kokul, kyerleske, kkaydedilmetarihi) values ('" + txtKuladi.Text + "', '" + txtSifre.Text + "', '" + txtOkul.Text + "', '" + txtYerleske.Text + "', '" + DateTime.Now + "')", baglanti);
                        komut.ExecuteNonQuery();
                    }
                }
            }
            baglanti.Close();
            listele();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKuladi.Text = dataGridView1.CurrentRow.Cells["kkuladi"].Value.ToString();
                txtSifre.Text = dataGridView1.CurrentRow.Cells["ksifre"].Value.ToString();
                txtOkul.Text = dataGridView1.CurrentRow.Cells["kokul"].Value.ToString();
                txtYerleske.Text = dataGridView1.CurrentRow.Cells["kyerleske"].Value.ToString();
            }
            catch
            {

            }
        }

        string temp;
        private void txtKuladi_TextChanged(object sender, EventArgs e)
        {
            if (temp == txtKuladi.Text)
                txtKuladi.Modified = false;
            else
                txtKuladi.Modified = true;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                temp = txtKuladi.Text;
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
                komut = new OleDbCommand("select count(*) from kullanici where kkuladi='" + txtKuladi.Text + "'", baglanti);
                baglanti.Open();
                if (txtKuladi.Modified)
                {
                    if (txtKuladi.Text == "" || txtOkul.Text == "" || txtSifre.Text == "" || txtYerleske.Text == "")
                    {
                        MessageBox.Show("Kullanıcı adı, şifre, okul ve yerleşke boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (komut.ExecuteScalar().ToString() != "0")
                        {
                            MessageBox.Show("Böyle bir kullanıcı adı zaten bulunmakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            komut.Connection = baglanti;
                            komut.CommandText = "update kullanici set kkuladi='" + txtKuladi.Text + "' where kid=" + dataGridView1.CurrentRow.Cells[0].Value + "";
                            komut.ExecuteNonQuery();
                        }
                    }
                }
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update kullanici set ksifre='" + txtSifre.Text + "', kokul='" + txtOkul.Text + "', kyerleske='" + txtYerleske.Text + "', kguncellenmetarihi='" + DateTime.Now + "' where kid=" + dataGridView1.CurrentRow.Cells["kid"].Value + "";
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kullanici where kid=" + dataGridView1.CurrentRow.Cells["kid"].Value + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            giris g = new giris();
            g.Show();
            this.Hide();
        }
    }
}
