using System;
using System.Collections.Generic;

namespace _5D
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            Console.WriteLine("Current stack : ");
            foreach (int element in s)
            {
                Console.Write("{0} ", element);
            }

            Console.WriteLine("\n\nFirst element to be poped : {0}", s.Pop());
            Console.WriteLine("Current stack : ");
            foreach(int element in s)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine("\n\nDoes Stack Contain 4? : {0}", s.Contains(4));
            Console.WriteLine("\nTop of Stack : {0}", s.Peek());
            Console.WriteLine("Current Stack : ");
            foreach (int element in s)
            {
                Console.Write("{0} ", element);
            }
            s.Clear();
            Console.WriteLine("\n\nStack cleared :\nCurrent Length of Stack : {0}", s.Count);
            Console.ReadLine();
        }
    }
}


//OUTPUT
// Current stack :
// 5 4 3 2 1

// First element to be poped : 5
// Current stack :
// 4 3 2 1

// Does Stack Contain 4? : True

// Top of Stack : 4
// Current Stack :
// 4 3 2 1

// Stack cleared :
// Current Length of Stack : 0
