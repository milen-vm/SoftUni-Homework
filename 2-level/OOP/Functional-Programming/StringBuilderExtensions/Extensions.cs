using System;
using System.Collections.Generic;
using System.Text;

public static class Extensions
{
    public static string Substring(this StringBuilder strBuild, int startIndex, int length)
    {
        if (startIndex + length > strBuild.Length)
        {
            throw new IndexOutOfRangeException("Invalid index or length!");
        }

        string result = strBuild.ToString(startIndex, length);
        return result;
    }

    public static StringBuilder RemoveText(this StringBuilder strBuild, string str)
    {
        if (str == "")
        {
            throw new ArgumentException("Invalid substring!");
        }

        int subLength = str.Length;

        for (int i = 0; i <= strBuild.Length - subLength; i++)
        {
            string subStr = strBuild.Substring(i, subLength);

            if (subStr.ToLower() == str.ToLower())
            {
                strBuild.Remove(i, subLength);
                --i;
            }
        }

        return strBuild;
    }

    public static StringBuilder AppendAll<T>(this StringBuilder strBuild, IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            strBuild.Append(item.ToString() + ",");
        }

        strBuild.Remove(strBuild.Length - 1, 1);

        return strBuild;
    }
}
