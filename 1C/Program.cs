using System;

namespace _1C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion.ToString());
            Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);
            Console.WriteLine("UserName: {0}", Environment.UserName);
        }
    }
}
