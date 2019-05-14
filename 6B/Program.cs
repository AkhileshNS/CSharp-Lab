using System;

namespace _6B
{
    class Name {
        public string firstName;
        public string lastName;
    }

    class Program
    {
        delegate bool compare(Name n1, Name n2);

        public static bool nameComparer(Name n1, Name n2) {
            return n1.firstName.Equals(n2.firstName) && n1.lastName.Equals(n2.lastName); 
        }

        static void Main(string[] args)
        {
            Name[] names = new Name[5] {
                new Name() {firstName = "Akhilesh", lastName = "NS"},
                new Name() {firstName = "Akhilesh", lastName = "NS"},
                new Name() {firstName = "Aniruddha", lastName = "MN"},
                new Name() {firstName = "Anirban", lastName = "G"},
                new Name() {firstName = "Anirban", lastName = "D"}, 
            };

            compare Compare = new compare(nameComparer);
            Console.WriteLine(Compare(names[0], names[1]));
            Console.WriteLine(Compare(names[2], names[3]));
            Console.WriteLine(Compare(names[3], names[4]));

        }
    }
}
