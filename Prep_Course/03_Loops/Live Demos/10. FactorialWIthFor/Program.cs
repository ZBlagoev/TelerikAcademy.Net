using System;

namespace _10._FactorialWIthFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5! => 120
            int num = int.Parse(Console.ReadLine()); //5
            int factorial = 1;

            for (int i = num; i >= 1; i--)
            {
                factorial *= i;
            }

            //alternative
            //for (int i = 1; i <= num; i++)
            //{
            //    factorial *= i;
            //}

            Console.WriteLine(factorial);
        }
    }
}
