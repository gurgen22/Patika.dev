using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 14;
            ogrenci.Sinif = 3;

            Ogrenci ogrenci1 = new("Deniz", "Arda",112,1);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();
        }

        class Ogrenci
        {
            private string isim;
            private string soyisim;
            private int ogrenciNo;
            private int sinif;
            public string Isim
            {
                get => isim;
                set => isim = value;
            }
            public string Soyisim
            {
                get => soyisim;
                set => soyisim = value;
            }
            public int OgrenciNo
            {
                get => ogrenciNo;
                set => ogrenciNo = value;
            }
            public int Sinif
            {
                get => sinif;
                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("Sınıf en az 1 olabilir.");
                        sinif = 1;
                    }
                    else
                        sinif = value;

                }
            }

            public Ogrenci()
            {

            }

            public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
            {
                Isim = isim;
                Soyisim = soyisim;
                OgrenciNo = ogrenciNo;
                Sinif = sinif;
            }

            public void OgrenciBilgileriniGetir()
            {
                Console.WriteLine("Öğrenci Adı      :{0}", this.Isim);
                Console.WriteLine("Öğrenci Soyadı      :{0}", this.Soyisim);
                Console.WriteLine("Öğrenci No      :{0}", this.OgrenciNo);
                Console.WriteLine("Öğrenci Sınıf      :{0}", this.Sinif);
            }

            public void SinifAtlat()
            {
                this.Sinif = this.Sinif + 1;
            }
            public void SinifDusur()
            {
                this.Sinif = this.Sinif - 1;
            }
        }
    }
}
