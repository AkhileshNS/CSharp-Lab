using System;
using System.Collections.Generic;

namespace _5B
{
    class Program
    {
        class phonebook
        {
            private Dictionary<string, long> book = new Dictionary<string, long>();
            public phonebook()
            {
                book["John"] = 123456;
                book["Dave"] = 234567;
                book["Bill"] = 345678;
                book["Jack"] = 456789;
                book["Jill"] = 567890;
            }
            public long this[string name]
            {
                get { return book[name]; }
                set { book[name] = value; }
            }
            public string this[long number]
            {
                get
                {
                    foreach (KeyValuePair<string, long> pair in book)
                    {
                        if (pair.Value == number)
                            return pair.Key;
                    }
                    return "Number not found";
                }
            }
            public void clear()
            {
                book.Clear();
            }
            public int Count
            {
                get { return book.Count; }
            }
            

        }
        static void Main(string[] args)
        {
            phonebook pb = new phonebook();


            Console.WriteLine("Jill's phone number : {0}", pb["Jill"]);
            Console.WriteLine("Person with ph. no. 234567 : {0}", pb[234567]);
            Console.WriteLine("Person with ph. no. 111111 : {0}", pb[111111]);
            Console.ReadLine();

        }
    }
}


//OUTPUT
// Jill's phone number : 567890
// Person with ph. no. 234567 : Dave
// Person with ph. no. 111111 : Number not found
