using System;

class EnterNumbers
{
    static void Main()
    {
        double startNum = 0;
        bool isValidNumber = true;
        do
        {
            Console.Write("Enter start number: ");
            isValidNumber = true;
            
            try
            {
                startNum = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter valid number!");
                isValidNumber = false;
            }
        }
        while (!isValidNumber);      
        
        double endNum = 0;
        do
        {
            Console.Write("Enter end number: ");
            isValidNumber = true;

            try
            {
                endNum = Double.Parse(Console.ReadLine());

                if (startNum > endNum)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter valid number!");
                isValidNumber = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The end number must be bigger than the start one!");
                isValidNumber = false;
            }
        }
        while (!isValidNumber);
        //Console.WriteLine(startNum + "\n" + endNum);

        ReadNumber(startNum, endNum);
    }

    public static void ReadNumber(double start, double end)
    {
        Console.WriteLine("Enter 10 numbers in range [{0} ... {1}],\nso that every next number is greater than the previous.", start, end);
        double[] numbers = new double[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Num {0} = ", i + 1);
            double tempNum = 0;

            try
            {
                tempNum = Double.Parse(Console.ReadLine());

                if (tempNum < start || tempNum > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter valid number!");
                --i;
                continue;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number must be in range [{0}...{1}].", start, end);
                --i;
                continue;
            }

            if (i > 0)
            {
                if (tempNum <= numbers[i - 1])
                {
                    Console.WriteLine("The number must be bigger than {0}.", numbers[i - 1]);
                    --i;
                    continue;
                }
            }

            numbers[i] = tempNum;
        }

        PrintNumbers(numbers);
    }

    public static void PrintNumbers(double[] nums)
    {
        Console.WriteLine("\nYou are entered the following numbers:\n");
        Console.Write("[ ");

        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }

        Console.Write("]\n");
    }
}
