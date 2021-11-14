using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> TelefonNumarasi = new Dictionary<string, long>();

            TelefonNumarasi.Add("Ebru Arı", 5351231412);
            TelefonNumarasi.Add("Kasım Arcı", 5351231413);
            TelefonNumarasi.Add("Reyhan Agcı", 5351231414);
            TelefonNumarasi.Add("Ebru Adcı", 5351231415);
            TelefonNumarasi.Add("Kasım Atkı", 5351231416);

            Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz :) \r\n  *******************************************\r\n  (1) Yeni Numara Kaydetmek\r\n  (2) Varolan Numarayı Silmek\r\n  (3) Varolan Numarayı Güncelleme\r\n  (4) Rehberi Listelemek\r\n  (5) Rehberde Arama Yapmak﻿");
            int deger = Convert.ToInt32(Console.ReadLine());
            if (deger == 1)
            {
                Console.WriteLine(" Lütfen isim giriniz: ");
                string gelenAd = Console.ReadLine();
                Console.WriteLine(" Lütfen soyisim giriniz: ");
                string gelenSoyad = Console.ReadLine();
                Console.WriteLine(" Lütfen isim giriniz: ");
                long gelenNumara = Convert.ToInt64(Console.ReadLine());

                TelefonNumarasi.Add((gelenAd + " " + gelenSoyad), gelenNumara);
            }

            if (deger == 2)
            {
                Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string search = Console.ReadLine();
                if (TelefonNumarasi.ContainsKey(search))
                {
                    TelefonNumarasi.Remove(search);
                    Console.WriteLine("{0} Silindi", search);
                }
                else
                {
                    Console.WriteLine("   Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\r\n  * Silmeyi sonlandırmak için : (1)\r\n  * Yeniden denemek için      : (2)");
                    int gelenSilmeDegeri = Convert.ToInt32(Console.ReadLine());
                    if (gelenSilmeDegeri == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                    }

                    if (gelenSilmeDegeri == 2)
                    {
                        Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        string search2 = Console.ReadLine();
                        if (TelefonNumarasi.ContainsKey(search2))
                        {
                            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                            string sonuc = Console.ReadLine();
                            if (sonuc == "y")
                            {
                                TelefonNumarasi.Remove((search2));
                                Console.WriteLine("{0} Silindi", search2);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Kayıt bulunamadı.");
                        }
                    }
                }


            }

            if (deger == 3)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string search = Console.ReadLine();
                if (!TelefonNumarasi.ContainsKey(search))
                {
                    Console.WriteLine("  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\r\n * Güncellemeyi sonlandırmak için    : (1)\r\n * Yeniden denemek için              : (2)");
                    int sonuc = Convert.ToInt32(Console.ReadLine());
                    if (sonuc == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                    }

                    if (sonuc == 2)
                    {
                        Console.WriteLine("Yeniden deneniyor.");
                    }
                }
                else
                {
                    TelefonNumarasi.Remove((search));
                    Console.WriteLine("İsim ve soyisim giriniz.");
                    string isimSoyisim = Console.ReadLine();
                    Console.WriteLine("Telefon numarasını giriniz.");
                    long Numara = Convert.ToInt64(Console.ReadLine());
                    TelefonNumarasi.Add(isimSoyisim, Numara);
                    Console.WriteLine("Güncelleme tamamlandı.");
                }

            }

            if (deger == 4)
            {
                foreach (KeyValuePair<string, long> i in TelefonNumarasi)
                {
                    Console.WriteLine("Telefon Rehberi\r\n**********************************************" +
                         "\r\nisim: {0}\r\nTelefon Numarası: {1}\r\n  ", i.Key, i.Value);
                }
            }
            Dictionary<string, long> TelefonNumarasiSearch = new Dictionary<string, long>();
            if (deger == 5)
            {
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\r\n " +
                                  "**********************************************\r\n \r\n " +
                                  "İsim veya soyisime göre arama yapmak için: (1)\r\n" +
                                  " Telefon numarasına göre arama yapmak için: (2)");
                int sonuc = Convert.ToInt32(Console.ReadLine());
                if (sonuc == 1)
                {
                    Console.WriteLine("İsim veya soyisim giriniz.");
                    string search = Console.ReadLine().ToLower();


                    foreach (KeyValuePair<string, long> i in TelefonNumarasi)
                    {
                        if (i.Key.ToLower().Contains(search))
                        {
                            TelefonNumarasiSearch.Add(i.Key, i.Value);
                        }
                    }
                    foreach (var item in TelefonNumarasiSearch)
                    {
                        Console.WriteLine(" Arama Sonuçlarınız:\r\n**********************************************" +
                            "\r\nisim: {0}\r\nTelefon Numarası: {1}\r\n  ", item.Key, item.Value);

                    }

                }
                if (sonuc == 2)
                {
                    Console.WriteLine("Telefon numarası giriniz.");
                    long search2 = Convert.ToInt64(Console.ReadLine());


                    foreach (KeyValuePair<string, long> j in TelefonNumarasi)
                    {
                        if (j.Value == search2)
                        {
                            TelefonNumarasiSearch.Add(j.Key, j.Value);
                        }

                    }
                    if (TelefonNumarasiSearch.Count == 0)
                    {
                        Console.WriteLine("Girmiş olduğunuz numara eşleşmiyor.");
                    }
                    foreach (var item in TelefonNumarasiSearch)
                    {
                        Console.WriteLine(" Arama Sonuçlarınız:\r\n**********************************************" +
                            "\r\nisim: {0}\r\nTelefon Numarası: {1}\r\n  ", item.Key, item.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Kayıt bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız.");
            }


        }
    }
}

