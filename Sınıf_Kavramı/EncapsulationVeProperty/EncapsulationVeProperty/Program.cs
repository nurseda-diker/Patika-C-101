using System;

namespace EncapsulationVeProperty
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kapsülleme,bir nesnenin bazı özelliklerini veya işlevlerini,metodlarını diğer class
            //ve nesnelerden korumak anlamına geliyor.Bu koruma erişim belirleyiciler ile yapılıyor.

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yilmaz";
            ogrenci.OgrenciNo =260;
            ogrenci.Sinif =3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();





        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; } //property
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
                

            }
        }

        public Ogrenci() { }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }


        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Ogrenci Bilgileri *****");
            Console.WriteLine("Öğrenci adi:{0} ",this.Isim);
            Console.WriteLine("Öğrenci soyadi:{0} ", this.Soyisim);
            Console.WriteLine("Öğrenci no:{0} ", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sinifi:{0} ", this.Sinif);
        }


        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;

        }



    }


}
