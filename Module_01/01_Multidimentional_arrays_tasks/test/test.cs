using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int[]> passedCells = new List<int[]>();
        passedCells.Add(new int[2] { -1, -1 });

        int[] coordinates = { -1, -2 };
        int sum = 0;

        // MasterList.Any(c => c.SequenceEqual(childList))

        if (!(passedCells.Any(c => c.SequenceEqual(coordinates))))
        {
            passedCells.Add((int[])coordinates.Clone());

            sum++;
        }



        Console.WriteLine(sum);
    }

}

/*
You should be able to use Linq here:

var matchingvalues = myList
    .Where(stringToCheck => stringToCheck.Contains(myString));
If you simply wish to return the first matching item:

var match = myList
    .FirstOrDefault(stringToCheck => stringToCheck.Contains(myString));

if(match != null)
*/




