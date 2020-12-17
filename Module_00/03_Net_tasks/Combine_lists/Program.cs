using System;
using System.Linq;
using System.Collections.Generic;

namespace Combine_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            Console.WriteLine(String.Join(",",CombineLists(first, second)));            
        }


        static List<int> CombineLists(List<int> first, List<int> second)
        {
            List<int> combined = new List<int>();

            for (int i = 0; i < first.Count; i++)
            {
                combined.Add(first[i]);
                combined.Add(second[i]);
            }

            return combined;
        }
    }
}
