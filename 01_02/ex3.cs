using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("quantas maçãs?");
        int macas = int.Parse(Console.ReadLine());
        var valor = macas * (macas >= 12 ? 1 : 1.3);

        Console.WriteLine(valor);

    }
}
