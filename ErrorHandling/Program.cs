using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduuğunuz sayı: " + " " + sayi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message.ToString());

            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }

            //try
            //{
            //    int a = int.Parse(null);

            //}

            //catch (Exception e)
            //{
            //    Console.WriteLine("Boş değer girdiniz.");
            //    Console.WriteLine(e);

            //}

            //try
            //{
            //    int b = int.Parse("test");
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine("Veri tipi uygun değil.");
            //    Console.WriteLine(ex);
            //}
        }
    }
}
