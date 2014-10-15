//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

using System;

class CheckPlayCard
{
    static void Main()
    {
        Console.Write("Enter a play card character: ");
        string cardStr = Console.ReadLine();
        switch (cardStr)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine(cardStr + " yes");
                break;
            default:
                Console.WriteLine(cardStr + " no");
                break;
        }
        //int cardNum;                              //slightly more complicated way, before I discover an easier way :)
        //char cardChar;
        //string yesNo;
        //if (int.TryParse(cardStr, out cardNum))
        //{
        //    yesNo = (2 <= cardNum && cardNum <= 10) ? "yes" : "no";
        //}
        //else if (char.TryParse(cardStr, out cardChar))
        //{
        //    yesNo = (cardChar == 'J' || cardChar == 'Q' || cardChar == 'K' || cardChar == 'A') ? "yes" : "no";
        //}
        //else
        //{
        //    yesNo = "no";
        //}
        //Console.WriteLine(cardStr + " " + yesNo);
    }
}