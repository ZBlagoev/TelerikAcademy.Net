using System;
using System.Linq;

namespace _03_06_Convert_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] celsius = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var item in celsius)
            {
                Console.WriteLine((item * 9 / 5 + 32).ToString("0"));
            }


        }
    }
}
