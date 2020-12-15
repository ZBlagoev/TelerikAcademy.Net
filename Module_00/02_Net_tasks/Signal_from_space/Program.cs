/*
Signal from Space
One day a signal from space was registered. Scientists managed to record the signal as a sequence of N symbols. 
It turned out that due to a technical difficulty some symbols have been repeated. Help the scientists by writing 
a program which removes consecutive repetitions of symbols, decoding the message.

Input
Input data is read from the standard input

On the only input line, a message is given
Output
Print to the standard output

Print the decoded message
Constraints
The length of the message will be no more than 10000 symbols
Message consists of digits and Latin letters (upper and lower case)
*/

using System;
using System.Text;

namespace Signal_from_space
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MessageDecoder(Console.ReadLine());
        }

        static void MessageDecoder(string input)
        {
            StringBuilder message = new StringBuilder();

            message.AppendFormat(input);

            for (int i = input.Length - 1; i > 0; i--)
            {
                if (message[i] == message[i - 1])
                {
                    message.Remove(i, 1);
                }
            }

            Console.WriteLine(message.ToString());
        }
    }
}
