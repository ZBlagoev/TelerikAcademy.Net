using System;

namespace Trailing_Zeros_in_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int zeroes = 0;

            // calculation
            for (int i = 5; n / i >= 1; i *= 5)
            {
                zeroes += n / i;
            }
            
            Console.WriteLine(zeroes);
        }
    }
}
