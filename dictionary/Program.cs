using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(1,"Ayşe Yılmaz");
            kullanıcılar.Add(11,"Ahmet Yılmaz");
            kullanıcılar.Add(18,"Ada Coşar");
            kullanıcılar.Add(21,"Özcan Coşar");

            //Erişim

            Console.WriteLine(kullanıcılar[11]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(kullanıcılar.Count);

            //contains
            Console.WriteLine(kullanıcılar.ContainsKey(11));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            Console.WriteLine(kullanıcılar.Remove(11));
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
