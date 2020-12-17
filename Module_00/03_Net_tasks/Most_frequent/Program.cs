using System;

namespace Most_frequent
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] input = new int[length];

            for (int i = 0; i < length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(MostFrequent(input));
        }


        static string MostFrequent(int[] input)
        {
            int mostN = 0;
            int currN;

            int mostFq = 1;
            int currFq = 1;

            Array.Sort(input);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currFq++;
                    currN = input[i];

                    if (currFq > mostFq)
                    {
                        mostFq = currFq;
                        mostN = currN;
                    }
                }
                else
                {
                    currFq = 1;
                    currN = 0;
                }
            }

            string result = $"{mostN} ({mostFq} times)";

            return result;
        }
    }
}
