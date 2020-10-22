using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Forth Number");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fifth Number");
            int e = int.Parse(Console.ReadLine());

            int sumAll = a + b + c + d + e;

            Console.WriteLine("Sum = " + sumAll); 


        }
    }
}
