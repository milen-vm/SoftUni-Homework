using System;

class PrintASequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {

            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                if (i == 1001)
                {
                    Console.WriteLine(-i);
                    break;
                }
                Console.Write(-i + ", ");
            }
        }
    }
}