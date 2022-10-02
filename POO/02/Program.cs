using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro meuFusca = new Carro(15); // 15 quilômetros por litro de combustível.

            float abastecimento = 20;
            meuFusca.AdicionarGasolina(abastecimento); // abastece com 20 litros de combustível.
            Console.WriteLine("Abasteceu com " + abastecimento + " litros de gasolina");


            float distancia = 100;
            float gasto = meuFusca.Andar(distancia); // anda 100 quilômetros.
            Console.WriteLine("Andou " + distancia + " Km e gastou " + gasto + " litros de gasolina");

            float gasolina = meuFusca.ObterGasolina();
            Console.WriteLine("Gasolina no tanque: " + gasolina);

        }


    }
}