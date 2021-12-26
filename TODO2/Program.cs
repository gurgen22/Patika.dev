using System;
using System.Collections.Generic;

namespace TODO2
{
    class Program
    {
        static Person person = null;
        static List<Person> personList = new List<Person>();
        static Card card = null;

        static void Main(string[] args)
        {

            personList.Add(new Person(1, "Isim", "Soyısım", new Card("denemetitle", "denemecontents", "Hakan Güngör", size.L), LineEnum.Todo));
            personList.Add(new Person(2, "Isim", "Soyısım", new Card("deneme", "denemecontents", "Aslı Güngör", size.L), LineEnum.Todo));
            for (; ; )
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:");
                Console.WriteLine("1-)Board Listelemek\n2-)Board'a Kart Eklemek\n3-)Board'dan kart Silmek\n4-)Kart Taşımak");
                string choice = Console.ReadLine();
                switch (choice)
                {

                    case "1":
                        GetTodo();
                        GetInProgress();
                        GetDone();
                        break;

                    case "2":
                        newPerson();
                        break;

                    case "3":
                        CardDelete();
                        break;

                    case "4":
                        CardMove();
                        break;
                }
            }
        }
        static void GetTodo()
        {
            Console.WriteLine("\tTODO Line\n");
            var resList = personList.FindAll(person => person.line.Equals(LineEnum.Todo));
            resList.ForEach(person => Console.WriteLine(person.ToString() + "\n-----"));
        }
        static void GetInProgress()
        {
            Console.WriteLine("\tIN PROGRESS Line\n");
            var resList = personList.FindAll(person => person.line.Equals(LineEnum.InProgress));
            resList.ForEach(person => Console.WriteLine(person.ToString() + "\n-----"));
        }

        static void GetDone()
        {
            Console.WriteLine("\tDONE Line\n");
            var resList = personList.FindAll(person => person.line.Equals(LineEnum.Done));
            resList.ForEach(person => Console.WriteLine(person.ToString() + "\n-----"));
        }
        static void newPerson()
        {

            Person res = new();
            Card card = new();
            Console.WriteLine("Lütfen ID Giriniz:");

            var ID = Console.ReadLine();
            res.id = Int32.Parse(ID);

            Console.WriteLine("Lütfen İsim Giriniz:");
            res.name = Console.ReadLine();

            Console.WriteLine("Lütfen Soyİsim Giriniz:");
            res.surname = Console.ReadLine();

            Console.WriteLine("Lütfen Başlık Giriniz:");
            card.title = Console.ReadLine();


            Console.WriteLine("Lütfen İçerik Giriniz:");
            card.contents = Console.ReadLine();

            Console.WriteLine("Lütfen Büyüklük Giriniz XS(1),S(2),M(3),L(4),XL(5):");
            card.size = (size)Convert.ToInt16(Console.ReadLine());

            res.line = (short)LineEnum.Todo;
            res.cards.Add(card);
           
            personList.Add(res);


        }
        static void CardDelete()
        {
            Console.WriteLine("Lütfen Başlık Giriniz:");
            string title = Console.ReadLine();
            //personList.Find(person => person.cards.Equals(title)).title = null;
            _ = person.cards.Find(x => x.title.Equals(title))?.title ?? "";
            
        }
        static void CardMove()
        {
            Console.WriteLine("Lütfen Başlık Giriniz:");
            string title = Console.ReadLine();

            Console.WriteLine("Lütfen Taşınacak Line Seciniz TODO(1) IN PROGRESS(2) DONE(3):");
            LineEnum line = (LineEnum)Convert.ToInt16(Console.ReadLine());

           // personList.Find(person => person.cards.Find.Equtitle)).line = (short)line;
           
        }
    }
}


