using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği c# , java
            //Do not repeat yourself

            string kategoriEtiketi = "Kategoriler";
            Console.WriteLine(kategoriEtiketi);
            bool sistemeGirisYapilmisMi = true;

            if (sistemeGirisYapilmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


        }
    }
}
