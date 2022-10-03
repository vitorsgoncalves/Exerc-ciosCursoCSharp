using System;

namespace Ex3
{
    class Salgado : Prato
    {


        private string _tipo;
        public string Tipo { get => _tipo; }

        public Salgado(int quantidade = 1)
        {
            _nome = "Salgado";
            _precoBase = 25;
            _quantidade = quantidade;
            _pesoBase = 200;
        }


        public new void AdicionaIngrediente(int codigo)
        {
            base.AdicionaIngrediente(codigo);

            foreach (int codigoIngrediente in _ingredientes)
            {
                var vetor = _objetoingredientes.GetIngredientes(codigoIngrediente);
                string massa = vetor[2];

                if (massa == "massa assada")
                {
                    _tipo = "assado";
                }
                else if (massa == "massa frita")
                {
                    _tipo = "frito";
                }
            }
        }


    }
}