/*
Three friends came up with a game for having fun in the break 
between the classes. One of them says a three-digit number 
and the others use it to form a mathematical expressions 
by using operators for sum and multiplication between the 
digits of that number.

The winner is the first one who founds the biggest number 
that is a result of the above mentioned rules.

Write a program 'game', which prints out that biggest number.

Input
Read from the standard input

The first line of the input will be positive three-digit number N.
Output
Print on the standard output

The result should be the calculated biggest number.
*/

using System;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int n1 = n / 100 % 10;
            int n2 = n / 10 % 10;
            int n3 = n % 10;

            int max = 0;

            // calculation
            if (((n1) + (n2) + (n3)) >= max)
            {
                max = (n1) + (n2) + (n3);
            }
            if (((n1) * (n2) * (n3)) >= max)
            {
                max = (n1) * (n2) * (n3);
            }
            if (((n1) + (n2) * (n3)) >= max)
            {
                max = (n1) + (n2) * (n3);
            }
            if (((n1) * (n2) + (n3)) >= max)
            {
                max = (n1) * (n2) + (n3);
            }

            // output
            Console.WriteLine(max);
        }
    }
}
