using System;

namespace _3A
{
    class Program
    {
        static void display(int[] intArr) {
            if (intArr.Length==0) {
                Console.WriteLine("");
            }
            foreach (int i in intArr) {
                Console.WriteLine(i);
            }
        }

        static void display(Object[] objArr) {
            if (objArr.Length==0) {
                Console.WriteLine("");
            }
            foreach (Object obj in objArr) {
                Console.WriteLine(obj);
            }
        }

        static void Main(string[] args)
        {
            int[] intArr = {1, 2, 3, 4, 5};
            Object[] objArr = {1, "2", '3', 4.2, true};

            display(new int[0]);
            display(intArr);
            display(objArr); 
        }
    }
}
