using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class kitapislemleri : Form
    {
        public kitapislemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        DataSet ds;
        void temizle()
        {
            txtKadi.Text = "";
            txtKsayfa.Text = "";
            txtKyazar.Text = "";
            lstTur.SelectedItems.Clear();
            dosyakonumu = "";
            totalyol = "";
            openFileDialog1.Reset();
            dataGridView1.ClearSelection();
            checkBox1.Checked = false;
        }
        void listele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            da = new OleDbDataAdapter("select * from kitaplar where kkuladi='" + giris.kuladi + "'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kitaplar");
            dataGridView1.DataSource = ds.Tables["kitaplar"];
            dataGridView1.Columns["bid"].Visible = false;
            dataGridView1.Columns["kkuladi"].Visible = false;
            dataGridView1.Columns["badi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["byazar"].HeaderText = "Yazar";
            dataGridView1.Columns["bsayfasayisi"].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns["bturu"].HeaderText = "Kitap Türü";
            dataGridView1.Columns["bdosyakonumu"].HeaderText = "Dosya Konumu";
            dataGridView1.Columns["bdurum"].HeaderText = "Durum";

            dataGridView1.Columns["badi"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["byazar"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["bsayfasayisi"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["bturu"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["bdosyakonumu"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["bdurum"].SortMode = DataGridViewColumnSortMode.NotSortable;
            baglanti.Close();
            temizle();
        }

        private void kitapislemleri_Load(object sender, EventArgs e)
        {
            listele();
        }
        public static string dosyakonumu = "";
        string totalyol = "";
        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Sesli kitabı seçiniz",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mp3",
                Filter = "mp3 dosyaları (*.mp3,*.m4a)|*.mp3;*.m4a;",
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Sesli kitabı seçiniz.";
                dosyakonumu = openFileDialog1.FileName;
                string kullaniciYolu = Directory.GetCurrentDirectory();
                string hedef = kullaniciYolu + @"\seslikitap";
                totalyol = hedef + "\\" + Path.GetFileName(dosyakonumu);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "" || txtKsayfa.Text == "" || txtKyazar.Text == "" || lstTur.GetItemText(lstTur.SelectedItem) == "")
            {
                MessageBox.Show("Kitap adı, sayfa sayısı, kitap türü ve yazar ismi boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
                baglanti.Open();
                if (!File.Exists(totalyol))
                {
                    komut = new OleDbCommand("insert into kitaplar (badi, byazar, bsayfasayisi, bturu, bdosyakonumu, bdurum, kkuladi) values ('" + txtKadi.Text + "', '" + txtKyazar.Text + "', '" + txtKsayfa.Text + "', '" + lstTur.SelectedItem.ToString() + "', '" + totalyol + "', 'Mevcut', '" + giris.kuladi + "')", baglanti);
                    komut.ExecuteNonQuery();
                    if (dosyakonumu != "")
                    {
                        File.Copy(dosyakonumu, totalyol);
                        progressform p = new progressform();
                        p.Focus();
                        p.Show();
                        listele();
                    }
                }
                else
                {
                    MessageBox.Show("Bu sesli kitap zaten bulunmakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
        }
        string dskonum = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKadi.Text = dataGridView1.CurrentRow.Cells["badi"].Value.ToString();
            txtKyazar.Text = dataGridView1.CurrentRow.Cells["byazar"].Value.ToString();
            txtKsayfa.Text = dataGridView1.CurrentRow.Cells["bsayfasayisi"].Value.ToString();
            lstTur.SelectedItem = dataGridView1.CurrentRow.Cells["bturu"].Value.ToString();
            dskonum = dataGridView1.CurrentRow.Cells["bdosyakonumu"].Value.ToString();
            if (dskonum == "")
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "" || txtKsayfa.Text == "" || txtKyazar.Text == "" || lstTur.GetItemText(lstTur.SelectedItem) == "")
            {
                MessageBox.Show("Kitap adı, sayfa sayısı, kitap türü ve yazar ismi boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
                baglanti.Open();
                komut = new OleDbCommand();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (!File.Exists(totalyol))
                    {
                        komut.Connection = baglanti;
                        komut.CommandText = "update kitaplar set bdosyakonumu='" + totalyol + "', badi='" + txtKadi.Text + "', byazar='" + txtKyazar.Text + "', bsayfasayisi='" + txtKsayfa.Text + "', bturu='" + lstTur.SelectedItem.ToString() + "' where bid=" + dataGridView1.CurrentRow.Cells["bid"].Value + "";
                        komut.ExecuteNonQuery();
                        if (totalyol != "")
                        {
                            File.Delete(totalyol);
                            File.Copy(dosyakonumu, totalyol);
                            progressform p = new progressform();
                            p.Focus();
                            p.Show();
                            temizle();
                        }
                        baglanti.Close();
                        listele();
                    }
                    else
                    {
                        MessageBox.Show("Bu sesli kitap zaten bulunmakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden seçim yapın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            komut = new OleDbCommand();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from kitaplar where bid=" + dataGridView1.CurrentRow.Cells["bid"].Value + "";
                if (File.Exists(dskonum))
                {
                    File.Delete(dskonum);
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            else
            {
                MessageBox.Show("Listeden seçim yapın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
            this.Hide();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txtKsayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                totalyol = "";
                dosyakonumu = "";
                button1.Visible = false;
            }
        }

    }
}
