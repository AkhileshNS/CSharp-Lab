using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1.b) Investigate the content of .NET framework by creating a class employee with members:
 * name, id and salary. Create appropriate Mutator and Accessor, also explore the output using
 * csc.exe
 */

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
}
