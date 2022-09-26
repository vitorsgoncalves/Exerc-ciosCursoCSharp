using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira do dados abaixo ou pressione Ctrl+D para sair");
        int[] vetor = new int[10];
        int valor, pos;
        while (true)
        {
            try
            {
                Console.WriteLine("qual valor?");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("qual posição?");
                pos = int.Parse(Console.ReadLine());
                vetor[pos] = valor;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Posição fora do array. Tente novamente");
            }
            catch (FormatException)
            {
                Console.WriteLine("número não reconhecido. Tente novamente");
            }
        }
    }
}