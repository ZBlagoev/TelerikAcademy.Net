using System;
using System.Linq;

namespace Mirror_codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Pincode(input));
        }

        public static int Pincode(Array input)
        {
            int result = 0;

            foreach (int item in input)
            {
                int reverse = 0;
                int number = item;

                while (number > 0)
                {
                    int remainder = number % 10;
                    reverse = (reverse * 10) + remainder;
                    number /= 10;
                }

                if (reverse > result)
                {
                    result = reverse;
                }
            }

            return result;
        }
    }
}
