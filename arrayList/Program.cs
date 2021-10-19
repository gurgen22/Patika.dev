using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ayşe");
            list.Add(2);
            list.Add(true);
            list.Add('a');

            //içerisindeki verilere erişim  

            Console.WriteLine(list[1]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Add Range
            Console.WriteLine("****************** Add Range ******************");
            string[] renkler = {"kırmızı", "sarı", "turuncu"};
            List<int> sayilar = new List<int>() {1, 2, 3, 4, 5};
            list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

      

        }
    }
}
