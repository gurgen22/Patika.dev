using System;
using System.Collections;

namespace Koleksiyonlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList EnBuyuk = new ArrayList();
            ArrayList Enkucuk = new ArrayList();
            ArrayList list = new ArrayList();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz.", i);
                int gelenDeger = Convert.ToInt32(Console.ReadLine());
                list.Add(gelenDeger);
            }

            list.Sort();
            int enBuyukSayilar;




            enBuyukSayilar = (int)list[19];
            EnBuyuk.Add(enBuyukSayilar);
            list.RemoveAt(19);

            enBuyukSayilar = (int)list[18];
            EnBuyuk.Add(enBuyukSayilar);
            list.RemoveAt(18);

            enBuyukSayilar = (int)list[17];
            EnBuyuk.Add(enBuyukSayilar);
            list.RemoveAt(17);
            int toplam1 = 0;

            foreach (int VARIABLE in EnBuyuk)
            {
                toplam1 = toplam1 + VARIABLE;
            }

            Console.WriteLine("En Büyük ortalaması: " + toplam1 / 3);


            int enKucukSayilar;
            enKucukSayilar = (int)list[0];
            Enkucuk.Add(enKucukSayilar);
            list.RemoveAt(0);

            enKucukSayilar = (int)list[0];
            Enkucuk.Add(enKucukSayilar);
            list.RemoveAt(0);

            enKucukSayilar = (int)list[0];
            Enkucuk.Add(enKucukSayilar);
            list.RemoveAt(0);

          
            int toplam2 = 0;

            foreach (int VARIABLE in Enkucuk)
            {
                toplam2 = toplam2 + VARIABLE;
            }

            Console.WriteLine("En küçük ortalaması: " + toplam2 / 3);
        }
    }
}
