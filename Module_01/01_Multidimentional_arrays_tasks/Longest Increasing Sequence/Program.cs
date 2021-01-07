using System;

namespace Longest_Increasing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = MakeArray(int.Parse(Console.ReadLine()));


            MaximumSequence(input);

        }

        static int[] MakeArray(int n)
        {
            int[] input = new int[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            return input;
        }


        static void MaximumSequence(int[] input)
        {
            int counter = 1;
            int max = 1;

            // calculation
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] < input[i])
                {
                    counter++;
                }
                else
                {
                    if (max < counter)
                    {
                        max = counter;
                    }

                    counter = 1;
                }
            }

            // output
            Console.WriteLine(max);
        }
    }
}
