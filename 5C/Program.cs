using System;
using System.Collections.Generic;

namespace _5C
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            Console.WriteLine("First element to be dequeued : {0}", q.Dequeue());
            Console.WriteLine("Current queue : ");
            foreach(int element in q)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine("\n\nDoes Queue Contain 4? : {0}", q.Contains(4));
            Console.WriteLine("\nTop of queue : {0}", q.Peek());
            Console.WriteLine("Current queue : ");
            foreach (int element in q)
            {
                Console.Write("{0} ", element);
            }
            q.Clear();
            Console.WriteLine("\n\nQueue cleared :\nCurrent Length of Queue : {0}", q.Count);
            Console.ReadLine();
        }
    }
}

//OUTPUT
// First element to be dequeued : 1
// Current queue :
// 2 3 4 5

// Does Queue Contain 4? : True

// Top of queue : 2
// Current queue :
// 2 3 4 5

// Queue cleared :
// Current Length of Queue : 0
