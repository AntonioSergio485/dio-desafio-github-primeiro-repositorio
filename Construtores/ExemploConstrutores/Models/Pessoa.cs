namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Antonio";
        private readonly string sobrenome;

        // public Pessoa()
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;    
        // }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;  
            System.Console.WriteLine("Cosntrutor clase Pessoa");    
 
        }

        public void apresentar(){
            System.Console.WriteLine($"Ola, meu nome e {nome} {sobrenome}");
        }
    }
}