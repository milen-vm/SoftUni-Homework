using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers separated by spece: ");
        string[] numbers = Console.ReadLine().Split();
        double a = Convert.ToDouble(numbers[0]);
        double b = Convert.ToDouble(numbers[1]);
        double c = Convert.ToDouble(numbers[2]);
        double d = Convert.ToDouble(numbers[3]);
        double e = Convert.ToDouble(numbers[4]);
        double sum = a + b + c + d + e;
        Console.WriteLine(sum);
    }
}