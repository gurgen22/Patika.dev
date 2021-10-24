using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calısan c1 = new();
            c1.adı = "Emre";
            c1.soyadı = "Yılmaz";
            c1.no = 123456;
            c1.departman = "İnsan Kaynakları";
            
            c1.BilgilerGetir();

        }
    }

    class Calısan
    {
        public string adı { get; set; }
        public string soyadı { get; set; }
        public int no { get; set; }
        public string departman { get; set; }
        public void BilgilerGetir()
        {
            Console.WriteLine("Çalışanının adı: {0}", adı);
            Console.WriteLine("Çalışanının adı: {0}", soyadı);
            Console.WriteLine("Çalışanının adı: {0}", no);
            Console.WriteLine("Çalışanının adı: {0}", departman);
        }
    }
}
