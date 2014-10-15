using System;

class StringsAndObjects
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World!";
        object obj1;
        obj1 = str1 + " " + str2;
        string str3 = (string)obj1;
        Console.WriteLine(str3);    
    }
}