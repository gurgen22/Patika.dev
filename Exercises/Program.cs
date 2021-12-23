using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ödev numarasını giriniz.");
            int odev = Convert.ToInt32(Console.ReadLine());
            if (odev == 1)
            {
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
            }



            else if (odev == 2)
            {
                Console.WriteLine("Pozitif tam sayı giriniz.");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pozitif tam sayı giriniz.");
                int m = Convert.ToInt32(Console.ReadLine());

                List<int> DegerListesi = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Sayı giriniz.");
                    int gelenDeger = Convert.ToInt32(Console.ReadLine());
                    DegerListesi.Add(gelenDeger);
                }

                for (int j = 0; j < DegerListesi.Count; j++)
                {
                    if (j == m || j % m == 0)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            else if (odev == 3)
            {
                Console.WriteLine("Pozitif bir sayı giriniz.");
                int n = Convert.ToInt32(Console.ReadLine());

                List<string> deger = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Kelime giriniz.");
                    string gelenDeger = Console.ReadLine();
                    deger.Add(gelenDeger);
                }
                deger.Reverse();
                foreach (var item in deger)
                {
                    Console.WriteLine(item);
                }
            }
            else if (odev == 4)
            {

                Console.WriteLine("1 cümle giriniz.");
                string gelenDeger = Console.ReadLine();
                string[] liste = gelenDeger.Split(" ");
                Console.WriteLine("Kelime sayısı: " + liste.Length);
                Console.WriteLine("Karakter sayısı: " + gelenDeger.Length);
            }
            else
            {
                Console.WriteLine("Hatalı işlem yapıldı.");
            }

        }
    }
}
