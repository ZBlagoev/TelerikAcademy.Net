using System;

namespace Electronic_message
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ElMessageChecker(input));
        }


        public static int ElMessageChecker(string input)
        {
            input = input.Remove(input.Length - 1);

            int result = 0;
            int length = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (!(
                    (input[i] >= 48 && input[i] < 57)
                    || (input[i] >= 65 && input[i] < 90)
                    || (input[i] >= 97 && input[i] < 122)
                    || (input[i] == 32)
                    ))
                {
                    length++;

                    if (length > result)
                    {
                        result = length;
                    }
                }
                else
                {
                    length = 0;
                }

            }

            return result;
        }


    }
}
