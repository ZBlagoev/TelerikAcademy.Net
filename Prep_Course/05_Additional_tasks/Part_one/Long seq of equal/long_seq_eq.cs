using System;

namespace Long_seq_of_equal
{
    class long_seq_eq
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int max = 1;

            // calculation
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    continue;

                }
                else if (arr[i - 1] == arr[i])
                {
                    counter++;
                }
                else
                {
                    if (max < counter)
                    {
                        max = counter;
                    }

                    counter = 1;
                }
            }

            // output
            Console.WriteLine(max);
        }
    }
}
