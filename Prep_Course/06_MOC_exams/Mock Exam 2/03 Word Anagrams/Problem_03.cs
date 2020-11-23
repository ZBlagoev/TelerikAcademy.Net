/*
You are given a word W and words WORDS. You tasks is to check whether the words from WORDS are anagrams of W.

An anagram of a word is every other word that has exactly the same number of characters as the original word 
but in different order. Example:

The following are anagrams of "anagram":
"gramana", "aaagrnm", "margana", etc..
The following are NOT anagrams of "anagram":
"aanagram", "aaagram", "anagra", "anagrama", "yxy"
Input
Read from the standard input

On the first line, find the word W
On the second line, find N - the number of words in WORDS
On the next N lines, find a single word from WORDS
Output
Print to the standard output

For each word from WORDS print either:
"Yes", if the word is an anagram of W
"No", if the word is NOT an anagram of W
*/
using System;

namespace _03_Word_Anagrams
{
    class Problem_03
    {
        static void Main(string[] args)
        {
            // input
            string w = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }

            // calculation & output
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == w.Length)
                {
                    char[] input = w.ToCharArray();
                    char[] testWord = words[i].ToCharArray();

                    Array.Sort(input);
                    Array.Sort(testWord);

                    int counter = 0;

                    for (int j = 0; j < input.Length; j++)
                    {
                        if (!(input[j] == testWord[j]))
                        {
                            counter++;
                        }
                    }

                    if (counter == 0)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
            }



        }
    }
}
