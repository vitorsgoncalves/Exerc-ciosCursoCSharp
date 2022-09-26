using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira um número inteiro não negativo");
        int numero = int.Parse(Console.ReadLine());
        int fatorial = 1;
        while (numero > 1)
        {
            fatorial *= numero;
            numero--;
        }
        Console.WriteLine("O fatorial é " + fatorial);
    }
}