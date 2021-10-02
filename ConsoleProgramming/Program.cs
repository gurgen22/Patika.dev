using System;

namespace ConsoleProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsim giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisim giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba"+" "+name+" "+surname);
        }           
    }
}
