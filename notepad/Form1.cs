using OopNotepad;
using System.IO; // Dosya yolu iþlemleri için

namespace notepad
{
    public partial class Form1 : Form
    {
        private Belge aktifBelge; // OOP burada baþlýyor! Form, bir 'Belge' nesnesini yönetiyor.
        public Form1()
        {
            InitializeComponent();
            aktifBelge = new Belge();
            GuncelleFormBasligi(); // Baþlýðý güncelleyecek bir metot (aþaðýda yapacaðýz)
        }
        // "YENÝ" Menüsü
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Kaydedilmemiþ deðiþiklik var mý diye kontrol et

            txtMetinAlani.Clear();
            aktifBelge = new Belge(); // Yeni bir nesne oluþtur
            GuncelleFormBasligi();
        }

        // "AÇ" Menüsü
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Kaydedilmemiþ deðiþiklik var mý diye kontrol et

            // openFileDialog1 ayarlarý
            openFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog1.FileName;
                string? icerik = DosyaIslemleri.DosyaOku(dosyaYolu);

                if (icerik != null)
                {
                    txtMetinAlani.Text = icerik;
                    // 'aktifBelge' nesnemizin durumunu güncelle
                    aktifBelge.YeniDosyaAc(dosyaYolu, icerik);
                    GuncelleFormBasligi();
                }
            }
        }

        // "KAYDET" Menüsü
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Eðer dosya daha önce hiç kaydedilmediyse (yolu yoksa),
            // "Farklý Kaydet" iþlemini çaðýrmalýyýz.
            if (string.IsNullOrEmpty(aktifBelge.DosyaYolu))
            {
                // "Farklý Kaydet" menüsünün click olayýný tetikle
                farklýKaydetToolStripMenuItem.PerformClick();
            }
            else
            {
                // Dosya yolu var, direkt üzerine yaz
                bool sonuc = DosyaIslemleri.DosyaYaz(aktifBelge.DosyaYolu, txtMetinAlani.Text);
                if (sonuc)
                {
                    aktifBelge.Kaydedildi(aktifBelge.DosyaYolu); // Belge nesnesine "kaydedildin" diyoruz
                    GuncelleFormBasligi();
                }
            }
        }

        // "FARKLI KAYDET" Menüsü
        private void farklýKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = saveFileDialog1.FileName;
                bool sonuc = DosyaIslemleri.DosyaYaz(dosyaYolu, txtMetinAlani.Text);
                if (sonuc)
                {
                    aktifBelge.Kaydedildi(dosyaYolu); // Belge nesnesinin yeni yolunu ve durumunu güncelle
                    GuncelleFormBasligi();
                }
            }
        }

        // "KES", "KOPYALA", "YAPIÞTIR" Menüleri
        // RichTextBox bu iþlevleri zaten kendi içinde barýndýrýr.
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMetinAlani.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMetinAlani.Copy();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMetinAlani.Paste();
        }

        // METÝN ALANI DEÐÝÞTÝÐÝNDE
        // Bu olay, kullanýcý her tuþa bastýðýnda tetiklenir.
        private void txtMetinAlani_TextChanged(object sender, EventArgs e)
        {
            // Metin alaný deðiþtiyse, 'aktifBelge' nesnemizin durumunu güncellemeliyiz.
            // 'aktifBelge' null deðilse (program ilk açýlýrken hata almamak için)
            if (aktifBelge != null)
            {
                aktifBelge.IcerikDegisti(txtMetinAlani.Text);
                GuncelleFormBasligi();
            }
        }
        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        // YARDIMCI METOT: Form Baþlýðýný Güncelle
        // Bu metodu 'Form1.cs' içine herhangi bir yere ekleyebilirsiniz.
        private void GuncelleFormBasligi()
        {
            string dosyaAdi = "Baþlýksýz"; // Varsayýlan

            // Eðer dosya yolu varsa, dosya adýný al
            if (!string.IsNullOrEmpty(aktifBelge.DosyaYolu))
            {
                dosyaAdi = Path.GetFileName(aktifBelge.DosyaYolu);
            }

            // Kaydedilmediyse, baþýna '*' ekle
            string kayitDurumu = aktifBelge.KaydedildiMi ? "" : "*";

            this.Text = $"{kayitDurumu}{dosyaAdi} - OopNotepad";
        }
        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programý kapatýr
        }
    }
}
