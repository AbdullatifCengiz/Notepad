using System.IO; // Bu satırı eklemeyi unutmayın!

namespace OopNotepad
{
    public class DosyaIslemleri
    {
        // 'static' yaptık çünkü bu metotların bir durum tutmasına gerek yok,
        // sadece verilen işi yapıp sonuç döndürecekler.

        public static string? DosyaOku(string yol)
        {
            // try-catch ile hata yönetimi yapmak önemlidir.
            try
            {
                return File.ReadAllText(yol);
            }
            catch (Exception ex)
            {
                // Hata olursa kullanıcıyı bilgilendir
                System.Windows.Forms.MessageBox.Show("Dosya okunurken bir hata oluştu: " + ex.Message);
                return null; // Hata durumunda boş dön
            }
        }

        public static bool DosyaYaz(string yol, string icerik)
        {
            try
            {
                File.WriteAllText(yol, icerik);
                return true; // Başarılı
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Dosya yazılırken bir hata oluştu: " + ex.Message);
                return false; // Başarısız
            }
        }
    }
}