//Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string.
//The output should be a variable of type long. Do not use the built-in .NET functionality.
using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine();
        long dec = 0L;
        for (int i = hex.Length - 1, power = 0; i >= 0; i--, power++)       //https://bg.wikipedia.org/wiki/%D0%A8%D0%B5%D1%81%D1%82%D0%BD%D0%B0%D0%B4%D0%B5%D1%81%D0%B5%D1%82%D0%B8%D1%87%D0%BD%D0%B0_%D0%B1%D1%80%D0%BE%D0%B9%D0%BD%D0%B0_%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B0#.D0.9E.D1.82_.D0.A8.D0.B5.D1.81.D1.82.D0.BD.D0.B0.D0.B4.D0.B5.D1.81.D0.B5.D1.82.D0.B8.D1.87.D0.BD.D0.B0_.D0.B2_.D0.94.D0.B5.D1.81.D0.B5.D1.82.D0.B8.D1.87.D0.BD.D0.B0
        {
            int temp = 0;
                switch (hex[i])
                {
                    case 'A':
                        temp = 10;
                        break;
                    case 'B':
                        temp = 11;
                        break;
                    case 'C':
                        temp = 12;
                        break;
                    case 'D':
                        temp = 13;
                        break;
                    case 'E':
                        temp = 14;
                        break;
                    case 'F':
                        temp = 15;
                        break;
                    default: 
                        temp = Convert.ToInt32(hex[i].ToString());
                        break;
                }
                dec += temp * (long)Math.Pow(16, power);
        }
        Console.WriteLine("Decimal: " + dec);
    }
}