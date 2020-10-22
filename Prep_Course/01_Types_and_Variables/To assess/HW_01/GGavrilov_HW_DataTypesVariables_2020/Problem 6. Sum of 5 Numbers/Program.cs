using System;

namespace Problem_6._Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());
            double numFour = double.Parse(Console.ReadLine());
            double numFive = double.Parse(Console.ReadLine());
            double sum = numOne + numTwo + numThree + numFour + numFive;
            Console.WriteLine(sum);
        }
    }
}
//Problem 6. Sum of 5 Numbers
//Write a program that enters 5 numbers(each number will be on a separate/new line), calculates and prints their sum.

//Examples:
//   numbers           sum
// 1 2 3 4 5	        15
// 10 10 10 10 10	    50