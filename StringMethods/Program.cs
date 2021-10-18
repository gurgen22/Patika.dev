using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Merhaba";
            string degisken2 = "Dersimiz C#";
            //Padleft, PadRight;
            Console.WriteLine(degisken.PadRight(15,'*')+ degisken2);

            // Split
            Console.WriteLine(degisken2.Split(' ')[0]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken2.Substring(1,6));
        }
    }
}
