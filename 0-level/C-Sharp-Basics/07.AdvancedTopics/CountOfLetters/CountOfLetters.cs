using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter the list of letters.");
        string[] letterList = Console.ReadLine().Split();
        letterList = letterList.OrderBy(d => d).ToArray();                      //sorting letters in array
        Dictionary<string, int> leterCount = new Dictionary<string, int>();
        string value = letterList[0];
        int counter = 0;
        for (int i = 0; i < letterList.Length; i++)
        {
            if (letterList[i] == value)
            {
                ++counter;
            }
            else
            {
                leterCount[value] = counter;
                value = letterList[i];
                counter = 1;
            }
            if (i == (letterList.Length - 1))
            {
                leterCount[value] = counter;
            }
        }
        foreach (var leter in leterCount)
        {
            Console.WriteLine("{0} -> {1}", leter.Key, leter.Value);
        }
    }
}