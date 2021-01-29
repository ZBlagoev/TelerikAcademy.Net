using System;

namespace _03_01_Numbers_1_N
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
