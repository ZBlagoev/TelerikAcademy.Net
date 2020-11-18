using System;

namespace ME_01_01
{
    class Problem_01
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();
            input = input.Replace(".", "");
            input = input.Replace("-", "");

            int sum = 0;

            // calculation
            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            int sumFinal = sum;
            string sumString = sum.ToString();

            

            while (sumFinal > 9)
            {
                sumString = sum.ToString();
                sum = 0;

                for (int i = 0; i < sumString.Length; i++)
                {
                    sum += int.Parse(sumString[i].ToString());
                    
                }

                sumFinal = sum;
            }


            // output 
            Console.WriteLine(sumFinal);
        }
    }
}
