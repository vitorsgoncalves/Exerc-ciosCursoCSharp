using System;
class Program
{
    static void Main()
    {
        var a = 10;
        var b = 20;
        var c = b;
        b = a;
        a = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
