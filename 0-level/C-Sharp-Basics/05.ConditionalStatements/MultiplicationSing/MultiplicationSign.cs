using System;
class MultiplicationSign
{
 //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
 //    Use a sequence of if operators.

    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        Console.Write("a = ");
        float numA = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float numB = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float numC = float.Parse(Console.ReadLine());
        string sign = null;
        if (numA > 0 && numB > 0 && numC > 0)
        {
            sign = "+";
        }
        else if (numA < 0 && numB < 0 && numC < 0)
        {
            sign = "-";
        }
        else if (numA == 0 || numB == 0 || numC == 0)
        {
            sign = "0";
        }
        else if ((numA < 0 && numB > 0 && numC > 0) || (numA > 0 && numB < 0 && numC > 0) || (numA > 0 && numB > 0 && numC < 0))
        {
            sign = "-";
        }
        else if ((numA < 0 && numB < 0 && numC > 0) || (numA > 0 && numB < 0 && numC < 0) || (numA < 0 && numB > 0 && numC < 0))
        {
            sign = "+";
        }
        Console.WriteLine("The sign of the product of the three numbers is \"{0}\".", sign);
    }
}