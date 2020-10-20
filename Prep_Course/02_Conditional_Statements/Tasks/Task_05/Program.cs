/*
Phone Bill
A phone bill plan includes 1 hour of free calls and 20 text messages for 12.00 levas. 
Each additional minute costs 0.10 levas and each additional message costs 0.06 levas. 
Also, any additional minutes/text messages are subject to 20% sales tax. Write a program 
that calculates the additional charge for text, the additional charge for minutes, 
and the sales tax charge for both. Also, display the total amount paid.

Input
On the first line, you will receive the total amount of text messages.
On the second line, you will receive the total amount of minutes.
Output
1st line - number of additional messages and additional amount paid
2nd line - number of additional minutes and additional amount paid
3rd line - amount paid in taxes
4th line - total bill
*/


using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            int messages = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            decimal basePrice = 12.00m;
            decimal minuteCost = 0.10m;
            decimal messageCost = 0.06m;

            int addMessages;
            int addMinutes;

            decimal taxes = 0.00m;
            decimal addMessagesPrice = 0.00m;
            decimal addMinutesPrice = 0.00m;
            decimal totalBill = basePrice;

            // calculation
            // additional messages and taxes 
            if (messages > 20)
            {
                addMessages = messages - 20;
                addMessagesPrice = addMessages * messageCost;
                taxes += addMessagesPrice * 0.2m;

                totalBill += addMessagesPrice;
            }
            else
            {
                addMessages = 0;
            }

            // additional minutes and taxes
            if (minutes > 60)
            {
                addMinutes = minutes - 60;
                addMinutesPrice = addMinutes * minuteCost;
                taxes += addMinutesPrice * 0.2m;

                totalBill += addMinutesPrice + taxes;
            }
            else
            {
                addMinutes = 0;
            }

            // output
            Console.WriteLine($"{addMessages} additional messages for {Math.Round(addMessagesPrice,2)} levas");
            Console.WriteLine($"{addMinutes} additional minutes for {Math.Round(addMinutesPrice,2)} levas");
            Console.WriteLine($"{Math.Round(taxes,2)} additional taxes");
            Console.WriteLine($"{Math.Round(totalBill, 2)} total bill");
        }
    }
}
