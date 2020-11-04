using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countSpaces = 0;
            string numbers = "";

            for (int i = 1; i <= n; i++)
            {
                char input = (char)Console.Read();

                if (input == ' ')
                {
                    countSpaces++;
                }
                numbers += input;
            }

            Console.WriteLine(numbers);
        }
    }
}
