using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insiras as 4 notas, 1 por linha");
        var n1 = double.Parse(Console.ReadLine());
        var n2 = double.Parse(Console.ReadLine());
        var n3 = double.Parse(Console.ReadLine());
        var n4 = double.Parse(Console.ReadLine());
        var media = (n1 + n2 + n3 + n4) / 4;
        if (media >= 5)
        {
            Console.WriteLine("aprovado com média " + media);
        }
        else
        {
            Console.WriteLine("reprovado com média " + media);
        }

    }
}