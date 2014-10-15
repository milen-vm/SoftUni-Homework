//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 
using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter \"n\" integers separated by spece: ");
        string[] numbers = Console.ReadLine().Split();
        int oddProd = 1;
        int evenProd = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = Convert.ToInt32(numbers[i]);
            if (i % 2 == 0)
            {
                evenProd *= num;
            }
            else
            {
                oddProd *= num;
            }
        }
        if (evenProd == oddProd)
        {
            Console.WriteLine("Is even elements and odd elements product equal?");
            Console.WriteLine("yes\n" + "Product = " + oddProd);
        }
        else
        {
            Console.WriteLine("Is even and odd product equal?");
            Console.WriteLine("no\n" + "Odd product = " + oddProd + "\nEven product = " + evenProd);
        }
    }
}