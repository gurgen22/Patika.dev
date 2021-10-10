using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }

            switch (month)
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz.");
                    break;
                default:
                    break;

            }
        }
    }
}
