/*
The crooked digit of a given number N is calculated using the number's digits 
in a very weird and bendy algorithm. The algorithm takes the following steps:

Sums the digits of the number N and stores the result back in N.
If the obtained result is bigger than 9, step 1. is repeated, otherwise the algorithm finishes.
The last obtained value of N is the result, calculated by the algorithm.

Input
The input data should be read from the console.
The only line in the input contains a number N, which can be an integer or real number (decimal fraction), 
positive or negative.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
The output data should be printed on the console.
You must print the calculated crooked digit of the number N on the first and only line of the output.

Constraints
The number N will have no more than 300 digits before and after the decimal point.
The decimal separator will always be the "." symbol.
*/

using System;

namespace ME_01_01
{
    class Problem_01
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            input = input.Replace(".", "");
            input = input.Replace("-", "");

            int result = 0;


            // calculation
            for (int i = 0; i < input.Length; i++)
            {
                result += int.Parse(input[i].ToString());
            }

            while (result > 9)
            {
                int temp = 0;

                while (result > 0)
                {
                    temp += result % 10;
                    result /= 10;
                }

                result = temp;
            }

            // output
            Console.WriteLine(result);

        }
    }
}
