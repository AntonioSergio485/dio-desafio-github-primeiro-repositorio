using System;
namespace ExemploPOO.Models
{
    public class  Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void apresenta(){
            Console.WriteLine($"Olá , meu nome é {Nome} e  meu salario é {Salario}");
        }
    }
}