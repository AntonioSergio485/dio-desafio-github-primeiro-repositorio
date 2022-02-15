using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;
namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pessoa = Pessoas.Antônio;
            var pessoa = (Pessoas)0;

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

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.nomeDono = "Pedro";            
            animal.especie = "Cachorro";


        }
    }
}
