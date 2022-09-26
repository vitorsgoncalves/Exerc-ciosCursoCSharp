using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), "");
        Console.WriteLine("Digite o conteúdo do arquivo");
        List<string> lines = new List<string>();
        String linha;
        while (true)
        {
            linha = Console.ReadLine();
            if (linha == "fim" || linha == "FIM")
            {
                break;
            }
            lines.Add(linha);
        }
        File.AppendAllLines(Path.Combine(docPath, "WriteFile.txt"), lines);
    }
}