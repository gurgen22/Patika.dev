using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new();
            sayilar.Add(12);
            sayilar.Add(24);
            sayilar.Add(1);
            sayilar.Add(2);

            List<string> renkList = new();
            renkList.Add("Kırmızı");
            renkList.Add("Sarı");
            renkList.Add("Turuncu");
            renkList.Add("Mavi");
            renkList.Add("Yeşil");

            //Count
            Console.WriteLine(renkList.Count);
            Console.WriteLine(sayilar.Count);

            foreach (var renk in renkList)
            {
                Console.WriteLine(renk);
            }

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }


            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkList.ForEach(renk => Console.WriteLine(renk));

            sayilar.Remove(12);
            renkList.Remove("Yeşil");
            sayilar.RemoveAt(0);
            renkList.RemoveAt(1);

            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkList.ForEach(renk => Console.WriteLine(renk));

            //Contains

            if (sayilar.Contains(8))
            {
                Console.WriteLine("8 Liste içerisinde bulundu.");
            }

            Console.WriteLine(renkList.BinarySearch("Turuncu"));

            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.Clear();

            //Liste içinde liste tutma
            List<Kullanıcılıar> kullanıcıListesi = new List<Kullanıcılıar>();

            Kullanıcılıar kullanıcı1 = new Kullanıcılıar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 24;

           
            kullanıcıListesi.Add(kullanıcı1);
          

            List<Kullanıcılıar> yeniListe = new List<Kullanıcılıar>();
            yeniListe.Add(new Kullanıcılıar()
            {
                Isim = "Arda",
                Soyisim = "Veda",
                Yas = 29
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:  "+ kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:  "+ kullanıcı.Yas);
            }
        }
    }

    public class Kullanıcılıar
    {
        string isim;
        string soyisim;
        int yas;
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }

    }
}
