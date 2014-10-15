using System;
using System.Text;

public static class StringBuilderExtensionsTest
{
    static void Main()
    {
        StringBuilder strBuilder = new StringBuilder("Startpage does NOT record your IP address!");

        Console.WriteLine(strBuilder.Substring(5, 13));

        strBuilder.RemoveText("does not ");
        Console.WriteLine(strBuilder);

        int[] nums = { 4, 7, 9, 22, 34, 28 };
        strBuilder.AppendAll(nums);
        Console.WriteLine(strBuilder);
    }
}