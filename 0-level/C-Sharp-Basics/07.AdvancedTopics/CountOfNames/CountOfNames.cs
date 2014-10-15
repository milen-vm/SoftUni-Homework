using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Enter the list of names.");
        string[] namesList = Console.ReadLine().Split();
        namesList = namesList.OrderBy(d => d).ToArray();                      //sorting names in array
        Dictionary<string, int> namesCount = new Dictionary<string, int>();
        string value = namesList[0];
        int counter = 0;
        for (int i = 0; i < namesList.Length; i++)
        {
            if (namesList[i] == value)
            {
                ++counter;
            }
            else
            {
                namesCount[value] = counter;
                value = namesList[i];
                counter = 1;
            }
            if (i == (namesList.Length - 1))
            {
                namesCount[value] = counter;
            }
        }
        foreach (var name in namesCount)
        {
            Console.WriteLine("{0} -> {1}", name.Key, name.Value);
        }
    }
}