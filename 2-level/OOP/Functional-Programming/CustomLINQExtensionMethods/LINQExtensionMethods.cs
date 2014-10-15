using System;
using System.Collections.Generic;
using System.Linq;

public static class LINQExtensionMethods
{
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        return collection.Where(a => predicate(a));
    }

    public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
    {
        List<T> newColection = new List<T>();
        for (int i = 0; i < count; i++)
        {
            newColection.AddRange(collection);
        }

        return newColection;
    }

    public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
    {
        List<string> newColection = new List<string>();
        foreach (var item in collection)
        {
            bool isEndWith = false;

            foreach (var suffix in suffixes)
            {
                string subStr = item.Substring(item.Length - suffix.Length);
                if (subStr == suffix)
                {
                    isEndWith = true;
                }
            }

            if (isEndWith)
            {
                newColection.Add(item);
            }
        }

        return newColection;
    }


}
