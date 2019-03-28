using System;

namespace _1B {
    class Employee {
        String name;
        int id;
        float salary;

        public Employee() {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary: ");
            salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nName: {0}\nId: {1}\nSalary: {2}", name, id, salary);
        }

        public String getName() {return name;}
        public int getId() {return id;}
        public float getSalary() {return salary;}

        public void setName(String Name) {name = Name;}
        public void setId(int Id) {id = Id;}
        public void setSalary(float Salary) {salary = Salary;}
    }

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
