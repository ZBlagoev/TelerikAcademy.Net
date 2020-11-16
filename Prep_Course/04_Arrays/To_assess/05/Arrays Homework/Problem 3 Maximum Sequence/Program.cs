using System;

namespace Problem_3_Maximum_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the length of the maximum sequence of equal elements in an array of integers
            //2 1 1 2 3 3 2 2 2 1     3
            /*            int n = int.Parse(Console.ReadLine());
                        int[] array = [n];
                        int count = 0;
                        int tempCount = 1;
                        int number = 1; 
                        for (int i = 0; i < n; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                        }
            */
            int count = 1;
            int tempCount = 1; 

            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCount++;
                }
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                   
                }
            }
            Console.WriteLine(count); 
        }

    }
    
}
