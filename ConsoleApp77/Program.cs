using System;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}");

            Console.ReadKey(false);
            Console.WriteLine("Goodbye...");
        }
    }
}
