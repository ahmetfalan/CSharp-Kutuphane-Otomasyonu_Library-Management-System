using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
	public partial class anasayfa : Form
	{
		public anasayfa()
		{
			InitializeComponent();
		}
		OleDbConnection baglanti;
		OleDbCommand komut;
		OleDbDataAdapter da1;
		OleDbDataAdapter da2;
		OleDbDataAdapter da3;
		OleDbDataAdapter da4;
		OleDbDataAdapter da5;
		DataSet ds;
		void listele()
		{
			baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
			da1 = new OleDbDataAdapter("select * from kitaplar where bdurum='Mevcut' and kkuladi='" + giris.kuladi + "'", baglanti);
			da2 = new OleDbDataAdapter("select * from kitaplar where kkuladi='" + giris.kuladi + "'", baglanti);
			da3 = new OleDbDataAdapter("select * from ogrenci where kkuladi='" + giris.kuladi + "'", baglanti);
			da4 = new OleDbDataAdapter("select * from ogrenci where okitapkontrol='Var' and kkuladi='" + giris.kuladi + "'", baglanti);
			da5 = new OleDbDataAdapter("select * from ogrenci where okitapkontrol='Var' and okitapdakika <= 0 and kkuladi='" + giris.kuladi + "'", baglanti);
			ds = new DataSet();
			baglanti.Open();
			if (!checkEmanet.Checked)
			{
				da1.Fill(ds, "kitaplar");
				kitapDataGrid.DataSource = ds.Tables["kitaplar"];
			}
			else if (checkEmanet.Checked)
			{
				da2.Fill(ds, "kitaplar");
				kitapDataGrid.DataSource = ds.Tables["kitaplar"];
			}
			kitapDataGrid.Columns["bid"].Visible = false;
			kitapDataGrid.Columns["kkuladi"].Visible = false;
			kitapDataGrid.Columns["badi"].HeaderText = "Kitap Adı";
			kitapDataGrid.Columns["byazar"].HeaderText = "Yazar";
			kitapDataGrid.Columns["bsayfasayisi"].HeaderText = "Sayfa Sayısı";
			kitapDataGrid.Columns["bturu"].HeaderText = "Türü";
			kitapDataGrid.Columns["bdurum"].HeaderText = "Durumu";
			kitapDataGrid.Columns["bdosyakonumu"].HeaderText = "Dosya Konumu";
			kitapDataGrid.Columns["badi"].SortMode = DataGridViewColumnSortMode.NotSortable;
			kitapDataGrid.Columns["byazar"].SortMode = DataGridViewColumnSortMode.NotSortable;
			kitapDataGrid.Columns["bsayfasayisi"].SortMode = DataGridViewColumnSortMode.NotSortable;
			kitapDataGrid.Columns["bturu"].SortMode = DataGridViewColumnSortMode.NotSortable;
			kitapDataGrid.Columns["bdurum"].SortMode = DataGridViewColumnSortMode.NotSortable;
			kitapDataGrid.Columns["bdosyakonumu"].SortMode = DataGridViewColumnSortMode.NotSortable;
			kitapDataGrid.ClearSelection();
			if (radioKitapAlanlar.Checked)
			{
				da4.Fill(ds, "ogrenci");
				ogrenciDataGrid.DataSource = ds.Tables["ogrenci"];
			}
			else if (radioSuresiGecenler.Checked)
			{
				da5.Fill(ds, "ogrenci");
				ogrenciDataGrid.DataSource = ds.Tables["ogrenci"];
			}
			else if(radioTumunuGoster.Checked)
			{
				da3.Fill(ds, "ogrenci");
				ogrenciDataGrid.DataSource = ds.Tables["ogrenci"];
			}
			ogrenciDataGrid.Columns["oid"].Visible = false;
			ogrenciDataGrid.Columns["kkuladi"].Visible = false;
			ogrenciDataGrid.Columns["bid"].Visible = false;
			ogrenciDataGrid.Columns["overilis"].Visible = false;
			ogrenciDataGrid.Columns["osontarih"].Visible = false;
			ogrenciDataGrid.Columns["okaydedilmetarihi"].Visible = false;
			ogrenciDataGrid.Columns["oguncellenmetarihi"].Visible = false;
			ogrenciDataGrid.Columns["oadi"].HeaderText = "Ad";
			ogrenciDataGrid.Columns["osoyadi"].HeaderText = "Soyad";
			ogrenciDataGrid.Columns["onumara"].HeaderText = "Numara";
			ogrenciDataGrid.Columns["obolum"].HeaderText = "Bölüm";
			ogrenciDataGrid.Columns["ocinsiyet"].HeaderText = "Cinsiyet";
			ogrenciDataGrid.Columns["otelefon"].HeaderText = "Telefon";
			ogrenciDataGrid.Columns["okitapkontrol"].HeaderText = "Kitap";
			ogrenciDataGrid.Columns["okitapdakika"].HeaderText = "Kalan Süre";
			ogrenciDataGrid.Columns["oadi"].SortMode = DataGridViewColumnSortMode.NotSortable;
			ogrenciDataGrid.Columns["osoyadi"].SortMode = DataGridViewColumnSortMode.NotSortable;
			ogrenciDataGrid.Columns["onumara"].SortMode = DataGridViewColumnSortMode.NotSortable;
			ogrenciDataGrid.Columns["obolum"].SortMode = DataGridViewColumnSortMode.NotSortable;
			ogrenciDataGrid.Columns["ocinsiyet"].SortMode = DataGridViewColumnSortMode.NotSortable;
			ogrenciDataGrid.Columns["otelefon"].SortMode = DataGridViewColumnSortMode.NotSortable;
			baglanti.Close();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
			baglanti.Open();
			komut = new OleDbCommand();
			komut.Connection = baglanti;
			for (int i = 0; i < ogrenciDataGrid.Rows.Count; i++)
			{
				if (ogrenciDataGrid.Rows[i].Cells["osontarih"].Value.ToString() == "")
				{

				}
				else
				{
					DateTime d1 = DateTime.Now;
					DateTime d2 = (DateTime)ogrenciDataGrid.Rows[i].Cells["osontarih"].Value;
					TimeSpan d3 = d2 - d1;
					komut.CommandText = "update ogrenci set okitapdakika=" + d3.Minutes + " where oid=" + ogrenciDataGrid.Rows[i].Cells["oid"].Value + "";
					komut.ExecuteNonQuery();
				}
			}
			
			baglanti.Close();
		}

		private void anasayfa_Load(object sender, EventArgs e)
		{
			kitapDataGrid.ClearSelection();
			ogrenciDataGrid.ClearSelection();
			listele();
			timer1.Enabled = true;
			timer1.Start();
			timer1.Interval = 100;
			timer1.Tick += new EventHandler(timer1_Tick);
		}
		private void öğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.Ctlcontrols.stop();
			ogrenciislemleri o = new ogrenciislemleri();
			o.Show();
			this.Hide();
		}
		private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.Ctlcontrols.stop();
			kitapislemleri k = new kitapislemleri();
			k.Show();
			this.Hide();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
			da1 = new OleDbDataAdapter("select * from kitaplar where kkuladi='" + giris.kuladi + "' and badi like '" + txtKitapAra.Text + "%'", baglanti);
			da1.Fill(dt);
			kitapDataGrid.DataSource = dt;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
			baglanti.Open();
			if (comboSirala.SelectedItem.ToString() == "İsme Göre (A-Z)")
			{
				da1 = new OleDbDataAdapter("select * from kitaplar where kkuladi='" + giris.kuladi + "' order by badi asc", baglanti);
				da1.Fill(dt);
				kitapDataGrid.DataSource = dt;
			}
			else if (comboSirala.SelectedItem.ToString() == "İsme Göre (Z-A)")
			{
				da1 = new OleDbDataAdapter("select * from kitaplar where kkuladi='" + giris.kuladi + "' order by badi desc", baglanti);
				da1.Fill(dt);
				kitapDataGrid.DataSource = dt;
			}
			else if (comboSirala.SelectedItem.ToString() == "Türe Göre (A-Z)")
			{
				da1 = new OleDbDataAdapter("select * from kitaplar where kkuladi='" + giris.kuladi + "' order by bturu asc", baglanti);
				da1.Fill(dt);
				kitapDataGrid.DataSource = dt;
			}
			else if (comboSirala.SelectedItem.ToString() == "Türe Göre (Z-A)")
			{
				da1 = new OleDbDataAdapter("select * from kitaplar where kkuladi='" + giris.kuladi + "' order by bturu desc", baglanti);
				da1.Fill(dt);
				kitapDataGrid.DataSource = dt;
			}
			else if (true)
			{

			}
			baglanti.Close();
		}

		private void txtKitapAra_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
			baglanti.Open();
			da1 = new OleDbDataAdapter("select * from kitaplar where badi like '" + txtKitapAra.Text + "%' and kkuladi='" + giris.kuladi + "'", baglanti);
			da1.Fill(dt);
			kitapDataGrid.DataSource = dt;
		}
		private void txtOgrenci_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
			baglanti.Open();
			if (rdİsmeGore.Checked)
			{
				da1 = new OleDbDataAdapter("select * from ogrenci where oadi like '" + txtOgrenci.Text + "%' and kkuladi='" + giris.kuladi + "'", baglanti);
				da1.Fill(dt);
				ogrenciDataGrid.DataSource = dt;
			}
			else if (rdNumaraGore.Checked)
			{
				da1 = new OleDbDataAdapter("select * from ogrenci where onumara like '" + txtOgrenci.Text + "%' and kkuladi='" + giris.kuladi + "'", baglanti);
				da1.Fill(dt);
				ogrenciDataGrid.DataSource = dt;
			}
			baglanti.Close();
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			lblEmanet.Text = "Emanet Süresi (" + trackBar1.Value + ")";
		}
		private void btnKitapVer_Click(object sender, EventArgs e)
		{
			if (ogrenciDataGrid.SelectedRows.Count > 0 && ogrenciDataGrid.SelectedRows.Count > 0)
			{
				DateTime bugun = DateTime.Now;
				DateTime geri = bugun.AddMinutes(trackBar1.Value);
				if (kitapDataGrid.CurrentRow.Cells["bdurum"].Value.ToString() == "Verildi")
				{
					MessageBox.Show("Bu kitap zaten verildi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if (ogrenciDataGrid.CurrentRow.Cells["okitapkontrol"].Value.ToString() == "Var")
					{
						MessageBox.Show("Öğrencini şuan zaten kitabı var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
						baglanti.Open();
						OleDbCommand cmd = new OleDbCommand();
						komut = new OleDbCommand();
						komut.Connection = baglanti;
						cmd.Connection = baglanti;
						komut.CommandText = "update kitaplar set bdurum='Verildi' where bid=" + kitapDataGrid.CurrentRow.Cells["bid"].Value + "";
						cmd.CommandText = "update ogrenci set okitapdakika=" + trackBar1.Value + ", okitapkontrol = 'Var', bid=" + kitapDataGrid.CurrentRow.Cells["bid"].Value + ", overilis='" + bugun + "', osontarih='" + geri + "' where oid=" + ogrenciDataGrid.CurrentRow.Cells["oid"].Value + "";
						OleDbCommand cmd2 = new OleDbCommand();
						cmd2 = new OleDbCommand("insert into kitapgecmisi (oadi, osoyadi, onumara, badi, kkuladi) values ('" + ogrenciDataGrid.CurrentRow.Cells["oadi"].Value + "', '" + ogrenciDataGrid.CurrentRow.Cells["osoyadi"].Value + "', '" + ogrenciDataGrid.CurrentRow.Cells["onumara"].Value + "', '" + kitapDataGrid.CurrentRow.Cells["badi"].Value + "', '" + giris.kuladi + "')", baglanti);
						cmd2.ExecuteNonQuery();
						komut.ExecuteNonQuery();
						cmd.ExecuteNonQuery();
						baglanti.Close();
					}
				}
				listele();
			}
			else
			{
				MessageBox.Show("Seçim yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void checkEmanet_CheckedChanged(object sender, EventArgs e)
		{
			listele();
		}

		private void checkSuresiGecenler_CheckedChanged(object sender, EventArgs e)
		{
			listele();
		}
		private void checkKitapAlanlar_CheckedChanged(object sender, EventArgs e)
		{
			listele();
		}
		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			giris g = new giris();
			g.Show();
			this.Hide();
		}
		private void btnKitapAl_Click(object sender, EventArgs e)
		{
			if (ogrenciDataGrid.SelectedRows.Count > 0)
			{
				if (ogrenciDataGrid.CurrentRow.Cells["okitapkontrol"].Value.ToString() == "Var")
				{
					baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
					baglanti.Open();
					komut = new OleDbCommand();
					komut.Connection = baglanti;
					komut.CommandText = "update ogrenci set bid=0, overilis=Null, osontarih=Null, okitapkontrol='Yok', okitapdakika=0 where oid=" + ogrenciDataGrid.CurrentRow.Cells["oid"].Value + "";
					komut.ExecuteNonQuery();
					OleDbCommand cmd = new OleDbCommand();
					cmd = new OleDbCommand();
					cmd.Connection = baglanti;
					cmd.CommandText = "update kitaplar set bdurum='Mevcut' where bid=" + ogrenciDataGrid.CurrentRow.Cells["bid"].Value + "";
					cmd.ExecuteNonQuery();
					baglanti.Close();
					listele();
				}
				else
				{
					MessageBox.Show("Bu öğrencinin zaten kitabı yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Seçim yapmadınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ogrenciDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			ogrenciDataGrid.ClearSelection();
		}

		private void kitapDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			kitapDataGrid.ClearSelection();
		}

		private void kitapGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			kitapgecmisi g = new kitapgecmisi();
			g.Show();
			this.Hide();
		}

		private void profilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			profil p = new profil();
			p.Show();
			this.Hide();
		}

		private void kitapDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source= " + Application.StartupPath + "\\database.accdb");
			baglanti.Open();
			if (kitapDataGrid.CurrentRow.Cells["bdosyakonumu"].Value.ToString() == "")
			{
				axWindowsMediaPlayer1.Visible = false;
				axWindowsMediaPlayer1.Ctlcontrols.stop();
			}
			else
			{
				axWindowsMediaPlayer1.Visible = true;
				axWindowsMediaPlayer1.URL = kitapDataGrid.CurrentRow.Cells["bdosyakonumu"].Value.ToString();
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
		}

		private void radioKitapAlanlar_CheckedChanged(object sender, EventArgs e)
		{
			listele();
		}

		private void radioSuresiGecenler_CheckedChanged(object sender, EventArgs e)
		{
			listele();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			listele();
		}
	}
}
