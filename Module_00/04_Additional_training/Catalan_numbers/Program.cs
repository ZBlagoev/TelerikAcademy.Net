using System;

namespace Catalan_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CatalanNumber(number));
        }

        static int CatalanNumber(int number)
        {
            int result = 0;

            if (number <= 1)
            {
                return 1;
            }

            for (int i = 0; i < number; i++)
            {
                result += CatalanNumber(i) * CatalanNumber(number - i - 1);
            }

            return result;
        }
    }
}
