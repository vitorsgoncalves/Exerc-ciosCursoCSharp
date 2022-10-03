using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            // cria carro com 15 quilômetros por litro de combustível.
            Carro meuFusca = new Carro(15); 

            // abastece com 20 litros de combustível.
            float abastecimento = 20;
            meuFusca.AdicionarGasolina(abastecimento); 
            Console.WriteLine("Abasteceu com " + abastecimento + " litros de gasolina");

            // anda 100 quilômetros.
            float distancia = 100;
            float gasto = meuFusca.Andar(distancia); 
            Console.WriteLine("Andou " + distancia + " Km e gastou " + gasto + " litros de gasolina");

            // verifica o que sobrou e a quilometragem    
            float gasolina = meuFusca.ObterGasolina();
            float quilometragem = meuFusca.ObterQuilometragem();
            Console.WriteLine("Gasolina no tanque: " + gasolina);
            Console.WriteLine("Quilometragem total do veículo percorrida: " + quilometragem);

        }


    }
}