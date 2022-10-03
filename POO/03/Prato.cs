using System;

namespace Ex3
{


    class Prato
    {

        protected float _precoTotal;
        protected float _precoUnitario;
        protected float _precoBase;
        protected int _pesoBase;
        protected int _pesoTotal;
        protected string _nome;
        protected int _quantidade;
        protected int _validade;
        // protected int _tempodePreparo; //tempo de preparo em minutos
        protected string[] _ingredientesDisponiveis = { };
        protected List<int> _ingredientes = new List<int>();
        protected Ingredientes _objetoingredientes = new Ingredientes();

        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public int Validade { get => _validade; }
        public int PesoTotal { get => _pesoTotal;  }
        public string Nome { get => _nome;}

        public List<int> Ingredientes { get => _ingredientes; }

        public float PrecoTotal { get => _precoTotal; } 
        public float PrecoUnitario { get => _precoUnitario; } 


        public void AdicionaIngrediente(int codigo)
        {
            _ingredientes.Add(codigo);


            CalculaTotal();
            CalculaValidade();
            CalculaPeso();
        }


        public void CalculaPeso()
        {
            int peso = 0;

            foreach (int codigoIngrediente in _ingredientes)
            {
                var vetor = _objetoingredientes.GetIngredientes(codigoIngrediente);
                peso += int.Parse(vetor[6]);
            }
            _pesoTotal = (peso + _pesoBase) * _quantidade;
        }

        public void CalculaValidade()
        {
            int min = 1000;

            foreach (int codigoIngrediente in _ingredientes)
            {
                var vetor = _objetoingredientes.GetIngredientes(codigoIngrediente);
                int validade = int.Parse(vetor[5]);
                min = (validade < min) ? validade : min;
            }
            _validade = min;
        }
        public void CalculaTotal()
        {
            float calc = 0;

            foreach (int codigoIngrediente in _ingredientes)
            {
                var vetor = _objetoingredientes.GetIngredientes(codigoIngrediente);
                calc += float.Parse(vetor[4]);
            }

            calc += _precoBase;
            _precoUnitario = calc;
            _precoTotal = calc * _quantidade;

        }
    }
}