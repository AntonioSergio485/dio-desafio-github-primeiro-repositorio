using System;
using Primeiro;
using CSharp;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Antônio";
            person.Idade = 26;
            person.Estado = "SP";

            Pessoa person2 = new Pessoa();
            person2.Nome = "Silvia";
            person2.Idade = 50;
            person2.Estado = "SP";

            var classe = new Primeiro.Classe();
            Console.WriteLine("Hello World!");
            Console.WriteLine
        }
    }
}
