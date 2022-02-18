using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArrays op = new OperacoesArrays();
            int[] array = new int[5]{6,3,8,1,9};
            int[] arrayCopia = new int[10];
            //int valorProcurado = 110;
            // bool existe = op.ExisteArray(array,valorProcurado);
            int valorParaObter = 9;
            //int valorAchado = op.obterValor(array,valorParaObter);
            int valorAchado = op.obterIndice(array,valorParaObter);
              if(valorAchado > -1){
                System.Console.WriteLine($"Encontrei o valor no indice {valorAchado}");
            }else{                
                System.Console.WriteLine($"Não encontrei");
            }
            // if(valorAchado > 0){
            //     System.Console.WriteLine($"Encontrei o valor {valorAchado}");
            // }else{                
            //     System.Console.WriteLine($"Não encontrei");
            // }

            // bool todosMaiorQue = op.todosMaiorQue(array,valorProcurado);
            // if(todosMaiorQue){
            //     System.Console.WriteLine($"Todos maior que {valorProcurado}");
            // }else{                
            //     System.Console.WriteLine($"Não são todos maior que {valorProcurado}");
            // }

            // if(existe){
            //     System.Console.WriteLine($"Existe o valor {valorProcurado}");
            // }else{                
            //     System.Console.WriteLine($"Não existe o valor {valorProcurado}");
            // }
            // System.Console.WriteLine("Original");
            // op.ImprimirArrays(arrayCopia);    
            // op.Copiar(ref array,ref arrayCopia);
            // // op.Ordenar(ref array);
            // op.ImprimirArrays(arrayCopia);
            // op.ImprimirArrays(array);
            // op.OrdenarBubbleSort(ref array);
            // System.Console.WriteLine("Ordenado");
            // op.ImprimirArrays(array);

            // int[,] matriz = new int[4,2]
            // {
            //     {8,8},
            //     {10,20},
            //     {50,100},
            //     {90,200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //     System.Console.WriteLine(matriz[i, j]);    
            //     }    
            // }

            // int[] arrayInterios = new int[3];

            // System.Console.WriteLine("--For");
            // arrayInterios[0] = 10;
            // arrayInterios[1] = 20;
            // arrayInterios[2] = int.Parse("10");
            // arrayInterios[4] = '5';

            // for (int i = 0; i < arrayInterios.Length ; i++)
            // {
            //     System.Console.WriteLine(arrayInterios[i]);    
            // }
            // System.Console.WriteLine("--Foreach");
            // foreach (var item in arrayInterios)
            // {
            //     System.Console.WriteLine(item);
            // }   

        }
    }
}
