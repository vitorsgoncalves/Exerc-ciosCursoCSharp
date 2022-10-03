using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            //cria o funcionário
            Funcionario f1 = new Funcionario("Fulano", 3000);
            Console.WriteLine(f1.Nome);
            Console.WriteLine(f1.Salario);

            //aument ao salário
            Console.WriteLine("Aumentando o salário em 1/3");
            f1.aumentarSalario(33.33);

            //mostra o valor aumentado
            Console.WriteLine(f1.Nome);
            Console.WriteLine(f1.Salario);

        }


    }
}