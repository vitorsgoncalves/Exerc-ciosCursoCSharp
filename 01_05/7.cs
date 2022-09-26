using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
    inicio:
        Console.WriteLine("insira um número inteiro");
        string s = Console.ReadLine();
        try
        {
            int i = int.Parse(s);
        }
        catch (FormatException)
        {
            Console.WriteLine("inteiro não reconhecido");
            goto inicio;
        }

    }
}