using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> idade = new List<int>(100);
        List<string> opiniao = new List<string>(100);
        string[] faixa = { "ótimo", "bom", "regular", "ruim", "péssimo" };
        //não tem como ler 100 valores, então simulando preenchimento com um random
        Random random = new Random();
        for (int i = 0; i < 100; i++)
        {
            idade.Add((int)random.Next(10, 100));
            opiniao.Add(faixa[random.Next(0, 5)]);
        }
        int countRuim = 0, countPessimo = 0, countOtimo = 0, maiorIdade = 0;
        float media = 0;
        for (int i = 0; i < 100; i++)
        {
            if (opiniao[i] == "ruim")
            {
                media += idade[i];
                countRuim++;
            }
            else if (opiniao[i] == "péssimo")
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                    countPessimo++;
                }
            }
            else if (opiniao[i] == "ótimo")
            {
                countOtimo++;
            }
            // media += idade[IndexOf(pessoa)]
        }
        media = media / countRuim;
        Console.WriteLine(countOtimo + " pessoas responderam ótimo");
        Console.WriteLine("a média de idade de quem respondeu ruim foi " + media);
        Console.WriteLine("a porcentagem de respostas pessimo é de " + (countPessimo)); //multimplicar e dividir por 100 vai cancelar o termo
        Console.WriteLine("a maior idade de quem respondeu péssimo foi " + maiorIdade);
    }
}