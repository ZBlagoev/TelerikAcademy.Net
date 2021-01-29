using System;
using System.Linq;
using System.Collections.Generic;

namespace _04_10_Array_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            List<int> output = new List<int>();

            // calculation
            for (int i = 1; i <= input.Length; i++)
            {
                int counter = 0;
                
                for (int j = 0; j < input.Length; j++)
                {
                    if(input[j] == i)
                    {
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    output.Add(i);
                }
            }

            // output
            Console.WriteLine(string.Join(",",output));

        }
    }
}
