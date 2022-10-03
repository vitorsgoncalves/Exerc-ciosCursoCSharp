

namespace Ex2
{
    class Carro
    {

        private float _gasolina = 0;
        private float _quilometragem = 0;
        private float _consumo = 0;


        public Carro(int consumo){
            this._consumo = consumo;
        }

        public float Andar(float distancia){
            _quilometragem += distancia;
            float gasto = distancia / _consumo;
            _gasolina -= gasto;
            return gasto;
        }

        public float ObterGasolina(){
            return _gasolina;
        }

        public float ObterQuilometragem(){
            return _quilometragem;
        }        

        public bool AdicionarGasolina(float quantidade){
            _gasolina += quantidade;
            return true;
        }

    }
}