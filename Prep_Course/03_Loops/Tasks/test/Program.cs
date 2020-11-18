using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            double sum = 0;
            if (N < 1 || N > 1000)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    sum += numbers[i];
                }
                Array.Sort(numbers);
                double average = sum / N;
                Console.WriteLine("min = {0:0.00}", numbers[0]);
                Console.WriteLine("max = {0:0.00}", numbers[N - 1]);
                Console.WriteLine("sum = {0:0.00}", sum);
                Console.WriteLine("avg = {0:0.00}", average);
            }

        }
    }
}
