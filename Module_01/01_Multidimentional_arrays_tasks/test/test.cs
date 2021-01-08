using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] array = input.Split();
        int N = int.Parse(array[0]);
        int M = int.Parse(array[1]);
        short[,] arr = ArrayFiller(5, M);
        //ulong result = ArrayCalculator(arr, N, M); // While doing the task with a whole array is possible, judge memory limit won't give you the maximum points.
        ulong baseResult = ArrayCalculator(arr, 2, M) - 1;
        ulong differenceInRows = ArrayCalculator(arr, 4, M) - ArrayCalculator(arr, 3, M) - baseResult;
        // Console.WriteLine(result);
        //Console.WriteLine(baseResult);        //at the smallest ammount of rows (2) the base case can be found. You need to remove position[0,0] (-1) to get it correct.
        //Console.WriteLine(differenceInRows);  //at rows %2 = 0 the difference between rows grows, but with a constant rate 
        int timesDifferenceInRows = -1;
        int totalAmmountOfDifferenceInRows = 1;
        for (int i = 0; i < N; i++)
        {
            if (i % 2 == 1)             //as said at rows%2 = 0 the difference grows, but as the array starts from 0 in code it should be rows%2 = 1
            {
                timesDifferenceInRows += 1; //the difference grows by its base by one at every row%2=0 and begins at -1, So at 0 is 0, at 2 is 1, at 4 is 2 and so on.
            }
            totalAmmountOfDifferenceInRows += timesDifferenceInRows;
        }
        ulong endResult = (Convert.ToUInt64(N) - 1) * baseResult + (Convert.ToUInt64(differenceInRows) * Convert.ToUInt64(totalAmmountOfDifferenceInRows)) + 1;
        Console.WriteLine(endResult);
        //Console.WriteLine(timesDifferenceInRows);
        //Console.WriteLine(totalAmmountOfDifferenceInRows);
        // Console.WriteLine(arr[N - 1,M - 1]);
    }



    static short[,] ArrayFiller(int N, int M)
    {
        short[,] arr = new short[N, M];
        short arrayFiller = 1;
        short temp = 1;
        for (int i = 0; i < N; i++)
        {
            arrayFiller = temp;
            for (int j = 0; j < M; j++)
            {
                arr[i, j] = arrayFiller;
                arrayFiller += 3;
            }
            temp += 3;
        }
        return arr;
    }



    static ulong ArrayCalculator(short[,] arr, int N, int M)
    {
        ulong result = 1;
        bool notcorner = true;
        int currentRow = 1;
        int currentCol = 1;
        int prevRow = 0;
        int prevCol = 0;
        while (notcorner)
        {
            if (currentCol == 0 && currentRow == N - 1)
            {
                notcorner = false;
            }
            if (currentRow == N - 1 && currentCol == M - 1)
            {
                notcorner = false;
            }
            if (prevRow < currentRow && prevCol < currentCol && currentCol < M - 1)
            {
                result += Convert.ToUInt64(arr[currentRow, currentCol]);         //Going North-East
                prevRow += 1;                                   //
                prevCol += 1;
                currentRow -= 1;
                currentCol += 1;
                continue;
            }
            if (prevRow > currentRow && prevCol < currentCol && currentCol < M - 1)
            {
                result += Convert.ToUInt64(arr[currentRow, currentCol]);
                prevRow -= 1;
                prevCol += 1;                                   //Going South-East
                currentRow += 1;                                //
                currentCol += 1;
                continue;
            }
            if (currentCol == M - 1)
            {
                result += Convert.ToUInt64(arr[currentRow, currentCol]);
                prevRow += 1;                                   //Going South-West after hitting a wall.
                prevCol += 1;
                currentRow += 1;
                currentCol -= 1;
                continue;
            }
            if (currentCol == 0)
            {
                result += Convert.ToUInt64(arr[currentRow, currentCol]);
                prevRow += 1;                                   //Going South-East after hitting a wall
                prevCol -= 1;
                currentRow += 1;
                currentCol += 1;
                continue;
            }
            if (prevRow < currentRow && prevCol > currentCol && currentCol >= 0)
            {
                result += Convert.ToUInt64(arr[currentRow, currentCol]);           //Going North-West
                prevRow += 1;
                prevCol -= 1;
                currentRow -= 1;
                currentCol -= 1;
                continue;
            }
            if (prevRow > currentRow && prevCol > currentCol)
            {
                result += Convert.ToUInt64(arr[currentRow, currentCol]);
                prevRow -= 1;
                prevCol -= 1;                                   //Going South-West
                currentRow += 1;
                currentCol -= 1;
                continue;
            }
        }
        return result;
    }
}
}