using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-------------------------------------------------------------- 1 ------------------------------------------------------*/
            Console.WriteLine("Pozitif bir tam sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());

            List<int> sayilar = new List<int>();
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Pozitif tam sayı giriniz.");
                int gelenSayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(gelenSayi);
            }

            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            /*-------------------------------------------------------------- 2 ------------------------------------------------------*/
            /*-------------------------------------------------------------- 3 ------------------------------------------------------*/
            /*-------------------------------------------------------------- 4 ------------------------------------------------------*/
        }
    }
}
