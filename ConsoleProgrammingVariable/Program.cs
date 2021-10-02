using System;

namespace ConsoleProgrammingVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string schoolName = "";
            int schoolNumber = 110;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            string name = string.Empty;
            name = "Elif";

            string number1 = "10";
            int number2 = 20;
            string newNumber = number1 + number2.ToString();
            Console.WriteLine(newNumber);

            string dateTime = DateTime.Now.ToString("yy-MMM-dd ddd");
            string dateTimeHour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTimeHour);
        }
    }
}
