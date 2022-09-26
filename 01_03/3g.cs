

//USANDO FOR
//AS OUTRAS VERSÕES ESTÃO COMENTADAS ABAIXO

using System;
class Program
{
    static int Main()
    {
        Console.WriteLine("Insira um número");
        int numero;
        try
        {
            numero = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("número inválido");
            return 0;
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(numero + " X " + i + " = " + (i * numero));
        }
        return 0;
    }
}


// USANDO WHILE
// using System;
// class Program
// {
//     static int Main()
//     {
//         Console.WriteLine("Insira um número");
//         int numero;
//         try
//         {
//             numero = int.Parse(Console.ReadLine());
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine("número inválido");

//             return 0;
//         }
//         int i = 0;
//         while (i <= 10)
//         {
//             Console.WriteLine(numero + " X " + i + " = " + (i * numero));
//             i++;
//         }
//         return 0;
//     }
// }

// USANDO FOREACH
// using System;
// class Program
// {
//     static int Main()
//     {
//         Console.WriteLine("Insira um número");
//         int numero;
//         try
//         {
//             numero = int.Parse(Console.ReadLine());
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine("número inválido");
//             return 0;
//         }
//         int[] iter = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//         foreach (int i in iter)
//         {
//             Console.WriteLine(numero + " X " + i + " = " + (i * numero));
//         }
//         return 0;
//     }
// }

// USANDO DO WHILE
// using System;
// class Program
// {
//     static int Main()
//     {
//         Console.WriteLine("Insira um número");
//         int numero;
//         try
//         {
//             numero = int.Parse(Console.ReadLine());
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine("número inválido");
//             return 0;
//         }
//         int i = 0;
//         do
//         {
//             Console.WriteLine(numero + " X " + i + " = " + (i * numero));
//             i++;
//         } while (i <= 10);
//         return 0;
//     }
// }