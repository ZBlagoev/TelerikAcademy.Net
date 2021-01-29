using System;

namespace _03_09_Matrix_Nr
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n + i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
