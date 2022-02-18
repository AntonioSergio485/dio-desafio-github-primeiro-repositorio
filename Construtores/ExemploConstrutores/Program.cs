using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
         public delegate void Operacao(int x , int y);
        static void Main(string[] args)
        {
           
           Matematica mat = new Matematica(10, 20);
           mat.Somar();

        //    Operacao op = new Operacao(Calculadora.Somar);

        //    op += Calculadora.Subtrair;
           
        //    op.Invoke(10,10);
           //op(10,10)


            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Data data = new Data();
            // data.SetMes(2);
            // data.ApresentarMes();
            // Aluno a1 = new Aluno("Antonio","Sergio","teste");

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Log";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Pessoa p1 = new Pessoa();
            // p1.apresentar();
        }
    }
}
