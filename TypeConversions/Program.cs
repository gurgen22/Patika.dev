using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 45;
            string e = "zikriye";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine(g);

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string sayi1 = "10";
            string sayi2 = "20";
            int toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
            Console.WriteLine(toplam);

        }
    }
}
