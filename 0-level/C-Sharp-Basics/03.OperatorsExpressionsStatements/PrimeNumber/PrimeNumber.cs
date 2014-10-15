using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a integer between 1 and 100: ");
        int num = int.Parse(Console.ReadLine());
        bool prime = true;
            if (num <= 0)
            {
                Console.WriteLine("You have entered wrong number");
            }
            int rootNum = (int)Math.Sqrt(num);              //The most basic method of checking the primality of a given integer n is called trial division.
                                                            //This routine consists of dividing n by each integer m that is greater than 1 and less than or equal to the square root of n.
            for (int i = 2; i <= rootNum; i++)              //If the result of any of these divisions is an integer, then n is not a prime, otherwise it is a prime
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
       Console.WriteLine("Is the number {0} prime? {1}", num, prime);
    }
}