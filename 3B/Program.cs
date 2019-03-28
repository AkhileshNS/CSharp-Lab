using System;

namespace _3B
{
    class Person {
        String name;
        String[] phonenos;

        public Person() {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("How many phone numbers do you have?");
            int count = Convert.ToInt32(Console.ReadLine());
            phonenos = new String[count];
            for (int i=0; i<count; i++) {
                Console.WriteLine("Enter {0} Phone Number", i+1);
                phonenos[i] = Console.ReadLine();
            }
        }

        public void display() {
            Console.WriteLine("\n\nName: {0}\nPhone.Nos: {1}", name, String.Join(",", phonenos));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            for (int i=0; i<people.Length; i++) {
                people[i] = new Person();
            }
            for (int i=0; i<people.Length; i++) {
                people[i].display();
            }
        }
    }
}
