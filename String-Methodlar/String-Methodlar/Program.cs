using System;

namespace String_Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string degisken = "Dersimiz C# Hosgeldiniz";
            string degisken2 = "Dersimiz C#";

            //length
            Console.WriteLine(degisken.Length);

            //ToUpper-ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //concat
            Console.WriteLine(string.Concat(degisken,"Merhaba"));

            //compare-compareto
            //CompareTo 1.değişken 2.değişkene eşit olursa 0 döndürür.1.değişken 2.değişkenden daha fazla karakter sayısına sahipse 1 döndürür.
            //1.değişken 2.değişkden daha az karakter sayısına sahipse -1 döndürür
            Console.WriteLine(degisken.CompareTo(degisken2));

            Console.WriteLine(String.Compare(degisken,degisken2,true)); //true büyük-küçük harf duyarlı.

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //indexOf
            Console.WriteLine(degisken.IndexOf("C#"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //PadLeft-PadRİght
            Console.WriteLine(degisken + degisken2.PadLeft(30)); 
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*')); //degisken2'nin soluna karakter uzunlugu 30 olacak şekilde yıldız eklenir.
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //remove
            Console.WriteLine(degisken.Remove(10));//10.indexten başlayarak sonuna kadar siler
            Console.WriteLine(degisken.Remove(5,3));//5.indexten başlayarak 3 karakter sil 
            Console.WriteLine(degisken.Remove(0,1));//baştan başlayıp 1 karakter siler

            //replace
            Console.WriteLine(degisken.Replace("C#","CSharp"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]);

            //substring
            Console.WriteLine(degisken.Substring(4,6));//4.indexten başlayarak 6 karakter getir
























        }
    }
}
