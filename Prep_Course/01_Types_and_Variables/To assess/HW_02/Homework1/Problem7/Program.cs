using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program selects highest and lowest number of a 3-number input:\n");

            Console.WriteLine("Please input number #1:");
            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);
            Console.WriteLine("Please input number #2:");
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);
            Console.WriteLine("Please input number #3:");
            string c = Console.ReadLine();
            int thirdNumber = int.Parse(c);

            Console.WriteLine("\nLargest of three: " + Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)));
            Console.WriteLine("Lowest of three: " + Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber)));

        }
    }
}
