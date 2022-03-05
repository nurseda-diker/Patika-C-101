using System;
using System.Collections;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            
            Console.WriteLine("Bir cumle giriniz:");
            string cumle = Console.ReadLine().ToLower();
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            ArrayList sesliHarfler = new ArrayList();

            foreach(var item in cumle)
            {
                for(int i = 0; i < sesliler.Length; i++)
                {
                    if (item == sesliler[i])
                    {
                        sesliHarfler.Add(item);
                    }
                }
                
            }

            Console.WriteLine("Girilen cumledeki sesli harfler:");
            foreach(var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }



        }
    }
}
