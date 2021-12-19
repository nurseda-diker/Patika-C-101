using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar programı parçalamak için kullanılır.
            //erişim;_belirteci geri_dönüş_tipi metot_adi(parametreListesi/argüman)
            // {
            //komutlar
            // }

            //static bir class içerisinden sadece static methodlara erişilebilir.

            int a = 2;
            int b = 3;
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            //call by value ile çağırdığımız için değişkenin değeri değişmedi
            int sonuc2 = ornek.ArttirVeTopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));//çıktı 7
            ornek.EkranaYazdir(Convert.ToString(a + b));//çıktu 5

            //call by reference ile çağırma:a ile b'nin bellek adreslerini veriyoruz.
            int sonuc3 = ornek.RefArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc3));//çıktı 7
            ornek.EkranaYazdir(Convert.ToString(a + b));//çıktu 7
        }

        public static int Topla(int a, int b)
        {
            return a + b;
        }




    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }


        //call by value
        public int ArttirVeTopla(int deger1,int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }

        //call by reference
        public int RefArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
























}
