//Write a program to find the longest area of equal elements in array of strings. 
//You first should read an integer n and n strings (each at a separate line), 
//then find and print the longest sequence of equal elements (first its length, then its elements). 
//If multiple sequences have the same maximal length, print the leftmost of them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] area = new string[n];

        for (int i = 0; i < area.Length; i++)
        {
            Console.Write(i + 1 + (" --> "));
            area[i] = Console.ReadLine();
        }
        int curentCount = 1;
        int maxCount = 0;
        string value = area[0];
        int curentStartIndex = 0;
        int maxStartIndex = 0;

        for (int i = 1; i < area.Length; i++)
        {
            if (area[i] == value)
            {
                ++curentCount;
                continue;
            }
            if (curentCount > maxCount)
            {
                maxCount = curentCount;
                maxStartIndex = curentStartIndex;
            }
            curentStartIndex = i;
            curentCount = 1;
            value = area[i];
        }
        if (curentCount > maxCount)
        {
            maxCount = curentCount;
            maxStartIndex = curentStartIndex;
        }
        Console.WriteLine(maxCount);
        for (int i = maxStartIndex; i < (maxStartIndex + maxCount); i++)
        {
            Console.WriteLine(area[i]);
        }
    }
}