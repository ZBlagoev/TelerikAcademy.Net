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
                int input = int.Parse(Console.ReadLine());

                if ((input % 10) + (input / 100 % 10) == (input / 10 % 10))
                {
                    sum += input;
                }
                else
                {
                    isBalanced = false;
                }
            }

            // output
            Console.WriteLine(sum);

        }
    }
}
