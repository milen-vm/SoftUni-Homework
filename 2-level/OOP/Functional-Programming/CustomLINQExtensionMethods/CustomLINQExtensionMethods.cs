using System;
using System.Collections.Generic;

class CustomLINQExtensionMethods
{
    static void Main()
    {
        string[] numbersStr = { "one", "two", "three", "four" };

        Func<string, bool> func =
            delegate(string item)
            {
                return !(item == "two");
            };

        Console.WriteLine(string.Join(", ", numbersStr.WhereNot(func)));

        Console.WriteLine(string.Join(", ", numbersStr.Repeat(2)));

        string[] suffixes = { "ne", "ee" };
        Console.WriteLine(string.Join(", ", numbersStr.WhereEndsWith(suffixes)));
    }
}
