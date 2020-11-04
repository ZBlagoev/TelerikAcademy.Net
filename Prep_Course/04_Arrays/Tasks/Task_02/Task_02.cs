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
using System.Linq;

namespace Task_02
{
    class Task_02
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arrayS = input.ToCharArray();
            int[] arrayN = Array.ConvertAll(arrayS, int.Parse);

            foreach (int n in arrayN)
            {
                Console.WriteLine(n);
            }
            
        }


    }
}
