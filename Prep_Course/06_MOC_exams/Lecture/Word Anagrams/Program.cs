using System;

namespace Word_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] wordAsCharArray = input.ToCharArray();
            Array.Sort(wordAsCharArray);

            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                char[] currentWordAsCharArr = words[i].ToCharArray();
                Array.Sort(currentWordAsCharArr);

                if (new string(wordAsCharArray) == new string(currentWordAsCharArr))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
                
            }
        }
    }
}
