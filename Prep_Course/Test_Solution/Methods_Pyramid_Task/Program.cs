using System;
using System.Data;

namespace Methods_Pyramid_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());


            PrintTriangle(count);
        }

        // method combining both parts of the triangle
        static void PrintTriangle(int n)
        {
            PrintTopPart(n);
            PrintBottomPart(n);
        }

        // building top part of triangle
        static void PrintTopPart(int n)
        {
            for (int counter = 1; counter <= n; counter++)
            {
                for (int i = 1; i <= counter; i++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }

        // building bottom part of triangle
        static void PrintBottomPart(int n)
        {
            for (int counter = n; counter > 1; counter--)
            {
                for (int i = 1; i < counter; i++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }

    }
}
