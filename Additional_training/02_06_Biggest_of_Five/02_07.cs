using System;

namespace _02_06_Biggest_of_Five
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double max = double.MinValue;

            for (int i = 0; i < 5; i++)
            {
                double n = double.Parse(Console.ReadLine());

                if (n >= max)
                {
                    max = n;
                }
            }

            // output
            Console.WriteLine(max);
        }
    }
}
