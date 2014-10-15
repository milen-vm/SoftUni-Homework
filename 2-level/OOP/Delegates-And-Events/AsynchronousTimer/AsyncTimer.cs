using System;
using System.Threading;

public class AsyncTimer
{
    private Action function;
    private int count;
    private int delay;

    public AsyncTimer(Action function, int count, int delay)
    {
        this.function = function;
        this.count = count;
        this.delay = delay;
    }

    public void Repeat()
    {
        for (var i = 0; i < count; i++)
        {
            Console.Write((i + 1) + " ");
            function();
            Thread.Sleep(this.delay);
        }
    }
}
