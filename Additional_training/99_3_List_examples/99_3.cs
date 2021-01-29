using System;
using System.Collections.Generic;
using System.Linq;

namespace _99_3_List_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "10 20 30 40 50 60";

            List<int> input = str.Split()
                .Select(x => int.Parse(x)).ToList();


            List<int> result = new List<int>();

            int len = result.Count;

            Console.WriteLine(string.Join("", result));

            for (int i = 0; i < 9; i++)
            {
                result.Add(i);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
