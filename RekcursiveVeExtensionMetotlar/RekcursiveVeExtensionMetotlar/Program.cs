﻿using System;

namespace RekcursiveVeExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //recursive:özyinelemeli
            int result = 1;
            for(int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);


            Islemler ornek = new ();
            Console.WriteLine(ornek.Expo(3,4));

            //extension metotlar
            string ifade = "Csharp eğitimi";
            bool sonuc = ifade.checkSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2,1,5 };
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.getFirstCharacter());



        }
    }


    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs < 2)
            {
                return sayi;
            }
            return Expo(sayi, üs - 1)*sayi;
        }

        //Expo(3,4)
        //Expo(3,3)*3
        //Expo(3,2)*3*3
        //Expo(3,1)*3*3*3
        //3*3*3*3=3^4


    }

    //extension classlar ve metotlar static olmalı
    public static class Extension
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" ");

        }


        public static string RemoveSpaces(this string param)
        {
            string[] dizi = param.Split(" ");//stringi boşluklara göre ayır ve diziye ata.
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param %2==0;
        }

        public static string getFirstCharacter(this string param)
        {
            return param.Substring(0, 1);//0.indexten başlayarak 1 karakter getir
        }

    }


}




















