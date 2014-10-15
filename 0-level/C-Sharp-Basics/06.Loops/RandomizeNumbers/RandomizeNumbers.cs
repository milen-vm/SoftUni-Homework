//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
using System;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        int[] numbers = new int[num];
        Random rnd = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            int swapPos = rnd.Next(0, (num - i));
            int temp = numbers[i];
            numbers[i] = numbers[swapPos];
            numbers[swapPos] = temp;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}