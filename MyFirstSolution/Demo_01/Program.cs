using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_01
{
    class Program
    {
        static void Main(string[] args)

        {


            var scores = new[] { 90, 97, 78, 68, 85 };
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;
            Console.WriteLine(string.Join(" ", highScoresQuery));
            // Output:
            // 97 90 85


        }
    }
}
