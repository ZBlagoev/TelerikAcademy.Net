/*
You are given an integer number n and then n new lines of text: numbers 
or words (see Problem 6). This time when we have a word we concatenate it 
with the previous words with a dash - between them. If we have a number we 
add it to all previous numbers.

The input starts by the number n (alone in a line) followed by n lines, 
each holding a text without a space.
Again all words contain no digits.
The output is like in the examples below.
On the first line there are all words concatenated with - between them 
or no words if there were no words in the input.
On the second line is the sum of all the numbers or 0 if there were no numbers.
*/

using System;

namespace Problem_10._Word_or_Number_2
{
    class Problem_10
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 10. Word or Number 2");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            string[] input = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1}: ");
                input[i] = Console.ReadLine();
            }

            int number;
            string text;

            string resultS = "";
            int resultN = 0;

            // calculation
            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i], out number))
                {
                    resultN += number;
                }
                else
                {
                    resultS += $"-{input[i]}";
                }

            }

                // if no words or no nums
            switch (resultS)
            {
                case "": resultS = "no words";
                    break;
            }

            // output
            Console.WriteLine("output:");
            Console.WriteLine(resultS.Substring(1));
            Console.WriteLine(resultN);
            
        }
    }
}
