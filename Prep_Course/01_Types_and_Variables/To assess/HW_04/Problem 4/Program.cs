using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a, b)); 

        }
    }
}
