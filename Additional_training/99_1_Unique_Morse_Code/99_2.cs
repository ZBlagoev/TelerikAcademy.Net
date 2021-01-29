using System;
using System.Collections.Generic;
using System.Linq;

namespace _99_1_Unique_Morse_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] morseCode = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-",
                ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

            string[] input = { "gin", "zen", "gig", "msg" };

            //string[] output = new string[4];

            List<string> result = new List<string>();

            // calculation
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                string wordsAsMorse = string.Empty;

                for (int j = 0; j < currentWord.Length; j++)
                {
                    char currentChar = currentWord[j];
                    int index = currentChar - 97;

                    wordsAsMorse += morseCode[index];
                    //output[i] += morseCode[index];

                }

                result.Add(wordsAsMorse);
            }

            List<string> uniques = result.Distinct().ToList();

            // output
            Console.WriteLine(string.Join(" & ", uniques));
        }
    }
}
