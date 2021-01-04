using System;
using System.Linq;

namespace Symetric_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int rows = int.Parse(Console.ReadLine());


            // initialize input jagged array
            string[][] jagged = new string[rows][];

            // fill input jagged array
            for (int i = 0; i < rows; i++)
            {
                string line = Console.ReadLine();

                string[] arrStrings = line.Split();

                jagged[i] = arrStrings;
            }


            // initialize result array
            string[] result = new string[rows];

            // fill result array
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = "Yes";
            }


            // calculation
            for (int i = 0; i < jagged.Length; i++)
            {
                string[] currentArr = jagged[i];

                for (int j = 0; j < currentArr.Length; j++)
                {

                    if (!(currentArr[j] == currentArr[currentArr.Length - 1 - j]))
                    {
                        result[i] = "No";
                        break;
                    }
                }
            }

            // result
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }



            /*

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "Yes";

            // calculation
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[arr.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    result = "No";
                }
            }

            // output
            Console.WriteLine($"output: {result}");
            */

        }
    }
}
