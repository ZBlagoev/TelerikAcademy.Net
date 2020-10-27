using System;

namespace _07._PyramidWithForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); // 3

            for (int currentRow = 1; currentRow <= num; currentRow++)
            {
                for (int starCount = 0; starCount < currentRow; starCount++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
