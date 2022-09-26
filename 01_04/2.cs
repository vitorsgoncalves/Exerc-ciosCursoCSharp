using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira a lista de valores inteiros");
        string entrada = Console.ReadLine();
        string[] lista = entrada.Split(" ");
        HashSet<int> listaUnicos = new HashSet<int>();
        foreach (string elemento in lista)
        {
            try
            {
                listaUnicos.Add(int.Parse(elemento));
            }
            catch (Exception)
            {
                Console.WriteLine("entrada de dados inválida");
            }
        }
        foreach (int valor in listaUnicos)
        {
            Console.WriteLine(valor);
        }
    }
}