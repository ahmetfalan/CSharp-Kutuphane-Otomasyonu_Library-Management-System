using System;
using System.IO;
using System.Windows.Forms;

namespace kutuphaneotomasyon
{
    public partial class progressform : Form
    {
        public progressform()
        {
            InitializeComponent();
        }
        public static long DosyaBoyutuHesapla(string dosyakonumu)
        {
            try
            {
                FileInfo dosya = new FileInfo(dosyakonumu);
                long boyut = dosya.Length / 1024;
                return boyut;
            }
            catch
            {

            }
            return 0;
        }
        public void progressform_Load(object sender, EventArgs e)
        {
            kitapislemleri k = new kitapislemleri();
            long dosyaboyutu = DosyaBoyutuHesapla(kitapislemleri.dosyakonumu);
            progressBar1.Maximum = Convert.ToInt32(dosyaboyutu);
            progressBar1.Minimum = 0;
            progressform p = new progressform();
            for (int i = 0; i < dosyaboyutu; i++)
            {
                progressBar1.Value++;
            }
            label1.Text = Path.GetFileNameWithoutExtension(kitapislemleri.dosyakonumu) + " dosyası yüklendi...";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
