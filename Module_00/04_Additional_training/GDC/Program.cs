using System;
using System.Linq;

namespace GDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            GCD(numbers[0], numbers[1]);
        }

        static void GCD(int a, int b)
        {
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            Console.WriteLine(a);
        }
    }
}
