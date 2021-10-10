using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Example
{
    public class Modules
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public int tableNo { get; set; }
    }
    public enum Translation
    {
        English = 1,
        Russian = 2,
        French = 4,
        German = 5
    }

    public static void Main()
    {
        //Modules modules = new();
        //string[] trans = Enum.GetNames(typeof(Translation));

        //var list = new List<KeyValuePair<string, int>>();
    }
    public List<KeyValuePair<string, int>> GetEnumList<Translation>()
    {
        Modules modules = new();
        var list = new List<KeyValuePair<string, int>>();
        foreach (var e in Enum.GetValues(typeof(Translation)))
        {
            list.Add(new KeyValuePair<string, int>(e.ToString(), (int)e));
        }
        return list;


      
    }
}