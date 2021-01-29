using System;

namespace _01_09_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            double m = Convert.ToDouble(Console.ReadLine());

            // calculations
            double result = (4.54 / (m * 1.6)) * 100;

            // outputs
            Console.WriteLine($"{Math.Floor(result)} litres per 100 km");

        }
    }
}
