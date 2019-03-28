using System;

namespace _4B {
    interface Payable {
        double retrieveAmountDue();
        void addAmountDue(double amount);
        string paymentAddress();
    }

    class Person {
        string name;
        public Person() {
            Console.WriteLine("Enter the Person's name: ");
            name = Console.ReadLine();
        }
    }

    class Employee: Person, Payable {
        double salary;
        string mailAddress;
        protected internal double amountDue = 0;
        public Employee() {
            Console.WriteLine("Enter the Employee's salary and mailAddress: ");
            salary = Convert.ToDouble(Console.ReadLine());
            mailAddress = Console.ReadLine();
        }
        public double retrieveAmountDue() {
            return amountDue;
        }
        public void addAmountDue(double amount) {
            amountDue += amount;
        }
        public string paymentAddress() {
            return mailAddress;
        }
    }

    class Program {
        static void Main(string[] args) {
            Employee e = new Employee();
            Console.WriteLine("Enter the amount due:");
            e.addAmountDue(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("The new Amount Due is {0}", e.retrieveAmountDue());
            Console.WriteLine("The mailing address is {0}", e.paymentAddress());
        }
    }
}
