//Write an if-statement that takes two integer variables a and b and exchanges their values if 
//the first one is greater than the second one. As a result print the values a and b, separated by a space. Examples:

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        Console.Write("a = ");
        float numA = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float numB = float.Parse(Console.ReadLine());
        if (numA > numB)
        {
            numA = numA + numB;
            numB = numA - numB;
            numA = numA - numB;
        }
        Console.WriteLine("a = {0}\nb = {1}", numA, numB);
    }
}