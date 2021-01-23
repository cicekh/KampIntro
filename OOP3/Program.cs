using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu projedeki en önemli mesaj
            //Eğer senin bir base sınıfın varsa o base sınıf referans tutucudur.
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Hakan";
            musteri1.Soyadi = "Tan";
            musteri1.MusteriNo = "12345";
            musteri1.TCNo = "12345678910";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Müşteri sınıfı hem Gerçek Müşterinin hem de Tüzel Müşterinin referansını tutabiliyor demektir.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
