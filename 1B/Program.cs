using System;

/* 1.a) Develop a C# Program with the following requirements: 
 * Changing the Title of the Console
 * Changing Foreground and Background color
 * Understanding Command Line Arguments
 * Checking Keyboard Properties
 */

namespace _1B {

    class Program {

        static void Main(string[] args) {
            Employee e = new Employee();

            e.setName("AkhileshNS");
            e.setId(1);
            e.setSalary(1000000);

            Console.WriteLine("\nName: {0}\nId: {1}\nSalary: {2}", e.getName(), e.getId(), e.getSalary());
        }

    }

}
