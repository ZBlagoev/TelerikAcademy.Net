using System;

namespace Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            string top = "";
            string bottom = "";

            // calculation

                // produce top band
            for (int i = 0; i < 2 * n; i++)
            {
                if (i < n)
                {
                    top += ".";
                }
                else
                {
                    top += "*";
                }
            }

            // produce bottom band
            for (int i = 0; i < 2 * n; i++)
            {
                bottom += "*";
            }


            // output
            Console.WriteLine(top);
            for (int i = 1; i <= n - 2 + 1; i++)
            {
                for (int j = 0; j < 2 * n; j++)
                {
                    if ((j == n - i) || (j == 2 * n - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine(bottom);

        }
    }
}
