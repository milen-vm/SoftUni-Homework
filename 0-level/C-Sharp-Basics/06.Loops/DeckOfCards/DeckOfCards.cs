//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
using System;

class DeckOfCards
{
    static void Main()
    {
        for (int iNum = 2; iNum <= 14; iNum++)
        {
            for (int iCol = 3; iCol <= 6; iCol++)
            {
                if (iNum <= 10)
                {
                    Console.Write("{0,4}{1}", iNum, (char)iCol);
                }
                else
                {
                    char iChar = '0';
                    switch (iNum)
                    {
                        case 11: iChar = 'J'; break;
                        case 12: iChar = 'Q'; break;
                        case 13: iChar = 'K'; break;
                        case 14: iChar = 'A'; break;
                        default:
                            break;
                    }
                    Console.Write("{0,4}{1}", iChar, (char)iCol);
                }
            }
            Console.WriteLine();
        }
    }
}