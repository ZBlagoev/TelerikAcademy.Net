/*
Write a program that determines the color of a chessboard square based on its Label and Rank

Labels have values from a to h
Ranks have values from 1 to 8
*/

using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            char label = char.Parse(Console.ReadLine());
            int rank = int.Parse(Console.ReadLine());
            int labelNum = (int)label - 32;
            string boardColor = "dark";

            // calculation
            if (rank % 2 == 0)
            {
                if (labelNum % 2 != 0)
                {
                    boardColor = "light";
                }
            }
            else if (labelNum % 2 == 0)
            {
                boardColor = "light";
            }

            // output 
            Console.WriteLine(boardColor);
        }
    }
}
