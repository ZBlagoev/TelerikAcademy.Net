using System;

namespace Strings.Demos.Operations
{
    class Program
    {
        static void Main()
        {
			string text = "Telerik Academy";
			string text1 = "Telerik academy";
			Console.WriteLine("Equality with ==: " + text == text1);
			Console.WriteLine("Equals(): " + text.Equals(text1));
			Console.WriteLine("Equals() ignore case: " + text.Equals(text1, StringComparison.CurrentCultureIgnoreCase));
			Console.WriteLine("Compare(): " + string.Compare(text, text1, false));
			Console.WriteLine("Compare() ignore case: " + string.Compare(text, text1, true));
			Console.WriteLine("IndexOf() found: " + text.IndexOf('T'));
			Console.WriteLine("IndexOf() NOT found: " + text.IndexOf('t'));

			var splitSymbols = new char[] { ' ', ',' };

			// ["Telerik", "Academy"]
			string[] arr = text.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine("Length of the array: " + arr.Length);
			Console.WriteLine("Print array elements with string.Join(): " + string.Join(", ", arr));
		}
    }
}
