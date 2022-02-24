using System;
using System.Collections.Generic;
namespace GenericKoleksiyonlarVeList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T => object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(20);
            sayiListesi.Add(10);
            sayiListesi.Add(15);
            sayiListesi.Add(48);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("mavi");
            renkListesi.Add("kırmızı");
            renkListesi.Add("yeşil");
            renkListesi.Add("sarı");


            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Listeden eleman çıkarma
            sayiListesi.Remove(15);
            renkListesi.Remove("yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Liste içerisinde arama
            if (sayiListesi.Contains(20))
            {
                Console.WriteLine("Sayi liste icinde bulundu");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("mavi"));

            //Diziyi listeye çevirme
            string[] hayvanlar = { "kedi", "kopek", "kus" };
            List<string> hayvanlarList = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanlarList.Clear();

            //Liste içerisinde nesne tutma
            List<Kullanicilar> kullaniciList = new List<Kullanicilar>();
            Kullanicilar user1 = new Kullanicilar();
            user1.Isim = "Ayse";
            user1.Soyisim = "Yilmaz";
            user1.Yas = 26;

            Kullanicilar user2 = new Kullanicilar();
            user2.Isim = "Ozcan";
            user2.Soyisim = "Caliskan";
            user2.Yas = 24;

            kullaniciList.Add(user1);
            kullaniciList.Add(user2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Arda",
                Soyisim = "Yavuz",
                Yas = 25
            }
            );

            foreach(var user in kullaniciList)
            {
                Console.WriteLine("Kulllanici adi:" + user.Isim);
                Console.WriteLine("Kulllanici soyadi:" + user.Soyisim);
                Console.WriteLine("Kulllanici yasi:" + user.Yas);
            }




        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }


















}
