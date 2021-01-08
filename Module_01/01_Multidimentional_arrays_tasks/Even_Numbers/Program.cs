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
            int numberOne;
            int numberTwo;

            string numberString = "";

            int result = -2147483647;

            for (int i = 0; i < declaration.Length - 1; i++)
            {
                if (int.TryParse(declaration[i].ToString(), out numberOne)) 
                {
                    numberString += declaration[i];

                    if (!(int.TryParse(declaration[i + 1].ToString(), out numberTwo)))
                    {
                        numberTwo = int.Parse(numberString);

                        if ((numberTwo == 0 || numberTwo % 2 == 0) && (numberTwo >= result))
                        {
                            result = numberTwo;
                        }
                    }
                }

                if (int.TryParse(declaration[i + 1].ToString(), out numberTwo))
                {
                    continue;
                }
                else
                {
                    numberString = "";
                }
                
            }


            if (!(result % 2 == 0))
            {
                result = -1;
            }
            return result;
        }
    }
}
