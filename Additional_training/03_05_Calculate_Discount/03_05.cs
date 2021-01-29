using System;

namespace _03_05_Calculate_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            double[] prices = new double[n];

            for (int i = 0; i < n; i++)
            {
                prices[i] = double.Parse(Console.ReadLine()) * 0.35;
            }

            // output
            foreach (var item in prices)
            {
                Console.WriteLine(item.ToString("0.00"));
            }
        }
    }
}
