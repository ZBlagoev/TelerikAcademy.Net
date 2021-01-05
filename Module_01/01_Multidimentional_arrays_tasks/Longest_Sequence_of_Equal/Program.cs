using System;

namespace Longest_Sequence_of_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // calculation
            int counter = 1;
            int maximum = 1;

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > maximum)
                    {
                        maximum = counter;
                    }
                    counter = 1;
                }
            }

            if (counter > maximum)
            {
                maximum = counter;
            }

            // output
            Console.WriteLine(maximum);


        }
    }
}
