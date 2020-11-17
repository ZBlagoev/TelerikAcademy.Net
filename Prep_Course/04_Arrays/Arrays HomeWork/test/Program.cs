using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] arr = Console.ReadLine().Split(',').ToArray();

            string output = "";


            // calculation
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDup = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        isDup = true;
                        break;
                    }

                }

                if (!isDup)
                {
                    output += arr[i] + ",";
                }

            }

            // output
            for (int i = 0; i < output.Length - 1; i++)
            {
                Console.Write(output[i]);
            }
            
        }
    }
}
