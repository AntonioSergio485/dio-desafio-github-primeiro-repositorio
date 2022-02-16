using System;
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void apresenta(){
            Console.WriteLine($"Olá , meu nome é {Nome} minha nota e {Nota}");
        }
    }
}