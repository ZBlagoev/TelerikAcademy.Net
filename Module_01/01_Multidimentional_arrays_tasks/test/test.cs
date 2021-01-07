using System;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        int sameCharCounter = 1;
        int maxSequence = 1;
        int index = 0;
        int length = 1;

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == str[i - 1])
            {
                sameCharCounter++;
            }
            else
            {
                if (sameCharCounter > maxSequence)
                {
                    maxSequence = sameCharCounter;
                    index = i - sameCharCounter;
                    length = sameCharCounter;
                }

                sameCharCounter = 1;
            }
        }

        if (maxSequence >= 2)
        {
            Console.WriteLine(str.Substring(index, length));
        }
    }
}

 