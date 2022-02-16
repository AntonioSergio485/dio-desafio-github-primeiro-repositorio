using System;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void apresenta(){
            Console.WriteLine($"Olá , meu nome é {Nome} e  meu salario é {Salario}");
        }
        
    }
}