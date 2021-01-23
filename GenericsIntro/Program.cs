using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Haydar");
            isimler.Add("Mert");
            Console.WriteLine("");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetData(i));
            }


            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(2);
            sayilar.Add(3);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar.GetData(i));
            }

            Console.WriteLine(sayilar.GetData(3));
        }
    }
}
