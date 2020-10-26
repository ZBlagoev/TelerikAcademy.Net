/*
Problem 2. Bonus Score
Write a program that applies bonus score to given score in the range [1…9] 
by the following rules: * If the score is between 1 and 3, the program multiplies 
it by 10. * If the score is between 4 and 6, the program multiplies it by 100. * 
If the score is between 7 and 9, the program multiplies it by 1000. * 
If the score is 0 or more than 9, the program prints “invalid score”.
*/

using System;

namespace Problem_2._Bonus_Score
{
    class Problem_02
    {
        static void Main(string[] args)
        {
            // input **********************************************
            Console.WriteLine("Problem 2. Bonus Score");

            Console.Write("score: ");
            double score = double.Parse(Console.ReadLine());

            // output **********************************************
            switch (score)
            {
                case 1: Console.WriteLine($"result: {score * 10}"); break;
                case 2: Console.WriteLine($"result: {score * 10}"); break;
                case 3: Console.WriteLine($"result: {score * 10}"); break;
                case 4: Console.WriteLine($"result: {score * 100}"); break;
                case 5: Console.WriteLine($"result: {score * 100}"); break;
                case 6: Console.WriteLine($"result: {score * 100}"); break;
                case 7: Console.WriteLine($"result: {score * 1000}"); break;
                case 8: Console.WriteLine($"result: {score * 1000}"); break;
                case 9: Console.WriteLine($"result: {score * 1000}"); break;
                default: Console.WriteLine("invalid score"); break;
            }
        }
    }
}
