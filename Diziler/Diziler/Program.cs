using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizileri aynı tipteki değişkenleri bellekte arka arkaya saklamak istediğimizde kullanırız.
            //Diziler 0.elemandan başlar.

            //Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //Klavyden girilen n tane sayının ortalaması
            Console.WriteLine("Dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayilar=new int[diziUzunlugu];
            int toplam = 0;

            for(int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("{0}.sayiyi girin:",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama:"+toplam/diziUzunlugu);



            //Array Sınıfı Metotları
            //Sort(Sıralama)
            int[] sayiDizisi= { 23, 12, 86, 72, 3, 11, 17 };
            Console.WriteLine("**Sırasız dizi**");
            foreach(var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("**Sıralı dizi**");
            Array.Sort(sayiDizisi);
            foreach(var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("Array Clear");
            Array.Clear(sayiDizisi, 2, 3);//2.indexten başlayarak 3 tane elemanı 0'lar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);//dizinin elemanlarını ters çevirir
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("Array IndexOf");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 11));//11 elamanının index numarasını döndürür

            //Resize
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayiDizisi, 9);//dizi boyutunu değiştirme
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }






























        }
    }
}
