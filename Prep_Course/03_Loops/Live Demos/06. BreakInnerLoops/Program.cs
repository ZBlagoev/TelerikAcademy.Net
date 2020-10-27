using System;

namespace _06._BreakInnerLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= num)
            {
                int stars = 0;

                while (true)
                {
                    if (stars == counter)
                    {
                        break;
                    }
                    stars++;
                    Console.Write("*");
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
