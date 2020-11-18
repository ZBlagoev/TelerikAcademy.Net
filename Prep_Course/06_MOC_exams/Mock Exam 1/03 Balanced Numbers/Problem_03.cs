using System;

namespace _03_Balanced_Numbers
{
    class Problem_03
    {
        static void Main(string[] args)
        {
            // input & calculation
            bool isBalanced = true;
            int sum = 0;

            while (isBalanced)
            {
                int number = int.Parse(Console.ReadLine());

                int a = number % 10;
                int b = number / 10 % 10;
                int c = number / 100 % 10;

                if (a + c == b)
                {
                    sum += number;
                }
                else
                {
                    isBalanced = false;
                    Console.WriteLine(sum);
                }
            }


        }
    }
}
