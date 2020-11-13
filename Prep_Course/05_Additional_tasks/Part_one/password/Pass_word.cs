using System;
using System.Linq;

namespace password
{
    class Pass_word
    {
        static void Main(string[] args)
        {
            //var sw = System.Diagnostics.Stopwatch.StartNew();

            // input
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result;

            int reverse = 0;
            int rem;

            // calculation
            while (numbers[0] != 0)
            {
                rem = numbers[0] % 10;
                reverse = reverse * 10 + rem;
                numbers[0] /= 10;
            }
            numbers[0] = reverse;

            result = numbers[0] / numbers[1] + numbers[0] % numbers[1];

            // output
            Console.WriteLine(result);

            //sw.Stop();
            //Console.WriteLine($"Operation took {sw.ElapsedMilliseconds}ms");
        }
    }
}
