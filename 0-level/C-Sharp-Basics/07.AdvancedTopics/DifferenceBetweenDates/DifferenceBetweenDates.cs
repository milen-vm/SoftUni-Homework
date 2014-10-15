//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Enter two dates in format dd.MM.yyy:");
        Console.Write("First date: ");
        DateTime firstaDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Difference between dates is {0} days.", (secondDate - firstaDate).TotalDays);
    }
}