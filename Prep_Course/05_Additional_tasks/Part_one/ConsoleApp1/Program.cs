using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "123456789";

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
