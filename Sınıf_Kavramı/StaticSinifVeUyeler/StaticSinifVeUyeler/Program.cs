using System;

namespace StaticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Static olan nesnelere o sınıfın adıyla,nesne oluşturmadan erişilebilir.
            //Static sınıflara kalıtım uygulanamaz.

            Console.WriteLine("Çalışan sayısı:{0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe","Yilmaz","İK");
            Console.WriteLine("Çalışan sayısı:{0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama islemi sonucu:{0}", Islemler.Topla(100,456));
            Console.WriteLine("Çıkarma islemi sonucu:{0}", Islemler.Cikar(456,100));






        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string isim;
        private string soyisim;
        private string departman;

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++;
        }

        //static kurucuların erişim belirteci yoktur.
        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan() { }

        

    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }



}
