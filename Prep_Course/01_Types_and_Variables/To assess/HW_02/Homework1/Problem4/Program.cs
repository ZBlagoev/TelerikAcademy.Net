using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program that compares two integers and returns the bigger of both:\n");

            Console.WriteLine("Please input number #1:");
            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);
            Console.WriteLine("Please input number #2:");
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);

            Console.WriteLine("\nThe bigger of the two numbers is: " + Math.Max(firstNumber, secondNumber));


        }
    }
}
