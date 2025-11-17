using System;

namespace OopNotepad
{
    public class Belge
    {
        // Nitelikler (Attributes)
        public string Icerik { get; set; }
        public string? DosyaYolu { get; private set; }
        public bool KaydedildiMi { get; set; }

        // Yapıcı Metot (Constructor)
        // Yeni bir belge oluşturulduğunda çağrılır.
        public Belge()
        {
            this.Icerik = "";
            this.DosyaYolu = null; // Henüz bir yolu yok
            this.KaydedildiMi = true; // Boş bir belge kaydedilmiş sayılır
        }

        // Metotlar (Methods)
        public void YeniDosyaAc(string yol, string icerik)
        {
            this.DosyaYolu = yol;
            this.Icerik = icerik;
            this.KaydedildiMi = true; // Yeni açılan dosya da kaydedilmiş sayılır
        }

        public void IcerikDegisti(string yeniIcerik)
        {
            this.Icerik = yeniIcerik;
            this.KaydedildiMi = false; // İçerik değişti, kaydetmek gerekir
        }

        public void Kaydedildi(string yol)
        {
            // Dosya (farklı) kaydedildiğinde yolu günceller
            this.DosyaYolu = yol;
            this.KaydedildiMi = true;
        }
    }
}