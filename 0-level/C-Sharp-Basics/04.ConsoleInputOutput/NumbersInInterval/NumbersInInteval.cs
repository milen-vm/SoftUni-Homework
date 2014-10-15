using System;
using System.Collections.Generic;                               //adding library for the class List<>

    class NumbersInInterval
    {
        static void Main()
        {
            Console.WriteLine("Enter two positive integer, defining the interval.");
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();                 //creating list of integers to store the numbers divisible of 5
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    numbers.Add(i);                              //adding integer to the list
                }
            }
            Console.WriteLine("Integers, divisible into 5.");
            Console.Write(numbers.Count + " --> ");              //printing the count of integers in the list
            //foreach (int divisible in numbers)
            //{
            //    Console.Write(divisible + " ");                 //printing the content of the list
            //}
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1)
                {
                    Console.Write(numbers[i] + ", ");
                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }
            Console.WriteLine();
        }
    }