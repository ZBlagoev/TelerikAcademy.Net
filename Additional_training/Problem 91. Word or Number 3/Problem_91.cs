/*
You are given an integer number n and then n new lines of text: 
numbers or words (see Problem 6 and 10). This time we concatenate words 
(with a dash - between them) only if they are adjacent. And we add numbers 
only when they are adjacent. Each time we have a number after a word 
we print the concatenated words so far and go on a new line. 
Each time we have a word after a number we print the sum 
so far and go on the next line.

The input starts by the number n (alone in a line) followed by n lines, 
each holding a text without a space.
Again all words contain no digits.
The output is like in the examples below.

Explanation:
First we have 6 - the number of lines with text.
The first line of text is the number 1.
It is followed by a word go - we print 1
The word go is followed by a number - print go and move on.
Then we have two numbers - sum them.
Next is the word there - print the sum so far (2) and move on.
Two words are adjacent - concatenate and print them.
*/

using System;
using System.Linq;

namespace Problem_91._Word_or_Number_3
{
    class Problem_91
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Additional NON-Required Problem: Word or Number 3");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            int number;
            string input;

            int sum = 0;
            string text = "";
            bool isNum;
            bool containsInt;

            // calculation & output
            for (int i = 1; i <= n; i++)
            {
                Console.Write("in: ");
                input = Console.ReadLine();

                isNum = int.TryParse(input, out number);
                containsInt = input.Any(char.IsDigit);

                if (isNum)
                {
                    sum += number;

                    if (text != "")
                    {
                        Console.WriteLine($"out: {text.Substring(1)}");
                    }

                    text = "";
                }
                else if (containsInt)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (Char.IsDigit(input[j]))
                        {
                            string result = input[j].ToString();
                            number += int.Parse(result);
                        }
                    }

                    sum += number;

                    if (text != "")
                    {
                        Console.WriteLine($"out: {text.Substring(1)}");
                    }

                    text = "";
                }
                else if (!(isNum))
                {
                    text += $"-{input}";
                    
                    if (sum != 0)
                    {
                        Console.WriteLine($"out: {sum}");
                    }

                    sum = 0;

                }

            }

            // final output
            if (sum != 0)
            {
                Console.WriteLine($"out: {sum}");
            }
            else
            {
                Console.WriteLine($"out: {text.Substring(1)}");
            }
            



        }
    }
}
