using System;

class ModifyABit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));
        Console.Write("Enter bit position to modify: ");
        int posBit = int.Parse(Console.ReadLine());
        Console.Write("Enter the new value, 0 or 1: ");
        int valBit = int.Parse(Console.ReadLine());
            if(valBit == 0 || valBit == 1)
            {
                if(valBit == 1)
                {
                    int mask = 1 << posBit;
                    int resultNum = num | mask;
                    Console.WriteLine("The resulting integer is " + resultNum + " binary " + (Convert.ToString(resultNum, 2).PadLeft(16, '0')));
                }
                else
                {
                    int mask = ~(1 << posBit);
                    int resultNum = num & mask;
                    Console.WriteLine("The resulting integer is " + resultNum + " binary " + (Convert.ToString(resultNum, 2).PadLeft(16, '0')));
                }
            }
            else
            {
                Console.WriteLine("You have entered incorrect value!");
            }
    }
}