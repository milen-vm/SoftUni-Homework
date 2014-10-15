using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00a9';
        Console.WriteLine(new String(' ', 5) + copyright);
        Console.WriteLine(new String(' ', 4) + copyright + new String(' ', 1) + copyright);
        Console.WriteLine(new String(' ', 3) + copyright + new String(' ', 3) + copyright);
        Console.WriteLine(new String(' ', 2) + copyright + new String(' ', 5) + copyright);
        Console.WriteLine(new String(' ', 1) + copyright + new String(' ', 7) + copyright);
        Console.WriteLine(" " + new String(copyright, 9));
    }
}