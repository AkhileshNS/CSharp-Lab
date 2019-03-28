using System;
using System.Collections;

namespace _5A
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nums = new ArrayList();
            nums.AddRange(new string[] { "Zero", "One", "Two", "Three", "Four", "Six", "Seven", "Eight", "Nine" });
            Console.WriteLine("Current List :");
            foreach (string num in nums)
                Console.Write(num + " ");
            Console.WriteLine("\nLength of ArrayList : {0}", nums.Count);
            nums.Insert(5, "Five");
            Console.WriteLine("\nAdded \"Five\" at position 5 :\nCurrent List :");
            foreach (string num in nums)
                Console.Write(num + " ");
            nums.Remove("Seven");
            Console.WriteLine("\n\nRemoved \"Seven\" :\nCurrent List :");
            foreach (string num in nums)
                Console.Write(num + " ");
            nums.RemoveAt(6);
            Console.WriteLine("\n\nRemoved at position 6 :\nCurrent List :");
            foreach (string num in nums)
                Console.Write(num + " ");
            nums.RemoveRange(1, 3);
            Console.WriteLine("\n\nRemoved from 1 to 3 : \nCurrent List :");
            foreach (string num in nums)
                Console.Write(num + " ");
            nums.Sort();
            Console.WriteLine("\n\nSorted the list :\nCurrent List :");
            foreach (string num in nums)
                Console.Write(num + " ");
            nums.Clear();
            Console.WriteLine("\n\nCleared the list :\nCurrent length of ArrayList : {0}", nums.Count);
            Console.ReadLine();
        }
    }
}

//OUTPUT
// Current List :
// Zero One Two Three Four Six Seven Eight Nine
// Length of ArrayList : 9

// Added "Five" at position 5 :
// Current List :
// Zero One Two Three Four Five Six Seven Eight Nine

// Removed "Seven" :
// Current List :
// Zero One Two Three Four Five Six Eight Nine

// Removed at position 6 :
// Current List :
// Zero One Two Three Four Five Eight Nine

// Removed from 1 to 3 :
// Current List :
// Zero Four Five Eight Nine

// Sorted the list :
// Current List :
// Eight Five Four Nine Zero

// Cleared the list :
// Current length of ArrayList : 0
