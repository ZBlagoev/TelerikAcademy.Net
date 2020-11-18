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
