using System;

class GenericListExample
{
    static void Main()
    {
        GenericList<int> nums = new GenericList<int>(5);
        nums.Add(14);
        nums.Add(8);
        nums.Add(3);
        nums.Add(22);
        nums.Add(25);

        Console.WriteLine(nums);
        Console.WriteLine("Element at index 3 is: {0}.\n", nums[3]);

        nums.Remove(3);
        Console.WriteLine("Removing element at index 3.");
        Console.WriteLine(nums);
        Console.WriteLine();

        nums.Insert(17, 2);
        Console.WriteLine("Inserting 17 at index 2.");
        Console.WriteLine(nums);
        Console.WriteLine();

        Console.WriteLine("Index of value 8 is: {0}.\n", nums.GetIndex(8));

        Console.WriteLine("Checking if the list contains a value 54: {0}.\n", nums.Contains(54));

        Console.WriteLine("Max value in the list: {0}.", nums.Max());
        Console.WriteLine("Min value in the list: {0}.\n", nums.Min());

        nums.Clear();
        Console.WriteLine("Clearing the list.");
        Console.WriteLine(nums);

        Type type = typeof(GenericList<>);
        object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
        Console.WriteLine("GenericsList's version is {0}", ((VersionAttribute)allAttributes[0]).Version);
    }
}
