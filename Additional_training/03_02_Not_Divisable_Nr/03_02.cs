using System;

namespace _03_02_Not_Divisable_Nr
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                if (!(i % 3 == 0 || i % 7 == 0))
                {
                    Console.Write($"{i} ");
                }
            }


        }
    }
}
