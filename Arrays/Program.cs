using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[5];
            string[] animals = { "dog", "cat" };
            int[] array;
            array = new int[5];
            colors[0] = "blue";
            array[3] = 10;
            Console.WriteLine(animals[1]);
            Console.WriteLine(array[3]);
            Console.WriteLine(colors[0]);

            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.Write("Lütfen dizinin eleman sayısını giriniz.");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayısı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
                Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);
            }

        }
    }
}
