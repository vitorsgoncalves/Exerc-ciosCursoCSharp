using System;

namespace Ex3
{
    class Cliente
    {

        private int _id;
        private string _nome;
        public string Nome { get => _nome; }

        public Cliente(string Nome)
        {
            _nome = Nome;
            Random random = new Random();
            _id = random.Next();
        }


    }
}