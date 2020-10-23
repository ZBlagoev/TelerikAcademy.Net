using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "2000-02-02";
            DateTime dDate;

            if (DateTime.TryParse(inputString, out dDate))
            {
                Console.WriteLine(String.Format("{0:d/MM/yyyy}", dDate));
            }
            else
            {
                Console.WriteLine("Invalid"); // <-- Control flow goes here
            }
        }
    }
}
