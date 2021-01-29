using System;

namespace _02_01_Dog_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int humanYears = int.Parse(Console.ReadLine());

            // calculation
            if (humanYears <= 2)
            {
                Console.WriteLine(humanYears * 10);
            }
            else
            {
                Console.WriteLine(2 * 10 + (humanYears - 2) * 4);
            }


        }
    }
}
