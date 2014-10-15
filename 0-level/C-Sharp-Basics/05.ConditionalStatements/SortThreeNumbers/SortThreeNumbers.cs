//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. 
//Don’t use arrays and the built-in sorting functionality.

using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        Console.Write("a = ");
        float numA = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float numB = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float numC = float.Parse(Console.ReadLine());
        float big1;
        float big2;
        float big3;
        if (numA > numB)
        {
            if (numA > numC)
            {
                big1 = numA;

                if (numC > numB)
                {
                    big2 = numC;
                    big3 = numB;
                }
                else
                {
                    big2 = numB;
                    big3 = numC;
                }
            }
            else
            {
                big1 = numC;
                big2 = numA;
                big3 = numB;                  
            } 
        }
        else
        {
            if (numB > numC)
            {
                big1 = numB;

                if (numA > numC)
                {
                    big2 = numA;
                    big3 = numC;
                }
                else
                {
                    big2 = numC;
                    big3 = numA;
                }
            }
            else
            {
                big1 = numC;
                big2 = numB;
                big3 = numA;
            }
        }

        Console.WriteLine("Numbers in descending order: {0} {1} {2}", big1, big2, big3);
    }
}