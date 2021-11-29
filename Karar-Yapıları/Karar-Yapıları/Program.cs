using System;

namespace Karar_Yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>=6 && time <= 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }
            //ternary if
            string sonuc = time < 18 ? "İyi günler" : "İyi geceler";
            
            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);


            //switch case
            int month = DateTime.Now.Month;

            //expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimindesiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz");
                    break;
            }





        }
    }
}
