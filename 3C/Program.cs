using System;

namespace _3C
{
    class Program
    {
        public enum DayofWeek {    
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("VCS Lab is on {0}", DayofWeek.Monday);
            Console.WriteLine("SEO Lab is on {0}", DayofWeek.Thursday);
            Console.WriteLine("CDN Lab is on {0}", DayofWeek.Friday);
            Console.WriteLine("CNS Lab is on {0}", DayofWeek.Saturday);
        }
    }
}
