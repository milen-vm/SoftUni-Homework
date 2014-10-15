//Write a program that finds the biggest of three numbers. 

using System;

    class BiggestOfThree
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers:");
            Console.Write("a = ");
            float numA = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float numB = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float numC = float.Parse(Console.ReadLine());
            float biggest;
            if (numA > numB)
            {
                if (numA > numC)
                {
                    biggest = numA;
                }
                else
                {
                    biggest = numC;
                }
            }
            else
            {
                if (numB > numC)
                {
                    biggest = numB;
                }
                else
                {
                    biggest = numC;
                }
            }
            Console.WriteLine("Biggest number is: " + biggest);
        }
    }