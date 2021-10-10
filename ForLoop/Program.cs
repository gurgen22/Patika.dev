using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lürfen bir sayı giriniz.");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendiiçlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%2==1)
                {
                    tekToplam += i;
                }

                ciftToplam += i;
            }

            Console.WriteLine("Tek toplam: " + tekToplam);
            Console.WriteLine("Çift toplam: " + ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
