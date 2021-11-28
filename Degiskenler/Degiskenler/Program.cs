using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degisken isimlendirirken dikkat edilmesi gerekenler:
            //degisken isimleri büyük-küçük harf duyarlıdır
            //değişken adları rakamla başlayamaz
            //class,kutuphane isimleri gibi özel isimler değişken adı olamaz
            //aynı kod bloğu içinde aynı değişken birden fazla tanımlanamaz
            //işlem operatörleri(+,-,*,/ ),bosluk kullanılamaz
            int deger=2;
            string degisken = null;
            string Degisken = null;
            String degisken2 = " ";
            byte b = 5; //0-255
            sbyte c = 5; //-128-127
                         
            short d = 5; //2 byte
            ushort e = 5; //2 byte

            Int16 i16 = 2; //2 byte
            int i = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 3; //8 byte
            uint ui = 2; //4 byte

            long l = 4; //8 byte
            ulong u1 = 4; //8 byte

            //reel sayılar
            float f = 5; //4 byte
            double y = 5; //8 byte

            decimal de = 5; //16 byte

            char x = '2'; //2 byte
            string str = "abcdef"; //sınırsız

            bool b1 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x"; //her türlü veri için
            object o2 = 54;
            object o3 = 5.2;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "c#";
            string ad = "nur";
            string soyad = "diker";
            string tamIsim = ad + " " + soyad;

            //integer

            int int1 = 5;
            int int2 = 2;
            int int3 = int1 * int2;

            //boolean
            bool bool1 = 10 < 2;
            bool bool2 = 10 > 2;

            //değişken dönüşümleri
            string str3 = "20";
            int int4 = 20;
            string yeniDeger = str3 + int4.ToString();
            Console.WriteLine(yeniDeger); //Çıktı:2020

            int int5 = int4 + Convert.ToInt32(int4);
            Console.WriteLine(int5); //Çıktı:40

            int int6 = int4 + int.Parse(str3);
            Console.WriteLine(int6); //Çıktı:40


            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //saat
            string datetime3 = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(datetime3);













            Console.WriteLine("Hello World!");
        }
    }
}
