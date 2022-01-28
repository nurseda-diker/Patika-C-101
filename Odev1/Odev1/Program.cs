using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan 
            //çift olanlar console'a yazdırın
             int n;
             Console.WriteLine("n sayisini giriniz:");
             n = Convert.ToInt32(Console.ReadLine());
             int[] sayilar = new int[n];
             for(int i = 0; i < n; i++)
             {
                 Console.WriteLine("Pozitif bir sayi giriniz:");
                 int number = Convert.ToInt32(Console.ReadLine());
                 sayilar[i] = number;
             }
             for(int i = 0; i < n; i++)
             {
                 if(sayilar[i] % 2 == 0)
                 {
                     Console.WriteLine(sayilar[i]);
                 }
             }

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            int a, b;
            Console.WriteLine("Ilk sayiyi girin:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi girin:");
            b = Convert.ToInt32(Console.ReadLine());
            int[] sayi = new int[a];
            int c;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Sayiyi giriniz:");
                c = Convert.ToInt32(Console.ReadLine());
                sayi[i] = c;
                if (sayi[i] == b || sayi[i] % b == 0)
                {
                    Console.WriteLine(sayi[i]);
                }
            }

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            int x;
            Console.WriteLine("x sayisini girin:");
            x = Convert.ToInt32(Console.ReadLine());
            string[] sozcukler = new string[x];

            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Kelime girin");
                string sozcuk = Convert.ToString(Console.ReadLine());
                sozcukler[i] = sozcuk;
            }
            for(int i = sozcukler.Length-1; i>=0; i--)
            {
                Console.WriteLine(sozcukler[i]);
            }

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            string metin;
            Console.WriteLine("Bir cumle giriniz:");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');

            Console.WriteLine("Kelime sayisi:"+kelimeler.Length);
            foreach(string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            Console.WriteLine("Harf sayisi:"+metin.Length);





        }
    }
}
