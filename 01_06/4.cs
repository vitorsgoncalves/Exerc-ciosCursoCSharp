using System;
class Program
{
    static void Main(string[] args)
    {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        System.Console.WriteLine("LISTA DOS 10 MAIORES ARQUIVOS");
        try
        {
            foreach (string linha in System.IO.File.ReadLines(Path.Combine(docPath, "maiores.txt")))
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