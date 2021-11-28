using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //atama ve işlemli atama
            int x = 5;
            int y = 3;

            y = y + 1;
            y += 2; //işlemli atama

            y /= 1;
            x *= 2;

            //mantıksal operatörler
            // || && !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }

            //ilişkisel operatörler
            // < > <= >= == !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //aritmetik operatörler
            // + * - / 

            int sayi = 4;
            int sayi2 = 12;
            int sonuc1 = sayi2 / sayi;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi2 - sayi;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi2 * sayi;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi2 / sayi;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi++;
            Console.WriteLine(sonuc1);

            //% mod alma
            sonuc1 = sayi2 % sayi;
            Console.WriteLine(sonuc1);










        }
    }
}
