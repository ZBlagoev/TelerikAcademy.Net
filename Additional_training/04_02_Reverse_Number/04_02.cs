using System;

namespace _04_02_Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(DigitReverse(number));


        }

        static decimal DigitReverse(decimal number)
        {
            string test = number.ToString();

            char[] normal = test.ToCharArray();
            char[] reversed = new char[test.Length];

            for (int i = 0; i < test.Length; i++)
            {
                reversed[i] = normal[test.Length - 1 - i];
            }

            string temp = "";

            foreach (var item in reversed)
            {
                temp += item.ToString();
            }
            decimal result = decimal.Parse(temp);

            return result;

        }

    }
}
