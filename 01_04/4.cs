using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Queue<string> pessoas = new Queue<string>();
        Queue<int> senhas = new Queue<int>();
        int senhaInicial = 171;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Bem vindo. Qual seu nome?");
            pessoas.Enqueue(Console.ReadLine());
            senhas.Enqueue(senhaInicial + i);
            Console.WriteLine("Sua senha é " + (senhaInicial + 1) + ". Por favor, aguarde o atendimento");
        }
        //chamando
        Console.WriteLine();
        while (senhas.Count() > 0)
        {
            Console.WriteLine("Sr(a) " + pessoas.Dequeue() + ", favor comparecer e apresentar a senha " + senhas.Dequeue() );
        }
    }
}