

namespace Ex1
{
    class Funcionario
    {


        public string Nome {get; set;}
        public double Salario {get; set;}

        public Funcionario(string _nome, double _salario){
            Nome = _nome;
            Salario = _salario;
        }

        public void aumentarSalario( double porcentualDeAumento){
            this.Salario += this.Salario * (porcentualDeAumento / 100);
        }




    }
}