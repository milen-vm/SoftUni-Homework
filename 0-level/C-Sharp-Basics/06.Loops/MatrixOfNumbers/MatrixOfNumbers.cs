//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix. Use two nested loops.
using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer \"n\", 1 <= n <= 20.");
            int n;
            do
            {
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
            }
            while (!(n >= 1 && n <= 20));
            for (int col = 1; col <= n; col++)
            {
                for (int row = col; row <= col + n - 1; row++)
                {
                    Console.Write(row + " ");
                   
                }
                Console.WriteLine();
            }
        }
    }