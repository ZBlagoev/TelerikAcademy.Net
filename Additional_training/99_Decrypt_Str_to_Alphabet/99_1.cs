using System;
using System.Text;  

namespace _99_Decrypt_Str_to_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            // caluclation
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 2 < input.Length && input[i + 2] == '#')
                {
                    string letterNumber = input.Substring(i, 2);
                    int charASCIIndex = int.Parse(letterNumber) + 96;

                    result.Append((char)charASCIIndex);

                    i += 2;
                }
                else
                {
                    string currentChar = input[i].ToString();
                    int charASCIIndex = int.Parse(currentChar) + 96;

                    result.Append((char)charASCIIndex);
                }
            }

            // output
            Console.WriteLine(result);
        }
    }
}
