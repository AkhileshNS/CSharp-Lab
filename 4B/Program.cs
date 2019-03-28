using System;

namespace _4B
{
    interface Payable
    {
        double amount { get; set; } //Property... not a member variable!
        string PaymentAddress { get; set; }
        double RetrieveAmountDue();
        void AddToAmountDue(double extra);
    }

    class Person
    {
        public string name;
        public Person()
        {
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
        }
        public void displayPerson()
        {
            Console.WriteLine("Name : {0}", name);
        }
    }

    class Employee : Person, Payable
    {
        double salary;
        string MailingAddress;

        public double amount { get; set; }
        public string PaymentAddress { get; set; }

        public Employee() : base()
        {
            Console.Write("Enter Salary : ");
            salary = double.Parse(Console.ReadLine());
            Console.Write("Enter mailing address : ");
            MailingAddress = Console.ReadLine();
            PaymentAddress = MailingAddress;
            amount = 0;
        }
        public double RetrieveAmountDue()
        {
            return amount;
        }
        public void AddToAmountDue(double extra)
        {
            amount = amount + extra;
        }
        public void display()
        {
            displayPerson();
            Console.WriteLine("Salary : {0}\nMailing/Payment address : {1}\nAmount Due : {2}", salary, MailingAddress, amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.AddToAmountDue(5000);
            emp.display();
            Console.Read();

        }
    }
}

//OUTPUT
// Enter Name : Anirban Ghosh
// Enter Salary : 56000
// Enter mailing address : FD-74, HAL, Old Madras Road, Bangalore
// Name : Anirban Ghosh
// Salary : 56000
// Mailing/Payment address : FD-74, HAL, Old Madras Road, Bangalore
// Amount Due : 5000
