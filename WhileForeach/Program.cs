using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
           //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
           Console.WriteLine("Lütfen bir sayı girin.");
           int sayi = int.Parse(Console.ReadLine());
           int sayac = 1;
           int toplam = 0;
           while (sayac<=sayi)
           {
               toplam += sayac;
               sayac++;
           }

           Console.WriteLine(toplam/sayi);

           string[] cars = {"Ford", "Renault", "Toyota"};
           foreach (var car in cars)
           {
               Console.WriteLine(car);
           }
        }
    }
}
