using System;

namespace hw1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Contains
            // EndsWith
            // IndexOfAny
            // Insert
            // LastIndexOf
            // LastIndexOfAny
            // PadLeft
            // PadRight
            // StartsWidth
            // Substring
            // Trim
            string myString = "Kevin Le";
            Console.WriteLine(myString.Contains("vin"));
            Console.WriteLine(myString.EndsWith("vin"));
            Console.WriteLine(myString.IndexOfAny(new char[] { 'a', 'i', 'o', 'u' }));
            Console.WriteLine(myString.Insert(myString.Length, " Le"));
            Console.WriteLine(myString.LastIndexOf("ahh"));
            Console.WriteLine(myString.PadLeft(20, '.'));
            Console.WriteLine("Tommy Khang Tran".PadLeft(20, '.'));
            Console.WriteLine(myString.PadRight(20, '.'));
            Console.WriteLine("Tommy Khang Tran".PadRight(20, '.'));
            Console.WriteLine(myString.PadRight(20, '.').PadLeft(30, '.'));
            Console.WriteLine("Tommy Khang Tran".PadRight(20, '.').PadLeft(30, '.'));
            Console.WriteLine(myString.StartsWith('k'));
            Console.WriteLine(myString.StartsWith("Kev"));
            Console.WriteLine(myString.Substring(2));
            Console.WriteLine(myString.Substring(2, 3));
            Console.WriteLine("Tommy Khang Tran".PadRight(20, '.').PadLeft(30, '.').Trim('.'));
            Console.WriteLine("Tommy Khang Tran".PadRight(20, '.').PadLeft(30, '!').Trim(new char[] { '.', '!'}));
            Console.WriteLine("Tommy Khang Tran".PadRight(20, '.').PadLeft(30, '.').TrimStart('.'));
            Console.WriteLine("Tommy Khang Tran".PadRight(20, '.').PadLeft(30, '.').TrimEnd('.'));
        }
    }
}
