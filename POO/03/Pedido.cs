using System;

namespace Ex3
{
    class Pedido
    {

        private Cliente _cliente;
        private int _taxaDeServico; //taxa de serviço em porcentagem
        private List<Prato> _pratos = new List<Prato>();
        private float _total;
        private float _valorPago;
        private bool _fechado = false;
        private bool _pago = false;

        public int TaxaDeServico { get => _taxaDeServico; set => _taxaDeServico = value; }
        public List<Prato> Pratos { get => _pratos; set => _pratos = value; }
        public float Total { get => _total; set => _total = value; }

        public Pedido(Cliente Cliente, int taxa)
        {
            _cliente = Cliente;
            _taxaDeServico = taxa;
        }

        public Pedido(int taxa)
        {
            _cliente = null; //valor 0 para cliente não identificado
            _taxaDeServico = taxa;
        }




        public float calcularTotal()
        {
            if (!_fechado)
            {


                float calc = 0;
                foreach (Prato prato in _pratos)
                {
                    calc += prato.PrecoTotal;
                }

                calc += calc * _taxaDeServico / 100;
                _total = calc;

            }
            return _total;
        }

        public void mostrarFatura()
        {
            if (_fechado && _pago)
            {
                Ingredientes ingredientes = new Ingredientes();

                float parcial = 0;
                Console.WriteLine("==============================");
                Console.WriteLine("Fatura do pedido");
                Console.WriteLine("==============================");

                if (_cliente != null)
                {
                    Console.WriteLine("Cliente: {0}", _cliente.Nome);
                }
                else
                {
                    Console.WriteLine("Cliente não identificado");
                }

                foreach (Prato prato in _pratos)
                {
                    Console.WriteLine(prato.Nome);
                    foreach (int codigoIngrediente in prato.Ingredientes)
                    {
                        var vetor = ingredientes.GetIngredientes(codigoIngrediente);
                        Console.WriteLine("\t{0} ({1})", vetor[2], vetor[4]);
                    }
                    Console.WriteLine("Total do prato: \t{0}X{1}={2}", prato.Quantidade, prato.PrecoUnitario, prato.PrecoTotal);
                    Console.WriteLine("Validade de {0} dias", prato.Validade);
                    Console.WriteLine("Peso: {0} gramas", prato.PesoTotal);
                    parcial += prato.PrecoTotal;
                    Console.WriteLine("------------------------------");

                }

                Console.WriteLine("==============================");
                Console.WriteLine("Subtotal: " + parcial);
                Console.WriteLine("Taxa de serviço: " + _taxaDeServico + "%");
                Console.WriteLine("Tolal: " + _total);
                Console.WriteLine("==============================");
                Console.WriteLine("Valor pago: " + _valorPago);
                Console.WriteLine("Troco: " + (_valorPago - _total));
                Console.WriteLine("==============================");
                Console.WriteLine("Agradeçemos a preferência");
                Console.WriteLine("Volte sempre!");

            }
            else
            {
                Console.WriteLine("pedido ainda não pago");
            }
        }

        public void fecharPedido()
        {
            _fechado = true;
        }

        public void adicionarPrato(Prato novoPrato)
        {
            if (!_fechado)
            {
                _pratos.Add(novoPrato);
            }
            else
            {
                Console.WriteLine("pedido já fechado");

            }
        }

        public float pagar(float valor)
        {
            float troco = 0;
            if (_fechado && !_pago)
            {
                if (valor > _total)
                {
                    _pago = true;
                    troco = _total - valor;
                    _valorPago = valor;
                }
                else
                {
                    Console.WriteLine("valor insuficiente");
                }
            }

            return troco;

        }

    }

}
