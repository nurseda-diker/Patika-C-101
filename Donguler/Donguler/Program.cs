using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır
            //Console.ReadLine() ekrandan string okur.Bu yüzden int veri türüne çevrilmeli.
            Console.WriteLine("Lütfen bir sayi giriniz:");
            int saayac = int.Parse(Console.ReadLine());
            //for loop
            for(int i = 1; i <= saayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların toplamını ekrana yazdırma
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek toplam:" + tekToplam);
            Console.WriteLine("Çift toplam:"+ciftToplam);

            //break-continue
            for(int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i); //1 2 3 yazdırır
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i); //1 2 3 5 6 7 8 9 yazdırır
            }

            //while döngüsü
            //1 den başlayarak girilen sayıya kadar ortalama hesaplama
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama:"+toplam/sayi);

            //a'dan z'ye kadar tüm harfleri konsola yazdırma
            char karakter='a';
            while (karakter<'z')
            {
                Console.Write(karakter);
                karakter++;
            }

            //foreach
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }






        }
    }
}
