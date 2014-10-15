//Write a method that calculates all prime numbers in given range and returns them as list of integers.
//Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line)
//and prints all primes in their range, separated by a comma.
using System;
using System.Collections.Generic;

 class PrimesInRange
    {
        static void Main()
        {
            Console.WriteLine("Enter two positive integer, defining the interval.");
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());
            PrintListOfPrimes(start, end);
        }
        static void PrintListOfPrimes(int startNum, int endNum)
        {
            List<int> lst = FindPrimesInRange(startNum, endNum);

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i]);
                if (i < lst.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> prime = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                double rootNum = Math.Sqrt((double)i);
                for (int iNum = 2; iNum <= rootNum; iNum++)
                {
                    if (i % iNum == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    prime.Add(i);
                }
            }
            return prime;
        }
    }