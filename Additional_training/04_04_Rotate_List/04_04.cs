using System;
using System.Linq;

namespace _04_04_Rotate_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = Console.ReadLine().Split(',').ToArray();

            int n = int.Parse(Console.ReadLine());

            // calculation
            for (int j = n; j > 0; j--)
            {
                string temp = input[0];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }

                input[input.Length - 1] = temp;
            }

            // output
            Console.WriteLine(string.Join(",", input));

        }
    }
}
