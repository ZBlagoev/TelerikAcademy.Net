using System;

namespace _03._PrintUntilCertainInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "quit")
            {
                Console.WriteLine($"User entered {command}");
                command = Console.ReadLine();
            }
        }
    }
}
