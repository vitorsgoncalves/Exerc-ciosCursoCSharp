using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("quantas horas?");
        int horas = int.Parse(Console.ReadLine());

        Console.WriteLine("quantas horas extras?");
        int horasEx = int.Parse(Console.ReadLine());

        var bruto = (horas * 10) + (horasEx * 15);
        var liq = bruto * 0.9;

        Console.WriteLine("valor bruto");
        Console.WriteLine(bruto);
        Console.WriteLine("valor liquido");
        Console.WriteLine(liq);

    }
}

