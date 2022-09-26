using System;
class Program
{
    static void Main()
    {
        var letras = new Dictionary<string, int>(){
{"o", 0},
{"b", 0},
{"r", 0},
{"u", 0}
};
        int total = 0;
        Console.WriteLine("Insira as letras");
        string s = "";
        do
        {
            foreach (string letra in letras.Keys)
            {
                if (s == letra)
                {
                    letras[letra] += 1;
                    total++;
                    break;
                }
            }
            s = Console.ReadLine();
        } while (s != "-");

        foreach (string letra in letras.Keys)
        {
            Console.WriteLine("Foram inseridas " + letras[letra] + " respostas " + letra);
            float porcentagem = ((float) letras[letra] / total) * 100;
            Console.WriteLine("O percentual de respostas " + letra + " é de " + porcentagem);
            Console.WriteLine("");
        }
        Console.WriteLine("O total de respostas foi " + total);
        if ((letras["o"] + letras["b"]) > (letras["u"] + letras["r"]))
        {
            Console.WriteLine("Houveram mais respostas B e O");
        }
        else
        {
            Console.WriteLine("Houveram mais respostas U e R");
        }

    }
}