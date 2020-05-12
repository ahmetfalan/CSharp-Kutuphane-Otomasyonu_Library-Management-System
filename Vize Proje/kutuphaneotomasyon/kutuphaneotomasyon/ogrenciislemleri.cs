using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class ogrenciislemleri : Form
    {
        public ogrenciislemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        DataSet ds;
        void temizle()
        {
            txtAdi.Text = "";
            txtBolum.Text = "";
            txtDiger.Text = "";
            txtNumara.Text = "";
            txtSoyad.Text = "";
            txtTel.Text = "";
            listView1.SelectedItems.Clear();
            checkCinsiyet.Checked = true;
            lblDiger.Visible = false;
            txtDiger.Visible = false;
        }
        void listele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb"); da = new OleDbDataAdapter("select * from ogrenci", baglanti);
            da = new OleDbDataAdapter("select * from ogrenci where kkuladi='" + giris.kuladi + "'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            dataGridView1.Columns["oid"].Visible = false;
            dataGridView1.Columns["overilis"].Visible = false;
            dataGridView1.Columns["osontarih"].Visible = false;
            dataGridView1.Columns["bid"].Visible = false;
            dataGridView1.Columns["kkuladi"].Visible = false;
            dataGridView1.Columns["oadi"].HeaderText = "Ad";
            dataGridView1.Columns["osoyadi"].HeaderText = "Soyad";
            dataGridView1.Columns["onumara"].HeaderText = "Numara";
            dataGridView1.Columns["obolum"].HeaderText = "Bölüm";
            dataGridView1.Columns["ocinsiyet"].HeaderText = "Cinsiyet";
            dataGridView1.Columns["otelefon"].HeaderText = "Telefon";
            dataGridView1.Columns["okaydedilmetarihi"].HeaderText = "Kaydedilme Tarihi";
            dataGridView1.Columns["oguncellenmetarihi"].HeaderText = "Son Güncelleme";
            dataGridView1.Columns["okitapkontrol"].HeaderText = "Kitap";
            dataGridView1.Columns["okitapdakika"].HeaderText = "Kalan Süre";
            dataGridView1.ClearSelection();
            baglanti.Close();
            temizle();
        }
        private void ogrenciislemleri_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Cinsiyet", 100);
            listView1.Items.Add("Kadın");
            listView1.Items.Add("Erkek");
            listView1.Items.Add("Diğer");
            listele();
            if (checkCinsiyet.Checked == true)
            {
                pnlCinsiyet.Enabled = false;
                cinsiyet = "Belirtilmedi";
                lblDiger.Visible = false;
                txtDiger.Visible = false;
            }
            else
            {
                pnlCinsiyet.Enabled = true;
            }
        }
        string cinsiyet;
        private void checkCinsiyet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCinsiyet.Checked == true)
            {
                pnlCinsiyet.Enabled = false;
                cinsiyet = "Belirtilmedi";
                listView1.SelectedItems.Clear();
            }
            else
            {
                pnlCinsiyet.Enabled = true;
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                String text = listView1.SelectedItems[0].Text;
                cinsiyet = text;
                if (cinsiyet == "Kadın")
                {
                    cinsiyet = "Kadın";
                }
                else if (cinsiyet == "Erkek")
                {
                    cinsiyet = "Erkek";
                }
                else if (cinsiyet == "Diğer")
                {
                    lblDiger.Visible = true;
                    txtDiger.Visible = true;
                    cinsiyet = txtDiger.Text;
                }
                else
                {
                    lblDiger.Visible = false;
                    txtDiger.Visible = false;
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
            baglanti.Open();
            komut = new OleDbCommand("select count(*) from ogrenci where onumara=" + txtNumara.Text + "", baglanti);
            if (txtAdi.Text == "" || txtSoyad.Text == "" || txtBolum.Text == "" || txtNumara.Text == "")
            {
                MessageBox.Show("Ad, soyad, bölüm ve numara boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (komut.ExecuteScalar().ToString() != "0")
                {
                    MessageBox.Show("Bu numarada bir öğrenci zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtTel.Text.Length == 14)
                    {
                        if (txtDiger.Text == "" && txtDiger.Visible == true)
                        {
                            cinsiyet = "Belirtilmedi";
                        }
                        komut = new OleDbCommand("insert into ogrenci (oadi, osoyadi, onumara, obolum, ocinsiyet, otelefon, okaydedilmetarihi, kkuladi, okitapkontrol) values ('" + txtAdi.Text + "', '" + txtSoyad.Text + "', " + txtNumara.Text + ", '" + txtBolum.Text + "', '" + cinsiyet + "', '" + txtTel.Text + "', '" + DateTime.Now + "', '" + giris.kuladi + "', 'Yok')", baglanti);
                        komut.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Telefon numarası 10 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            baglanti.Close();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdi.Text = dataGridView1.CurrentRow.Cells["oadi"].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells["osoyadi"].Value.ToString();
            txtNumara.Text = dataGridView1.CurrentRow.Cells["onumara"].Value.ToString();
            txtBolum.Text = dataGridView1.CurrentRow.Cells["obolum"].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells["otelefon"].Value.ToString();
            string cs = dataGridView1.CurrentRow.Cells["ocinsiyet"].Value.ToString();
            if (cs == "Belirtilmedi")
            {
                checkCinsiyet.Checked = true;
                pnlCinsiyet.Enabled = false;
                lblDiger.Visible = false;
                txtDiger.Visible = false;
            }
            else if (cs == "Kadın")
            {
                this.listView1.Items[0].Selected = true;
                this.listView1.Items[0].Focused = true;
                checkCinsiyet.Checked = false;
                pnlCinsiyet.Enabled = true;
                lblDiger.Visible = false;
                txtDiger.Visible = false;
                txtDiger.Text = "";
            }
            else if (cs == "Erkek")
            {
                this.listView1.Items[1].Selected = true;
                this.listView1.Items[1].Focused = true;
                checkCinsiyet.Checked = false;
                pnlCinsiyet.Enabled = true;
                lblDiger.Visible = false;
                txtDiger.Visible = false;
                txtDiger.Text = "";
            }
            else
            {
                this.listView1.Items[2].Selected = true;
                this.listView1.Items[2].Focused = true;
                checkCinsiyet.Checked = false;
                pnlCinsiyet.Enabled = true;
                lblDiger.Visible = true;
                txtDiger.Visible = true;
                txtDiger.Text = cs;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb"); komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from ogrenci where oid=" + dataGridView1.CurrentRow.Cells["oid"].Value + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
                baglanti.Open();
                komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "update ogrenci set oadi='" + txtAdi.Text + "', osoyadi='" + txtSoyad.Text + "', onumara='" + txtNumara.Text + "', obolum='" + txtBolum.Text + "', ocinsiyet='" + cinsiyet + "', otelefon='" + txtTel.Text + "', oguncellenmetarihi= '" + DateTime.Now + "' where oid=" + dataGridView1.CurrentRow.Cells["oid"].Value + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                listele();
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            anasayfa a = new anasayfa();
            a.Show();
            this.Hide();
        }

        private void txtDiger_TextChanged(object sender, EventArgs e)
        {
            cinsiyet = txtDiger.Text;
        }

        private void txtNumara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
