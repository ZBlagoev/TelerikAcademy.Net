using System;

namespace Balanced_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool isBalanced = true;

            while (isBalanced)
            {
                string input = Console.ReadLine();
            
                int firstNumber = input[0] - 48;
                int midNumber = input[1] - 48;
                int lastNumber = input[2] - 48;

                if (midNumber == firstNumber + lastNumber)
                {
                    sum += int.Parse(input);
                }
                else
                {
                    isBalanced = false;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
