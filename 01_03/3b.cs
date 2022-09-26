using System;
class Program
{
    static int Main()
    {
        Console.WriteLine("Insiras as 4 notas, 1 por linha");
        var n1 = double.Parse(Console.ReadLine());
        var n2 = double.Parse(Console.ReadLine());
        var n3 = double.Parse(Console.ReadLine());
        var n4 = double.Parse(Console.ReadLine());
        var media = (n1 + n2 + n3 + n4) / 4;
        if (media >= 7)
        {
            Console.WriteLine("aprovado com média " + media);
            return 0;
        }
        Console.WriteLine("insira a nota do exame");
        var ex = double.Parse(Console.ReadLine());
        var media2 = (media + ex) / 2;
        if (media2 >= 5)
        {
            Console.WriteLine("aprovado em exame com média " + media2);
        }
        else
        {
            Console.WriteLine("reprovado com média " + media2);
        }
        return 0;

    }
}