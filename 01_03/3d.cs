using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira 3 números inteiros, 1 a cada linha");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int[] numeros = { n1, n2, n3 };
        int soma = n1 + n2 + n3;
        int menor = 2147483647; //maior int possível
        int maior = 0;
        foreach (int n in numeros)
        {
            if (n > maior)
            {
                maior = n;
            }
            if (n < menor)
            {
                menor = n;
            }
        }
        Console.WriteLine(menor);
        Console.WriteLine(soma - maior - menor);
        Console.WriteLine(maior);

    }
}