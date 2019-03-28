using System;

namespace _1A {
    class Student {
        string fname, lname, usn, address;
        int[,] tests = new int[3,3] {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };

        public Student() {
            Console.WriteLine("Enter Student's firstname, lastname, usn and Address");
            fname = Console.ReadLine();
            lname = Console.ReadLine();
            usn = Console.ReadLine();
            address = Console.ReadLine();
            for (int i=0; i<tests.GetLength(0); i++) {
                Console.WriteLine("Enter Marks for test {0}",i+1);
                for (int j=0; j<tests.GetLength(1); j++) {
                    tests[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void displayBestAverageScores() {
            for (int i=0; i<tests.GetLength(0); i++) {
                float average = 0;
                int smallest = 99999;
                for (int j=0; j<tests.GetLength(1); j++) {
                    if (tests[i,j]<smallest) {
                        smallest = tests[i,j];
                    }
                }
                for (int j=0; j<tests.GetLength(1); j++) {
                    if (tests[i,j]!=smallest) {
                        average += (float) tests[i,j];
                    }
                }
                average /= 2;
                Console.WriteLine("The Average of Best Scores for test {0} = {1}", i+1, average);
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            Student s = new Student();
            s.displayBestAverageScores();
        }
    }
}
