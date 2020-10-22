using System;

namespace Problem_7._Sum_of_greatest_and_smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());
            double smallest = Math.Min(numOne, Math.Min(numTwo, numThree));
            double greatest = Math.Max(numOne, Math.Max(numTwo, numThree));
            Console.WriteLine(smallest + greatest);
        }
    }
}
//Problem 7. Sum of greatest and smallest
//Write a program that enters 3 numbers(each number will be on a separate/new line), calculates and prints the sum of the greatest and smallest of them.
//Examples:
//numbers     sum
//1 2 3	      4
//10 10 10	  20