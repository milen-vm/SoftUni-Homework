using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Nullable int: " + a + "\nNullable double:" + b);
        a = 13;
        b = 3.142;
        Console.WriteLine("Nullable int, assigned value: " + a + "\nNullable double, assigned value: " + b);
    }
}