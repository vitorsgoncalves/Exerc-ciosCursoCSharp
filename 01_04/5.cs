using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<int, string> alunos = new Dictionary<int, string>();
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("próximo aluno");
            alunos.Add(i, Console.ReadLine());
        }
        Console.WriteLine("o aluno 7 é " + alunos[7]);

    }
}