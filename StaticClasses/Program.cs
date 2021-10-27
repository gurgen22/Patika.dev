using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Ayşe","Yılmaz","İK");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işleminin sonucu: {0}", Islemler.Topla(1, 2));
            Console.WriteLine("Çıkarma işleminin sonucu: {0}", Islemler.Cıkar(1, 2));
        
            
        }

    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi
        {
            get => calisanSayisi;
            //set => calisanSayisi = value;
        }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;

        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
