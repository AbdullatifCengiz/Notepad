OopNotepad (C# WinForms)

Nesne Tabanlı Programlama dersi için C# ve Windows Forms kullanılarak geliştirilmiş basit not defteri uygulaması.



✨ Temel Özellikler

Yeni, Aç, Kaydet, Farklı Kaydet



Kes, Kopyala, Yapıştır



Kaydedilmemiş değişiklikleri (\*) başlıkta gösterme



🏛️ OOP Mimarisi

Proje, sorumlulukları ayırmak için 3 ana sınıfa bölünmüştür:



Form1.cs (Arayüz)



Kullanıcı arayüzünü (UI) ve tıklama gibi olayları yönetir.



Belge.cs (Model)



Aktif dosyanın Icerik, DosyaYolu ve KaydedildiMi durumunu kapsüller (tutar).



DosyaIslemleri.cs (Servis)



Tek sorumluluğu vardır: Diske dosya okuma (DosyaOku) ve yazma (DosyaYaz) işlemlerini yapmak.



Abdüllatif Cengiz Fırat Üniversitesi Yazılım Mühendisliği

