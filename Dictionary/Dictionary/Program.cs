using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> kullanicilar = new Dictionary<int,string>();

            kullanicilar.Add(10, "Ayse Yilmaz");
            kullanicilar.Add(12, "Ahmet Yilmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Cosar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("*** Elemanlara erişim ***");
            Console.WriteLine(kullanicilar[12]);

            foreach(var user in kullanicilar)
            {
                Console.WriteLine(user);
            }

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            kullanicilar.Remove(12);
            foreach (var user in kullanicilar)
            {
                Console.WriteLine(user);
            }

            //Keys
            foreach (var user in kullanicilar.Keys)
            {
                Console.WriteLine(user);
            }

            //Values
            foreach (var user in kullanicilar.Values)
            {
                Console.WriteLine(user);
            }








        }
    }
}
