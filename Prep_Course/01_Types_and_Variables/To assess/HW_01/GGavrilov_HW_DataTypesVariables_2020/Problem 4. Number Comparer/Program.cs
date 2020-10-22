using System;

namespace Problem_4._Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double greaterNum = Math.Max(firstNum, secondNum);
            Console.WriteLine(greaterNum);
        }
    }
}

//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.Try to implement this without if statements.

//Examples:
// a    b     greater
// 5	 6	     6
// 10	 5	     10
// 0	 0	     0
//-5	 -2	    -2