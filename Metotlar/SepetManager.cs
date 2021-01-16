using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //name convention

        public void Ekle()
        {
            Console.WriteLine("Sepete Eklendi");
        }

        public void Ekle2 (string urunAdi, string aciklama)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
