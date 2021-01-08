using System;
using System.Linq;

namespace ZIgZag
{
    class Program
    {
        static void Main(string[] args)
        {
            ZigZag(Console.ReadLine().Split().Select(int.Parse).ToArray());
        }

        static void ZigZag(int[] dims)
        {
            ulong sum = 0;
            int n = dims[0];
            int m = dims[1];

            // getting the elements
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                    {
                        if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                        {
                            sum += (ulong)(j * 3 + 1 + i * 3);
                        }
                        else
                        {
                            sum += (ulong)((j * 3 + 1 + i * 3) * 2);
                        }

                    }
                }
            }

            Console.WriteLine(sum);
        }

    }
}
