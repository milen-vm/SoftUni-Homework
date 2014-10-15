//Write a program that finds the biggest of five numbers by using only five if statements. 

using System;

    class BiggestOfFive
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers:");
            Console.Write("a = ");
            float numA = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float numB = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float numC = float.Parse(Console.ReadLine());
            Console.Write("d = ");
            float numD = float.Parse(Console.ReadLine());
            Console.Write("e = ");
            float numE = float.Parse(Console.ReadLine());
            if (numA >= numB && numA >= numC && numA >= numD && numA >= numE)
            {
                Console.WriteLine("The biggest number is " + numA + ".");
            }
            else if (numB >= numA && numB >= numC && numB >= numD && numB >= numE)
            {
                Console.WriteLine("The biggest number is " + numB + ".");
            }
            else if (numC >= numA && numC >= numB && numC >= numD && numC >= numE)
            {
                Console.WriteLine("The biggest number is " + numC + ".");
            }
            else if (numD >= numA && numD >= numB && numD >= numC && numD >= numE)
            {
                Console.WriteLine("The biggest number is " + numD + ".");
            }
            else if (numE >= numA && numE >= numB && numE >= numC && numE >= numD)
            {
                Console.WriteLine("The biggest number is " + numE + ".");
            }
        }
    }