using System;

namespace _01_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = 0;

            // calculation
            totalSeconds = seconds
                + 60 * minutes
                + 60 * 60 * hours
                + 60 * 60 * 24 * days;

            // output
            Console.WriteLine(totalSeconds);

        }
    }
}
