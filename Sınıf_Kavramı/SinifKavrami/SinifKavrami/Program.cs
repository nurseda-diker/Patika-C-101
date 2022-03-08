using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //  [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi]  MetodAdi(Parametre Listesi)
            // {
            //   Metot Komutları
            // }
            // }

            //Erişim Belirleyiciler
            // * Public -> Her yerden erişilebilir.
            // * Private -> Sadece tanımlandığı sınıf içerisinde erişilebilir.
            // * Internal -> Sadece kendi bulunduğu proje içerisinde  erişilebilir.
            // * Protected -> Sadece tanımlandığı sınıfta ve o sınıftan kalıtım alan diğer sınıflardan erişilebilir.


            Calisan calisan1 = new Calisan("Ayse","Kara", 23645678, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Deniz";
            calisan2.soyad = "Arda";
            calisan2.no = 12364578;
            calisan2.departman = "Satın Alma";

            calisan2.CalisanBilgileri();


            Calisan calisan3 = new Calisan("Zikriye", "Ürkmez");
            calisan3.CalisanBilgileri();


        }
    }
}

class Calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;

    //constructor
    public Calisan(string ad,string soyad,int no,string departman)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.no = no;
        this.departman = departman;
    }

    public Calisan() { }
    public Calisan(string ad, string soyad)
    {
        this.ad = ad;
        this.soyad = soyad;
    }



    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan adi:{0}",ad);
        Console.WriteLine("Çalışan soyadi:{0}", soyad);
        Console.WriteLine("Çalışanın numarası:{0}",no);
        Console.WriteLine("Çalışanın departmanı:{0}",departman);
    }
}



















