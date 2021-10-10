using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {1, 55, 4, 33, 62, 78};
            foreach (var sayi     in sayiDizisi)
                Console.WriteLine(sayi);
            

            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            

            Array.Clear(sayiDizisi, 2, 1);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine(Array.IndexOf(sayiDizisi, 78));


        }
    }
}
