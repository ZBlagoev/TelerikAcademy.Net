/*
Calculate Discount
You need to calculate the discounted price for each item in your shopping cart. 
The discount is 65%, a real deal for you.

Input
On the first line, you will receive N - the number of the items in your shopping cart
On the next N lines you will each item's price
Output
On each line in the output print the discounted price of the item with two digits 
after the decimal point (Math rules for rounding apply)
*/

using System;
using System.Collections.Generic;

namespace Task_05
{
    class Task_05
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            double k = 0.00;
            double afterDiscount = 0.35;
            double finalPrice = 0.00;

            List<double> numbers = new List<double>();

            // calculation
            for (int i = 1; i <= n; i++)
            {
                k = double.Parse(Console.ReadLine());

                finalPrice = k * afterDiscount;

                numbers.Add(finalPrice);

            }

            // output
            foreach (double number in numbers)
            {
                Console.WriteLine($"{Math.Round(number, 2).ToString("#.00")}");
            }


        }
    }
}
