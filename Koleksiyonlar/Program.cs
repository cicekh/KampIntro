using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);


            //diziyi genişletemezsin. new keyword ü yeni bir dizi açar bellekte ve önceki indexlerdeki değerler atılır.
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);


            // burada sıkıntısız ekleme yapabilirsiniz.
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2[4] = "İlker";
            Console.WriteLine(isimler2[4]);

            //0 ıncı index te korunur.
            Console.WriteLine(isimler2[0]);




        }
    }
}
