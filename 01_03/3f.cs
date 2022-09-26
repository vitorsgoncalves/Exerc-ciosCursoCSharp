using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira a altura e, em seguida, o peso");
        double altura = double.Parse(Console.ReadLine());
        double peso = double.Parse(Console.ReadLine());
        double imc = peso / (altura * altura);
        string s;
        if (imc <= 18.5)
        {
            s = "abaixo do peso";
        }
        else if (imc <= 25)
        {
            s = "peso normal";
        }
        else if (imc <= 30)
        {
            s = "acima do normal";
        }
        else
        {
            s = "peso excessivo";
        }

        Console.WriteLine(s);

    }
}