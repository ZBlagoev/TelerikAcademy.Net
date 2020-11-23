/*
Game
Three friends came up with a game for having fun in the break between the classes. 
One of them says a three-digit number and the others use it to form a mathematical 
expressions by using operators for sum and multiplication between the digits of that number.

The winner is the first one who founds the biggest number that is a result of the above mentioned rules.

Write a program 'game', which prints out that biggest number.

Input
Read from the standard input

The first line of the input will be positive three-digit number N.
Output
Print on the standard output

The result should be the calculated biggest number.
*/
using System;

namespace _01_Game
{
    class Problem_01
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            int a = number % 10; // единици
            int b = number / 10 % 10; // десетици
            int c = number / 100 % 10; // стотици

            // calculation
            if (a + b + c >= max)
            {
                max = a + b + c;
            }
            
            if (a * b + c >= max)
            {
                max = a * b + c;
            }
            
            if (a + b * c >= max)
            {
                max = a + b * c;
            }
            
            if (a * b * c > max)
            {
                max = a * b * c;
            }

            // output
            Console.WriteLine(max);
        }
    }
}
