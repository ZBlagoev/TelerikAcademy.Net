using System;

namespace Strings
{
    class Program
    {
        static void Main()
        {
			string text1 = "Hello, Telerik Academy";
			string text2 = "Hello, Telerik Academy";

			Console.WriteLine(Object.ReferenceEquals(text1, text2));

			text2 += "!";

			// text1 no longer points to the same memory as text
			Console.WriteLine(Object.ReferenceEquals(text1, text2));
		}
    }
}
