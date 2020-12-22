using System;
using System.Linq;

namespace Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string declaration = Console.ReadLine();

            Console.WriteLine(BiggestEven(declaration));
        }

        static int BiggestEven(string declaration)
        {
            declaration = declaration.Remove(declaration.Length - 1);

            string[] items = declaration.Split().ToArray();
            
            int result = -1;

            int number;

            foreach (var item in items)
            {
                if (int.TryParse(item, out number))
                {
                    if (number % 2 == 0) 
                    {
                        if (number >= result)
                        {
                            result = number;
                        }
                    }
                }
            }

            return result;
        }
    }
}
