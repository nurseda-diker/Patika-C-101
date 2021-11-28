using System;

namespace Console_Programlama
{
    class Program
    {
        static void Main(string[] args)  //default olarak public'tir
        {
            Console.WriteLine("Hello World!");//console bir sınıf
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + lastName);
        }
    }
}

//ilk çalışcak olan satır main'in ilk satırı
//son çalışacak olan satır main'in son satırı

//static:nesne yaratılmadan methoda ulaşılabileceğini belirtir

//string[] args: komut satırı argümanlarını almak için
