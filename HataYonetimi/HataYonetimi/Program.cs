using System;

namespace HataYonetimi
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try //içine hataya neden olabilecek kod yazılır
            {
                Console.WriteLine("Bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayi:" + sayi);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally //her türlü durumda çalışması istenen kodlar buraya yazılır
            {
                Console.WriteLine("İşlem tamamlandı");
            }

            try
            {
               // int a = int.Parse(null);
                //int b = int.Parse("test");
                int c = int.Parse("-20000000000"); 
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir deger girdiniz");
                Console.WriteLine(ex);
            }
        
        }
    }
}


//hatalar oluşma zamanına göre compiler time error ve run time error olmak üzere 2 ye ayrılır.
//Compiler time hatalar kodu yazarken derleyicinin fırlattığı hatalardır.Örnek olarak bir değişken tanımlandıktan
//sonra değişkene atama yapmadan kullanmaya çalışmak.












