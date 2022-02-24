﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Birden fazla veri tipi saklanabilir.
           
            ArrayList liste = new ArrayList();
            liste.Add("Ayse");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere erişim
            Console.WriteLine(liste[1]);
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("*** Add Range ***");
            string[] renkler = { "kirmizi", "sari","yesil"};
            List<int> sayilar = new List<int>{1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("*** Sort ****");

            //Binary Search
            Console.WriteLine("*** Binary Search ***");
            Console.WriteLine(liste.BinarySearch(9)); //indexini döndürür


            //Reverse
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("*** Clear ****");
            liste.Clear();













        }
    }
}
