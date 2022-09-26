using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o diretorio");
        string caminho = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Conteúdo:");
        DirectoryInfo pasta = new DirectoryInfo(caminho);
        List<KeyValuePair<string, long>> maiores = new List<KeyValuePair<string, long>>();
        //lista os arquivos do riretório
        foreach (var arquivo in pasta.GetFiles())
        {
            System.Console.WriteLine(arquivo.Name);
            // armazena os arquivos em ordem decrescente de tamanho
            int pos = 0;
            foreach (KeyValuePair<string, long> salvo in maiores)
            {
                if (salvo.Value > arquivo.Length)
                {
                    pos += 1;
                }
            }
            KeyValuePair<string, long> insercao = new KeyValuePair<string,
            long>(Path.Combine(caminho, arquivo.Name), arquivo.Length);
            maiores.Insert(pos, insercao);
        }
        //lista os subdiretórios
        foreach (var dir in pasta.GetDirectories())
        {
            System.Console.WriteLine(dir.Name);
            DirectoryInfo subPasta = new DirectoryInfo(Path.Combine(caminho, dir.Name));
            //lista o conteúdo dos subdiretórios
            try
            {
                foreach (var subArquivo in subPasta.GetFiles())
                {
                    System.Console.WriteLine("|_________" + subArquivo.Name);
                    // armazena os arquivos em ordem decrescente de tamanho
                    int pos = 0;
                    foreach (KeyValuePair<string, long> salvo in maiores)
                    {

                        if (salvo.Value > subArquivo.Length)
                        {
                            pos += 1;
                        }
                    }
                    KeyValuePair<string, long> insercao = new KeyValuePair<string,
                    long>(Path.Combine(caminho, subArquivo.Name), subArquivo.Length);
                    maiores.Insert(pos, insercao);

                }
                foreach (var subDir in subPasta.GetDirectories())
                {
                    System.Console.WriteLine("|_________" + subDir.Name);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
        //armazena a lista dos 10 maiores no arquivo
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        File.WriteAllText(Path.Combine(docPath, "maiores.txt"), "");
        List<string> lines = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            lines.Add(maiores[i].Key + " " + maiores[i].Value + " bytes");
        }
        File.AppendAllLines(Path.Combine(docPath, "maiores.txt"), lines);

    }

}