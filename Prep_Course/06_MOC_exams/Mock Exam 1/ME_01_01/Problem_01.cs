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
            string holder = "";

            // calculation
            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            int sumFinal = sum;

            while (sumFinal > 9)
            {
                holder = sum.ToString();
                sum = 0;
                for (int i = 0; i < holder.Length; i++)
                {
                    sum += int.Parse(holder[i].ToString());
                }

                sumFinal = sum;
            }

            // output
            Console.WriteLine(sumFinal);
        }
    }
}
