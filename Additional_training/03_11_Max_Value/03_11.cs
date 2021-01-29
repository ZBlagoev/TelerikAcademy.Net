using System;

namespace _03_11_Max_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input >= max)
                {
                    max = input;
                }
            }

            Console.WriteLine(max);
        }
    }
}
