using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Koleksiyonlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Asalsayilar = new ArrayList();
            ArrayList AsalOlmayansayilar = new ArrayList();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz.", i);
                if (i <= 0 || typeof(int) != i.GetType())
                {
                    Console.WriteLine("0'dan büyük tam sayı giriniz.");
                }
                else
                {
                    int gelenDeger = Convert.ToInt32(Console.ReadLine());
                    if (gelenDeger == 1)
                    {
                        AsalOlmayansayilar.Add(gelenDeger);
                    }

                    if (gelenDeger == 2)
                    {
                        Asalsayilar.Add(gelenDeger);
                    }
                    else
                    {
                        for (int j = 2; j < gelenDeger; j++)
                        {
                            if (gelenDeger % j == 0)
                            {
                                AsalOlmayansayilar.Add(gelenDeger);
                                break;

                            }
                            else
                            {
                                Asalsayilar.Add(gelenDeger);
                            }
                        }
                    }
                }

            }

            Asalsayilar.Sort();
            AsalOlmayansayilar.Sort();
            Asalsayilar.Reverse();
            AsalOlmayansayilar.Reverse();
            Console.WriteLine("Asal Olmayan Sayılar");
            foreach (var k in AsalOlmayansayilar)
                Console.WriteLine(k);

            Console.WriteLine("Asal Sayılar");
            foreach (var l in Asalsayilar)
                Console.WriteLine(l);

            int ElemanSayisi1 = Asalsayilar.Count;
            int ElemanSayisi2 = AsalOlmayansayilar.Count;
            Console.WriteLine("Asal sayılar elaman sayısı: " + ElemanSayisi1);
            Console.WriteLine("Asal Olmayan sayılar elaman sayısı: " + ElemanSayisi2);

            int toplam1 = 0;
            foreach (int item in Asalsayilar)
            {
                toplam1 = toplam1 + item;
            }

            int Ortalama1 = toplam1 / ElemanSayisi1;

            Console.WriteLine("Asal Sayılar ortalaması: "+Ortalama1);
            int toplam2 = 0;
            foreach (int item in AsalOlmayansayilar)
            {
                toplam2 = toplam2 + item;
            }

            int Ortalama2 = toplam2 / ElemanSayisi2;

            Console.WriteLine("Asal Olmayan Sayılar ortalaması: " + Ortalama2);


        }
    }
}
