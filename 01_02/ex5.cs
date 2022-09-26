using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("insira o vetor de 3 numeros");
        string x = Console.ReadLine();

        string[] y = x.Split(" ");
        
        List<float> f = new List<float>();

        foreach(var numero in y){
            f.Add(float.Parse(numero));
        }

        Console.WriteLine(f[0]);
        Console.WriteLine(f[1]);
        Console.WriteLine(f[2]);

    }
}
