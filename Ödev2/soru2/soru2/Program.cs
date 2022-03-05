using System;
using System.Collections;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve
            //ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            

            int[] sayilar = new int[5];
            int[] ucBuyukSayi = new int[3];
            int[] ucKucukSayi = new int[3];
            int ucKucukSayiToplam = 0;
            int ucBuyukSayiToplam = 0;



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bir sayi giriniz:");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sırasiz dizi:");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Array.Sort(sayilar);
            Console.WriteLine("Üç küçük sayı");
            for (int i = 0; i <3;i++)
            {
                ucKucukSayi[i] = sayilar[i];
                ucKucukSayiToplam += sayilar[i];
                
            }
            foreach (var sayi in ucKucukSayi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("Üç büyük sayı");
            int j = 0;
            for(int i = 4; i > 1; i--)
            {
                ucBuyukSayi[j] = sayilar[i];
                ucBuyukSayiToplam += sayilar[i];
                j++;
            }
            foreach (var sayi in ucBuyukSayi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Kucuk sayiların toplamı:"+ ucKucukSayiToplam + " ortalaması: "+ucKucukSayiToplam/3);
            Console.WriteLine("Buyuk sayiların toplamı:"+ ucBuyukSayiToplam + " ortalaması: "+ucBuyukSayiToplam/3);

        }
    }
}
