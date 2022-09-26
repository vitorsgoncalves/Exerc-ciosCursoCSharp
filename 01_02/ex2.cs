using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("quantos anos?");
        int anos = int.Parse(Console.ReadLine());
        Console.WriteLine("quantos meses?");
        int meses = int.Parse(Console.ReadLine());
        Console.WriteLine("quantos dias?");
        int dias = int.Parse(Console.ReadLine()) - 1;

        dias += (meses * 30) + (anos * 365);

        Console.WriteLine("a indade em dias é " + dias);

    }
}

