using System;

namespace _02_08_Sort_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // calculation and output
            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
                else
                {
                    Console.WriteLine($"{a} {c} {b}");
                }
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
                else
                {
                    Console.WriteLine($"{b} {c} {a}");
                }
            }
            else
            {
                if (a >= b)
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }

        }
    }
}
