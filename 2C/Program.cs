using System;

namespace _2C
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;

            if (i.HasValue) {
                Console.WriteLine(i.Value);
            } else {
                Console.WriteLine("Null");
            }

            int? j = null;
            int k = j ?? 10;

            Console.WriteLine(j.HasValue);
            Console.WriteLine(k);
        }
    }
}
