using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // a   b    c  sum
            // 3   4   11  18
            //- 2  0   3   1
            // 5   4   20  29

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Sum = ");
            Console.WriteLine(a + b + c);

        }
    }
}