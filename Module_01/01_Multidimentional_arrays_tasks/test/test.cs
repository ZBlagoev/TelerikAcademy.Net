using System;

namespace test
{
    class test
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input.Length == 1)
                {
                    Console.WriteLine("Yes");
                    continue;
                }


                string[] numbers = input.Split();

                Array.Reverse(numbers);

                string reversed = string.Join(" ", numbers);


                if (input.Equals(reversed))
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
