using System;

namespace _01_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            // calculation
            sum = n * (n + 1) / 2;

            // output
            Console.WriteLine(sum);

        }
    }
}
