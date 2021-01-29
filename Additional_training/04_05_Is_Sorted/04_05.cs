using System;
using System.Linq;

namespace _04_05_Is_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            bool[] isSorted = new bool[n];

            // calculation
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        isSorted[i] = false;
                        break;
                    }
                    else
                    {
                        isSorted[i] = true;
                    }
                }
            }

            foreach (var item in isSorted)
            {
                Console.WriteLine(item.ToString().ToLower());
            }


        }
    }
}
