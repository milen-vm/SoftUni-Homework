//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Enter the count of rows: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Enter the count columns: ");
        int c = int.Parse(Console.ReadLine());

        string[,] matrix = new string[r, c];

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
            }
        }

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}