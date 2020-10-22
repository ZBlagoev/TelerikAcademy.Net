using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Third Number");
            int c = int.Parse(Console.ReadLine());

            int maxOfAB = Math.Max(a, b);
            int maxOfAll = Math.Max(maxOfAB, c);

            int minOfAB = Math.Min(a, b);
            int minOfAll = Math.Min(minOfAB, c);
            
            int sumMinMax = maxOfAll + minOfAll;

            Console.WriteLine("The Sum of the greatest and the smallest numbers = " + sumMinMax); 


        
            

        }

    }
}
