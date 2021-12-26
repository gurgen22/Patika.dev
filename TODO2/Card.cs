using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO2
{
    public class Card
    {
        public int id { get; set; } = 10;
        public string title { get; set; } = "";
        public string contents { get; set; } = "";
        public string appointedPerson { get; set; } = "";
        public size size { get; set; } = 0;
        //string title = string.Empty;
        //string contents = string.Empty;
        //size size = 0;

        //public string Title
        //{
        //    get { return this.title; }
        //    set { this.title = value; }
        //}
        //public string Contents
        //{
        //    get { return this.contents; }
        //    set { this.contents = value; }
        //}
        //public size Size
        //{
        //    get { return this.size; }
        //    set { this.size = value; }
        //}
        public Card(string _title, string _contents, string _appointedPerson, size _size)
        {
            this.title = _title;
            this.contents = _contents;
            this.appointedPerson = _appointedPerson;
            this.size = _size;
        }
        public Card()
        {

        }
    }
    public enum size
    {
        XS,
        S,
        M,
        L,
        XL
    }
    public enum LineEnum
    {
        Todo = 1,
        InProgress = 2,
        Done = 3
    }
}
