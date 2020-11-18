using System;

namespace _01_Game
{
    class Problem_01
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            int a = number % 10; // единици
            int b = number / 10 % 10; // десетици
            int c = number / 100 % 10; // стотици

            // calculation
            if (a + b + c >= max)
            {
                max = a + b + c;
            }
            
            if (a * b + c >= max)
            {
                max = a * b + c;
            }
            
            if (a + b * c >= max)
            {
                max = a + b * c;
            }
            
            if (a * b * c > max)
            {
                max = a * b * c;
            }

            // output
            Console.WriteLine(max);
        }
    }
}
