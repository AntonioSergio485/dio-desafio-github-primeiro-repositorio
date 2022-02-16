using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Trabalhando com arquivos";
            var caminhoPath = Path.Combine(caminho, "teste1");
            var novoCaminhoPath = Path.Combine(caminho, "teste2");
            var caminhoArquivo = caminho + "arquivo.txt";
            var caminhoArquivoTeste = caminho + "arquivo.txt";
            var caminhoArquivoTesteCopia = caminho + "arquivo.txt";
            var listaString = new List<string> {"Linha1 ","Linha2", "Linha3"};
            var listaString2 = new List<string> {"Linha4 ","Linha5", "Linha6"};

            FileHelper helper = new FileHelper();
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            //helper.CopiarArquivo(caminhoArquivoTeste,caminhoArquivoTesteCopia,false);
            //helper.MoverArquivo(caminhoArquivo,novoCaminhoPath);

            //helper.CriarArquivoTextoStream(caminho,listaString);
            //helper.AdicionarTextoStream(caminho,listaString2);

            //helper.CriarArquivoTexto(caminhoArquivo,"Teste de escrita");
            //helper.ApagarDiretorio(caminhoPath,true);
            //helper.CriarDiretorio(caminhoPath);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.ListarDiretorios(caminho);
            //helper.LerArquivoStream(caminhoArquivo);

            //---------
            // iCalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir(10,2));

            //--------
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            //-----------
            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();
            //---------------------
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado primeira soma : " + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado segunda soma : " + calc.Somar(10,10,10));

            //-------------------------
            // Aluno a1 = new Aluno();
            // a1.Nome = "Antônio";
            // a1.Idade = 26;
            // a1.Nota = 7;
            // a1.apresenta();

            // Professor prof1 = new Professor();
            // prof1.Salario = 5000.0;
            // prof1.apresenta();

            //--------------------------------------
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);

            // System.Console.WriteLine($"Area: {r.ObterArea()}");

            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(-30,30);

            // System.Console.WriteLine($"Area: {r2.ObterArea()}");
            //--------------------------------------
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Antônio";
            // p1.Idade = 26;

            // p1.apresenta();
        }
    }
}
