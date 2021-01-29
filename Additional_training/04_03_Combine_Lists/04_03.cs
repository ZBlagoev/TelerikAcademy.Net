using System;
using System.Linq;

namespace _04_03_Combine_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] a = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            int[] combined = new int[a.Length * 2];

            // caluclation
            for (int i = 0; i < combined.Length; i += 2)
            {
                combined[i] = a[i / 2];
            }

            for (int i = 1; i < combined.Length; i += 2)
            {
                combined[i] = b[(i + 1) / 2 - 1];
            }

            // output
            Console.WriteLine(string.Join(",", combined));

        }
    }
}
