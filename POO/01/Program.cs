using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Funcionario f1 = new Funcionario("Fulano", 3000);
            Console.WriteLine(f1.Nome);
            Console.WriteLine(f1.Salario);

            f1.aumentarSalario(33.33);

            Console.WriteLine(f1.Nome);
            Console.WriteLine(f1.Salario);
            //HerancaCarro();
            // ComposicaoCasa();

            // Console.ReadLine();
        }


    }
}