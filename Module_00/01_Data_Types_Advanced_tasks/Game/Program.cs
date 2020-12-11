using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int input = int.Parse(Console.ReadLine());

            // calculation
            int result = Math.Max((input / 100) * (input / 10 % 10) * (input % 10),
                Math.Max((input / 100) * (input / 10 % 10) + (input % 10),
                Math.Max((input / 100) + (input / 10 % 10) * (input % 10),
                (input / 100) + (input / 10 % 10) + (input % 10))));

            // output
            Console.WriteLine(result);
        }
    }
}
