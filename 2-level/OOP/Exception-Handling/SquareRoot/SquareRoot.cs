using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter positive integer: ");

        try
        {
           int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                throw new ArgumentException();
            }

            double sqrRoot = Math.Sqrt(num);

            Console.WriteLine("Square root of {0} is {1}", num, sqrRoot);
        }
        catch
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}