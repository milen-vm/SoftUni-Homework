using System;

class sumOfnNumbers
{
    static void Main()
    {
        Console.Write("Enter the count of the numbers: ");
        int count = int.Parse(Console.ReadLine());
        float sum = 0.00f;
        for (int i = 1; i <= count; i++)
        {
            Console.Write(i + " --> ");
            sum += float.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}