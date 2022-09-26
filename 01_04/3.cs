
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma sequencia de caracteres sem espaço");
        string entrada = Console.ReadLine();
        Stack<char> pilha = new Stack<char>();
        foreach (char caractere in entrada)
        {
            pilha.Push(caractere);
        }
        string contrario = "";
        foreach (char caractere in pilha)
        {
            contrario += caractere;
        }
        Console.WriteLine("caracteres ao contrário: " + contrario);
        if (contrario == entrada)
        {
            Console.WriteLine("a sequência é palíndroma");
        }
        else
        {
            Console.WriteLine("a sequência não é palíndroma");
        }

    }
}