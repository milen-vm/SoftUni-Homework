using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}