using System;

namespace _01_05_Tips
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int priceMeal = int.Parse(Console.ReadLine());

            int sum = 0;

            // calculation
            sum = priceMeal + Convert.ToInt32(priceMeal * 0.10);

            // output
            Console.WriteLine(sum);

        }
    }
}
