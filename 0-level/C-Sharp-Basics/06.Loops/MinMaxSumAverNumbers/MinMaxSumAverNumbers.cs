//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
using System;

class MinMaxSumAverNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter the count of the numbers: ");
        int num = int.Parse(Console.ReadLine());
        float min = 0f;
        float max = 0f;
        float sum = 0f;
        float avg;
        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " --> ");
            float numI = float.Parse(Console.ReadLine());
            if (i == 1)
            {
                min = max = numI;
            }
            if (numI < min)
            {
                min = numI;
            }
            if (numI > max)
            {
                max = numI;
            }
            sum += numI;
        }
        avg = sum / num;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}", min, max, sum, avg);
    }
}