using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        decimal amountOfMoney = 5145.45M;
        string bankName = "BDS AD";
        object iban = "BG10BDSB91558120002006";
        object creditCardOne = "3258 4756 2364 9821";
        object creditCardTwo = "5623 4712 5473 5478";
        object creditCardThree = "3314 8541 2213 6489";
        Console.WriteLine(bankName + " Bank account holder:");
        Console.WriteLine("Firs name: " + firstName);
        Console.WriteLine("Middle name: " + middleName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Account balance: " + amountOfMoney + "$"); 
        Console.WriteLine("Account number: " + iban);
        Console.WriteLine("First credit card: " + creditCardOne);
        Console.WriteLine("Second credit card: " + creditCardTwo);
        Console.WriteLine("Third credit card: " + creditCardThree);
    }
}