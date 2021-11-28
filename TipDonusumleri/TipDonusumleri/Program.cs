using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion(bilinçsiz dönüşüm)
            //düşük kapasiteli değişkenin kendinden daha yüksek kapasiteli değişkene atanması

            byte a = 5;
            sbyte b = 30;
            short c = 30;
            int d = a + b + c;
            Console.WriteLine("d:"+d);

            long h = d; ;
            Console.WriteLine("h:"+h);

            float i = h;
            Console.WriteLine("i:"+i);

            string e = "visual studio";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" +g);

            //explicit conversion(bilinçli dönüşüm)
            int t = 4;
            byte y = (byte)t;
            Console.WriteLine("y:"+y);

            float z = 10.3f;
            int v = (int)z;
            Console.WriteLine("v:"+v);

            //toString Methodu
            int q = 6;
            string r = q.ToString();
            Console.WriteLine("q:"+q);

            string p = 12.5f.ToString();
            Console.WriteLine("p:"+p);

            //System.convert

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi2 + sayi1;
            Console.WriteLine("Toplam:"+toplam);

            //parse methodu
            string metin1 = "11";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("Rakam1:"+rakam1);
            Console.WriteLine("Double1:"+double1);


















        }
    }
}
