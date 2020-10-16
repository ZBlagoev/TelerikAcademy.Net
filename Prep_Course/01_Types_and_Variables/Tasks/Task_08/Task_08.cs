/*
Read two numbers from the console and calculate:

The sum of a and b
The difference when a is subtracted from b
The product of a and b
The remainder when a is divided by b
The result of a powered to b
Input
On the first line you will receive a number a
On the second line you will receive a number b
Output
You should print the sum, the difference, the product the remainder and the power
*/
using System;

namespace Task_08
{
    class Task_08
    {
        static void Main(string[] args)
        {            
            // inputs
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();

            // calculations
            int a = int.Parse(inputA);
            int b = int.Parse(inputB);

            double power = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b));

            // outputs
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);
            Console.WriteLine(Convert.ToInt32(power));

        }
    }
}
