using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            var metotlar = new Metotlar();
            metotlar.Topla(5, 4, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme- Overloading

            int deger1 = 99;
            int deger2 = 88;
            


            metotlar.EkranaYazdır(deger1);
            metotlar.EkranaYazdır(deger1+deger2);
            metotlar.EkranaYazdır("Cumartesi ","Pazar");

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(int sayi)
        {
            Console.WriteLine(sayi);
        }

        public void EkranaYazdır(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
