using System;

namespace _03_12_Find_Largest_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int a = int.MinValue;
            int b = int.MinValue;
            int c = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if(x > b)
                {
                    if (x > a)
                    {
                        c = b;
                        b = a;
                        a = x;
                    }
                    else
                    {
                        c = b;
                        b = x;
                    }
                }
                else
                {
                    c = x;
                }

            }

            Console.WriteLine($"{a}, {b} and {c}");
        }
    }
}
