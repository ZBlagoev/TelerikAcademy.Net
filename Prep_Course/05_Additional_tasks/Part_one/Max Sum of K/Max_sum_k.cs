using System;

namespace Max_Sum_of_K
{
    class Max_sum_k
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] nArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                nArr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            Array.Sort(nArr);

            // caluclation
            for (int j = n - 1; j > n - 1 -k; j--)
            {
                sum += nArr[j];
            }

            // output
            Console.WriteLine(sum);


        }
    }
}
