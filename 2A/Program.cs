using System;

namespace _2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday (Day, Month and Year): ");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            DateTime today = DateTime.Now;

            if (DateTime.Compare(birthday ,today)>0 
            || (birthday.Year+100)<(today.Year+100)) {
                Console.WriteLine("Thats impossible");
            } else if (birthday.Day==today.Day && birthday.Month==today.Month 
            && birthday.Year==today.Year ) {
                Console.WriteLine("Happy Birthday I guess. You are one smart baby.");
            } else {
                Console.WriteLine("You were born on {0}/{1}/{2}", birthday.Day, birthday.Month, birthday.Year);
            }
        }
    }
}
