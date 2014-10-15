//Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
//If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. 
//Print the result at the console. Use switch statement. 

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Choose a type:");
        Console.WriteLine("1 --> int\n2 --> double\n3 --> string");
        int type = int.Parse(Console.ReadLine());
        switch (type)
        {   case 1:
                Console.Write("Please, enter a integer: ");
                int numInt = int.Parse(Console.ReadLine());
                Console.WriteLine(numInt + 1);
                break;
            case 2:
                Console.Write("Please, enter a double: ");
                double numDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(numDouble + 1);
                break;
            case 3:
                Console.Write("Please, enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + '\u002A');
                break;
            default:
                Console.WriteLine("Invalid type!");
                break;
        }
    }
}