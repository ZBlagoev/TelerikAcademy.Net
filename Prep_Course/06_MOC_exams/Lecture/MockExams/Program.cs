using System;

namespace MockExams
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.Replace(".", "");
            input = input.Replace("-", "");

            int n = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //if (input[i] == '.' || input[i] == '-')
                //{
                //    continue;
                //}

                //if (char.IsDigit(input[i]))
                //{
                //n += int.Parse(input[i].ToString());
                //}

                n += int.Parse(input[i].ToString());

                //n += input[i] - 48;
                //n += input[i] - '0';
            }

            string numberAsString = n.ToString();

            while (n > 9)
            {
                //n = 0;
                //for (int i = 0; i < numberAsString.Length; i++)
                //{
                //    n += int.Parse(numberAsString[i].ToString());
                //}
                //Time limit ex

                int tempSum = 0;

                while (n > 0)
                {
                    //tempSum = tempSum + n % 10;
                    //n = n / 10;
                    tempSum += n % 10;
                    n /= 10;
                }

                n = tempSum;
            }

            Console.WriteLine(n);
        }
    }
}
