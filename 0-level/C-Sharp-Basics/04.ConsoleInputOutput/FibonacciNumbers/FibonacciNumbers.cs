using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter the count of Fibonacci numbers: ");
        int count = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        //c = 0;
        Console.Write(a + " " + b);
        for (int i = 1; i <= count - 2; i++)
        {
            Console.Write(" " + (a + b));
            if (a < b)
            {
                a = a + b;
            }
            else
            {
                b = a + b;
            }
            //c = a + b;                //second variant without if statement
            //a = b;
            //b = c;
            //Console.Write(" " + c);
        }
        Console.WriteLine();
    }
}
