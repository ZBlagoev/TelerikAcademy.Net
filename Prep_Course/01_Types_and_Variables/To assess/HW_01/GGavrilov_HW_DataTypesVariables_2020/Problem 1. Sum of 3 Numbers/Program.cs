using System;

namespace Problem_1._Sum_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = a + b + c;
            Console.WriteLine(result);
        }
    }
}
//Write a program that reads 3 int numbers from the console and prints their sum.

//Examples:
// a  b  c   sum
// 3  4	 11	 18
//-2  0	 3	 1