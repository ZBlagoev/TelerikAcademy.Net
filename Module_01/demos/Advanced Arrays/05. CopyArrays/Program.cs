using System;

namespace CopyArrays
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = { 1, 2, 3 };
			int[] arrCopy = arr;

			arr[1] = 5;

			// The result is 5 because the two arrays 
			// points to the same address in memory
			Console.WriteLine(arrCopy[1]);

			// True -> The same address in memory
			Console.WriteLine(arr == arrCopy);

		}
	}
}
