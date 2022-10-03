using System;

namespace Ex3
{
    class Pizza : Prato
    {


        public Pizza(int quantidade = 1)
        {
            _nome = "Pizza";
            _precoBase = 25;
            _quantidade = quantidade;
            _pesoBase = 600;
        }

    }
}