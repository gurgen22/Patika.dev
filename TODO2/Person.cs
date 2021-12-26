using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO2
{
    public class Person 
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public short line { get; set; }
        public List<Card> cards { get; set; }

        public Person(int _id, string _name, string _surname, Card _card = null, LineEnum _line = 0)
        {
            this.id = _id;
            this.name = _name;
            this.surname = surname;
            this.line = (short)_line;
        }
        public Person()
        {

        }

        //public override string ToString()
        //{
        //    return $"Title: {Card.title}\nİçerik: {this.card.contents}\nAtananKişi: {this.firstName} {this.lastName}\nBüyüklük: {this.card.size}";
        //}
    }
}
