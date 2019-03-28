using System;
using System.Text;

namespace _2B
{
    class Program
    {
        static bool compare(String s1, String s2) {
            if (s1.Length!=s2.Length) {
                return false;
            }

            for (int i=0; i<s1.Length; i++) {
                if (s1[i]!=s2[i]) {
                    return false;
                }
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            // Custom func: compare
            Console.WriteLine("\"{0}\"==\"{1}\" : {2}", "Hello", "Hello", compare("Hello","Hello"));
            Console.WriteLine("\"{0}\"==\"{1}\" : {2}", "Hello", "hello", compare("Hello","hello"));

            // Append, AppendLine, Replace, Insert, Clear
            StringBuilder sb = new StringBuilder("Hello World");
            Console.WriteLine(sb);

            Console.WriteLine(sb.Append("!!"));
            Console.WriteLine(sb.AppendLine("New World Order"));
            Console.WriteLine(sb.Replace(" ", "_"));
            Console.WriteLine(sb.Insert(0, "Welcome to "));
            Console.WriteLine(sb.Clear());
        }
    }
}
