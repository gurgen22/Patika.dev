using System;

namespace Deno1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calısan c1 = new();
            c1.adı = "Emre";
            c1.soyadı = "Yılmaz";
            c1.no = 123456;
            c1.departman = "İnsan Kaynakları";

            Calısan c2 = new Calısan("Ayşe", "Kara", 555555, "İnsan Kaynakları");
            Calısan c3 = new Calısan("Merve", "Ak");

            c1.BilgilerGetir();
            c2.BilgilerGetir();
            c3.BilgilerGetir();

        }
    }

    class Calısan
    {
        public string adı { get; set; }
        public string soyadı { get; set; }
        public int no { get; set; }
        public string departman { get; set; }

        public Calısan(string ad, string soyadı, int no,string departman)
        {
            this.adı = ad;
            this.soyadı = soyadı;
            this.no = no;
            this.departman = departman;
        }
        public Calısan(string ad, string soyadı)
        {
            this.adı = ad;
            this.soyadı = soyadı;
        }

        public Calısan()
        {

        }
        public void BilgilerGetir()
        {
            Console.WriteLine("Çalışanının adı: {0}", adı);
            Console.WriteLine("Çalışanının adı: {0}", soyadı);
            Console.WriteLine("Çalışanının adı: {0}", no);
            Console.WriteLine("Çalışanının adı: {0}", departman);
        }
    }
}