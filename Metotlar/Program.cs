using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 20;
            urun1.Aciklama="Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler)
            {

            }

            //encapsulation

            Console.WriteLine("---------Metotlar-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();

            sepetManager.Ekle2("Muz");
            sepetManager.Ekle2("Ayva");
        }
    }
}

// Do not repeat yourself... DRY...