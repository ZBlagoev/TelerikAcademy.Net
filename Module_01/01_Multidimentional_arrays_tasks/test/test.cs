using System;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine();
        
        CalculateResultsForStudents("Ivan");

        Console.WriteLine();

        // string comparison
        bool isEqual = "Alpha".Equals("Alpha");
        bool isEqualNoCase = "Alpha".Equals("alpha", StringComparison.InvariantCultureIgnoreCase);

        // string concatenation
        string result = "snow" + "ball";
    }


    static void CalculateResultsForStudents(string studentName, params string[] exams)
    {
        Console.WriteLine($"{studentName}'s exam results:");
        var rnd = new Random();

        foreach (var exam in exams)
        {
            Console.WriteLine($"{exam}: {rnd.Next(1, 101)}");
        }
    }
}

 