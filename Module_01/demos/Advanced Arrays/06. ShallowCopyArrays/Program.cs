using System;

namespace _06._ShallowCopyArrays
{
    class Program
    {
        static void Main(string[] args)
        {
			int[][] arr = new int[2][];

			arr[0] = new int[3] { 1, 2, 3 };
			arr[1] = new int[1] { 2 };

			// Clone and cast it to int[]
			int[][] arrCopy = (int[][])arr.Clone();

			arr[1][0] = 20;

			// False -> Shallow copy 
			// (different arrays but the same addresses of the values)
			Console.WriteLine(arr == arrCopy);

			// Result is 20 because the elements of the array are arrays 
			// and they are reference types
			Console.WriteLine(arrCopy[1][0]);

		}
	}
}
