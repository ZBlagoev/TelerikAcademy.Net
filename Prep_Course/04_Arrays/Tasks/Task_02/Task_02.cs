/*
Reverse Number
Description
Write a method that reverses the digits of a given decimal number.

Input
On the first line you will receive a number
Output
Print the given number with reversed digits
*/

using System;

namespace Task_02
{
    class Task_02
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            int len = input.Length;

            string[] arrS = new string[len];
            string[] arrR = new string[len];

            // calculation
            for (int i = 0; i < len; i++)
            {
                arrS[i] = input[i].ToString();
                arrR[len - 1 - i] = arrS[i];
            }
            
            // output
            foreach (string item in arrR)
            {
                Console.Write(item);
            }
            
        }


    }
}
