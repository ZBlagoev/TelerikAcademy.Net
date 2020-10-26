using System;
using System.Security.Cryptography;

namespace Methods_Array_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            Increment(arr);

            Console.WriteLine(string.Join(" ", arr));
        }

        static void Increment(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }

    }
}
