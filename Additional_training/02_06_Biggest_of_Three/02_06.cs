using System;

namespace _02_06_Biggest_of_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            double max = double.MinValue;

            // calculation
            if (n1 >= max)
            {
                max = n1;
            }
            if (n2 >= max)
            {
                max = n2;
            }
            if (n3 >= max)
            {
                max = n3;
            }

            // output
            Console.WriteLine(max);

        }
    }
}
