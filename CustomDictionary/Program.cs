using System;

namespace CustomDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> kutuphane = new MyDictionary<string, string>();
            kutuphane.Add("ali", "veli");
            kutuphane.Add("ali","veli");

            for (int i = 0; i < kutuphane.Count; i++)
            {
                Console.WriteLine(kutuphane.Count.ToString());
                //Console.WriteLine("Hello Kitty");
            }

        }
    }
}
