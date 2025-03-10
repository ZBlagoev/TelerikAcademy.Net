﻿/*
Forest Road
Geeko, a non-stop learning trainee at Telerik Software Academy lived deep into the Lyulin forests. 
Every time he went to the Academy he had to take a long trip through the forest. Starting from the 
top left corner of the forest, the road always goes down and right first and when it reaches the border, 
it goes down and left.

The Academy is situated in the bottom left corner, and Geeko begins his journey from the top left corner 
of the forest (see the examples below).

He wanted to make a program that generates a map of the forest but he couldn’t. Help Geeko on his way 
to the Academy by writing the program instead of him.

Input
Read from the standard input

On the only line in the console you are given an integer number N, showing the width of the map.

The map’s height is always 2*N - 1.

The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
Print to the standard output

You should print the whole map on the standard output

Use the symbol “*” (asterisk) to mark Geeko’s path and “.” (dot) to illustrate the trees
Constraints
The number N is a positive integer between 2 and 79, inclusive.

Allowed working time for your program: 0.25 second.
*/

using System;

namespace Forrest_road
{
    class Program
    {
        static void Main(string[] args)
        {
            ForrestPath(int.Parse(Console.ReadLine()));
        }

        // combined path method
        static void ForrestPath(int number)
        {
            TopPart(number);
            BottomPart(number);
        }

        // path method top part
        static void TopPart (int number)
        {
            int current = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (j == current)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
                current++;
            }
        }

        // path method bottom path
        static void BottomPart (int number)
        {
            int current = number - 1;

            for (int i = 1; i < number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (j == current)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
                current--;
            }
        }
    }
}
