using System;

namespace _1A {
    class Program {
        static void Main(string[] args) {
            // Changing the title of the console
            Console.Title = "Custom Title";

            // Foreground and Background color
            Console.ForegroundColor = ConsoleColor.Black;  
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Understanding Command Line Arguments (Reading and Writing)
            Console.WriteLine("Args: {0}", String.Join(",", args));

            // Formatting Command Line Arguments
            int i = 0;
            foreach (String arg in args) {
                Console.WriteLine("{0}) {1}", ++i, arg);
            }

            // Checking Keyboard Properties (CapsLocks & NumsLock- Enabled or Disabled.) 
            Console.WriteLine("Is Capslock Enabled: {0}", Console.CapsLock); 
            Console.WriteLine("Is Numlock Enabled: {0}", Console.NumberLock);
        }
    }
}
