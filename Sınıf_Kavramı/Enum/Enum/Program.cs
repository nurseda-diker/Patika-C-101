using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)(Gunler.Cumartesi));

            int sicaklik = 32;
            if(sicaklik<= (int)HavaDurumu.normal)
            {
                Console.WriteLine("Disariya cikmak için havanin biraz daha isinmasini bekleyelim");
            }
            else if (sicaklik >= (int)HavaDurumu.sicak)
            {
                Console.WriteLine("Disariya cikmak icin cok sicak bir gun.");
            }
            else if(sicaklik >= (int)HavaDurumu.normal && (int)sicaklik <= (int)HavaDurumu.cokSicak)
            {
                Console.WriteLine("Hadi disariya cikalim.");
            }






        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar

    }

    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sicak = 25,
        cokSicak = 30

    }









}
