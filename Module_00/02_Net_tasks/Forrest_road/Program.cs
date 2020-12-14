using System;

namespace Forrest_road
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            ForrestPath(number);
        }

        static void ForrestPath(int number)
        {
            TopPart(number);
            BottomPart(number);
        }

        static void TopPart (int number)
        {
            int current = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (j == current)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
                current++;
            }
        }

        static void BottomPart (int number)
        {
            int current = number - 1;

            for (int i = 1; i < number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (j == current)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
                current--;
            }
        }
    }
}
