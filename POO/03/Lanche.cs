using System;

namespace Ex3
{
    class Lanche : Prato
    {

        public Lanche(int quantidade = 1)
        {
            _nome = "Lanche";
            _precoBase = 25;
            _quantidade = quantidade;
            _pesoBase = 240;
        }
    }
}