using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira a nota");
        double n1 = double.Parse(Console.ReadLine());
        int i = (int)n1;
        string[] grade = { "E", "E", "D", "D", "D", "C", "C", "B", "B", "A", "A" };
        Console.WriteLine("O conceito é " + grade[i]);
    }
}