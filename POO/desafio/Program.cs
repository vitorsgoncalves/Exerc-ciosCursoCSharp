using System;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {

            Criptografia cripto = new Criptografia(CryptProvider.RC2); 
            cripto.Key = "testeeeeeee";

            string inputString = "teste";

            string textoCriptografado = cripto.Encrypt(inputString);

            string outString = cripto.Decrypt(textoCriptografado);

            Console.WriteLine("Mensagem criptografada: " + textoCriptografado);
            Console.WriteLine("Mensagem descriptografada: " + outString);



        }


    }
}