using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o nome do arquivo ou caminho completo");
        string caminho = Console.ReadLine();
        try
        {
            foreach (string linha in System.IO.File.ReadLines(caminho))
            {
                System.Console.WriteLine(linha);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado");
        }

        Console.ReadKey();
    }
}