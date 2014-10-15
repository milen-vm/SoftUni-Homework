using System;

class AsyncTimerTest
{
    static void Main()
    {

        Action function = delegate()
        {
            Console.WriteLine("Repeating function.");
            Console.WriteLine();
        };

        AsyncTimer timerTest = new AsyncTimer(function, 10, 1000);

        timerTest.Repeat();
    }
}
