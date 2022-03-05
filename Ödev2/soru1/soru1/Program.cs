using System;
using System.Collections;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.



            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int count = 0;
            int kontrol = 0;
            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            while (count < 3)
            {

                Console.Write("Sayı Girin : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                {



                    if (sayi == 1 || sayi == 0)
                    {
                        Console.WriteLine("Girdiğiniz sayı asal değildir.");
                        asalOlmayanSayilar.Add(sayi);
                        asalOlmayanToplam += sayi;

                    }
                    else
                    {
                        kontrol = 0;
                        for (int i = 2; i < sayi; i++)
                        {
                            if (sayi % i == 0) //Kalansız bölünüyormu?
                            {
                                kontrol++;
                                break; //Diğer sayılara bakmaya gerek duymuyoruz.
                            }


                        }

                        if (kontrol != 0)
                        {
                            Console.WriteLine("Girdiğiniz sayı asal değildir.");
                            asalOlmayanSayilar.Add(sayi);
                            asalOlmayanToplam += sayi;
                        }

                        else
                        {
                            Console.WriteLine("Girdiğiniz sayı asaldır.");
                            asalSayilar.Add(sayi);
                            asalToplam += sayi;
                        }

                    }


                    Console.ReadKey();

                    count++;
                }
            }

            foreach (var sayi in asalOlmayanSayilar)
            {
                Console.WriteLine("Asal olmayan sayilar");
                Console.WriteLine(sayi);
            }

            foreach (var sayi in asalSayilar)
            {
                Console.WriteLine("Asal sayilar");
                Console.WriteLine(sayi);
            }

            asalSayilar.Sort();
            asalSayilar.Reverse();
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();

            Console.WriteLine("Asal sayilarin eleman sayisi:" + asalSayilar.Count + " ortalaması:" + asalToplam / asalSayilar.Count);
            Console.WriteLine("Asal olmayan sayilarin sayisi: " + asalOlmayanSayilar.Count + " ortalaması:" + asalOlmayanToplam / asalOlmayanSayilar.Count);
        }
    }
}
