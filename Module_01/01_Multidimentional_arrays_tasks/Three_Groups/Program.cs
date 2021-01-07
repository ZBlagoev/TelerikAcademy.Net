using System;
using System.Linq;
using System.Collections.Generic;

namespace Three_Groups
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintGroupsByRemainder(GroupByRemainder(Console.ReadLine().Split().Select(int.Parse).ToArray()));

        }

        static void PrintGroupsByRemainder(List<List<int>> output)
        {
            Console.WriteLine(string.Join(" ", output[0]));
            Console.WriteLine(string.Join(" ", output[1]));
            Console.WriteLine(string.Join(" ", output[2]));
        }


        static List<List<int>> GroupByRemainder(int[] input)
        {
            List<List<int>> output = new List<List<int>>();

            List<int> zeroRem = new List<int>();
            List<int> oneRem = new List<int>();
            List<int> twoRem = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i] % 3)
                {
                    case 0:
                        zeroRem.Add(input[i]);
                        break;
                    case 1:
                        oneRem.Add(input[i]);
                        break;
                    case 2:
                        twoRem.Add(input[i]);
                        break;
                }
            }

            output.Add(zeroRem);
            output.Add(oneRem);
            output.Add(twoRem);

            return (output);
        }
    }
}
