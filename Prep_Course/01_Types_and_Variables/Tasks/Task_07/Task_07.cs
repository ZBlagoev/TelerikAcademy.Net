/*
You have deposited a sum into your bank account for 3 years. 
The bank has announced an interest of 5% per year. Each time the interest is calculated 
and added to your deposit. You have to calculate the amount in your deposit for each year.

Input
On the only line you will receive a number (n) with the sum deposited
Output
You should print the amount in your deposit for each of the 3 years
Constraints
You must print the number with two numbers after the decimal point. The rules of math 
for rounding apply here
*/
using System;

namespace Task_07
{
    class Task_07
    {
        static void Main(string[] args)
        {
            // inputs
            string deposit = Console.ReadLine();

            // calculations
            float depositOne = float.Parse(deposit) + float.Parse(deposit) * 0.05f;

            float depositTwo = depositOne + depositOne * 0.05f;

            float depositThree = depositTwo + depositTwo * 0.05f;

            // outputs
            Console.WriteLine("{0} \n {1} \n {2}", 
                depositOne.ToString("0.00"), depositTwo.ToString("0.00"), depositThree.ToString("0.00"));

        }
    }
}
