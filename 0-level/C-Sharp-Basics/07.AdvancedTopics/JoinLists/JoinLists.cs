using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Enter the first list.");
        string[] firstList = Console.ReadLine().Split();
        Console.WriteLine("Enter the second list.");
        string[] secondList = Console.ReadLine().Split();
        List<int> unique = new List<int>();

        for (int i = 0; i < firstList.Length; i++)
        {
            unique.Add(int.Parse(firstList[i].ToString()));
        }
        for (int i = 0; i < secondList.Length; i++)
        {
            unique.Add(int.Parse(secondList[i].ToString()));
        }
       for (int i = 0; i < unique.Count - 1; i++)
		{
			 for (int j = i + 1; j < unique.Count; j++)
			{
                if (unique[i] == unique[j])
                {
                    unique.RemoveAt(j);
                }
			}
		}
        unique.Sort();
        for (int i = 0; i < unique.Count; i++)
        {
            Console.Write("{0} ", unique[i]);
        }
        Console.WriteLine();
    }
}