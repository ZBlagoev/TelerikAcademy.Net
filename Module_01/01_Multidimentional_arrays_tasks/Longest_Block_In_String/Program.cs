using System;

namespace Longest_Block_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = MakeArray(Console.ReadLine());

            LongestBlock(input);
        }

        static char[] MakeArray(string input)
        {
            char[] array = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = input[i];
            }

            return array;
        }

        static void LongestBlock(char[] input)
        {
            int counter = 1;
            int max = 1;

            string seq = "";
            string maxseq = "";

            // calculation
            for (int i = 1; i < input.Length; i++)
            {
                if (input.Length == 1)
                {
                    maxseq = input[0].ToString();
                    break;
                }
                
                if (input[i - 1] == input[i])
                {
                    if (counter == 1)
                    {
                        seq += input[i - 1];
                    }
                    counter++;
                    seq += input[i];
                }
                else
                {
                    if (max <= counter)
                    {
                        max = counter;
                        maxseq = seq;
                    }

                    counter = 1;
                    seq = "";
                }

                // 
                if (max <= counter)
                {
                    max = counter;
                    maxseq = seq;
                }
            }

            // output
            Console.WriteLine(maxseq);
        }
    }
}
