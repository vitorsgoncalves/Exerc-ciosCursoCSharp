using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {



            //identificando o cliente
            Cliente cliente = new Cliente("Fulano");

            // criando o prato
            Pizza prato1 = new Pizza();
            prato1.AdicionaIngrediente(2);
            prato1.AdicionaIngrediente(4);
            prato1.AdicionaIngrediente(8); ;
            Console.WriteLine("Valor do item: " + prato1.PrecoTotal);

            // mais um prato
            Salgado prato2 = new Salgado();
            prato2.AdicionaIngrediente(3);
            prato2.AdicionaIngrediente(6);
            Console.WriteLine("Valor do item: " + prato2.PrecoTotal);

            //cria o pedido com 10% de taxa de serviço
            Pedido pedido1 = new Pedido(cliente, 10);
            pedido1.adicionarPrato(prato1);
            pedido1.adicionarPrato(prato2);
            var total = pedido1.calcularTotal();
            Console.WriteLine("Valor total: " + total);

            //finaliza o pedido
            pedido1.fecharPedido();
            var troco = pedido1.pagar(100);
            pedido1.mostrarFatura();
        }


    }
}