//Write a program that takes as input two lists of names and removes from the first list all names given in the second list.
//The input and output lists are given as words, separated by a space, each list at a separate line.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Enter the first list.");
        string[] firstList = Console.ReadLine().Split();
        Console.WriteLine("Enter the second list.");
        string[] secondList = Console.ReadLine().Split();

        List<string> unique = new List<string>();
                
        for (int i = 0; i < firstList.Length; i++)
        {
            if (!(secondList.Contains(firstList[i])))
            {
                unique.Add(firstList[i]);
            }
        }
        if (unique.Count == 0)
        {
            return;
        }
        else
        {
            for (int i = 0; i < unique.Count; i++)
            {
                Console.Write("{0} ", unique[i]);
            }
            Console.WriteLine();
        }
    }
}