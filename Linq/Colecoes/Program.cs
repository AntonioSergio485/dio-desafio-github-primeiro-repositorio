using System;
using Colecoes.Helper;
using System.Collections.Generic;
using System.Linq;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraysNumeros = new int[10]{100,1,4,0,8,15,19,19,4,100};

            var minimo = arraysNumeros.Min();    
            var maximo = arraysNumeros.Max();    
            var media = arraysNumeros.Average();   
            var soma = arraysNumeros.Sum();
            var arrayUnico = arraysNumeros.Distinct().ToArray();

            System.Console.WriteLine($" Minimo: {minimo}, Maximo : {maximo}, Media : {media}"); 
            System.Console.WriteLine($"Soma {soma}");
            System.Console.WriteLine($"Array original {string.Join(", ",arraysNumeros)}");
            System.Console.WriteLine($"Array unico {string.Join(", ",arrayUnico)}");
            // var numerosPares =
            //     from num in arraysNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numeParesMetodo = arraysNumeros.Where(x => x % 2 ==0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Numeros pares query: " + string.Join(", ",numerosPares));
            // System.Console.WriteLine("Numeros pares metodo: " + string.Join(", ",numeParesMetodo));
            
            
            
            // Dictionary<string,string> estados = new Dictionary<string, string>();
            // estados.Add("SP","São Paulo");
            // estados.Add("MG","Minas Gerais");
            // estados.Add("BA","Bahia");

            // foreach (KeyValuePair<string,string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave : {item.Key} , Valor : {item.Value}");    
            // }

            // string valorProcurado = "BA";
            // if(estados.TryGetValue(valorProcurado,out string estadoEncontrado)){
            //     System.Console.WriteLine(estadoEncontrado);
            // }else{
            //     System.Console.WriteLine("Valor procurado não existe");
            // }
            // System.Console.WriteLine("Removendo o valor  : " + valorProcurado);
            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string,string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave : {item.Key} , Valor : {item.Value}");    
            // }

            // System.Console.WriteLine("Valor original :");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados["BA"] = "Teste atualização";
            // System.Console.WriteLine("Valor :");
            // System.Console.WriteLine(estados[valorProcurado]);

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("codigo limpo");

            // System.Console.WriteLine("Quantidade de livros " + pilhaLivros.Count);
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro para leitura {pilhaLivros.Peek()}");
            //     System.Console.WriteLine(pilhaLivros.Pop() + " lidos com sucesso");
            // }            

            // Queue<string> fila = new Queue<string>();
            
            // fila.Enqueue("Antonio");    
            // fila.Enqueue("Sergio");    
            // fila.Enqueue("Laurindo");    

            // while(fila.Count > 0){
            //     System.Console.WriteLine("Pessoas na fila " + fila.Count);
            //     System.Console.WriteLine($"Vez de : {fila.Peek()}");
            //     System.Console.WriteLine(fila.Dequeue());
            // }

            // List<string> estados = new List<string>{"SP","MG","BA"};

            // System.Console.WriteLine("Quantidade de elementos : " + estados.Count);
            // OperacoesLista op = new OperacoesLista();
            // string[] estadosArray = new string[2] {"SC","MT"};

            // //estados.AddRange(estadosArray);
            // estados.Insert(1,"RJ");

            // op.ImprimirListString(estados);
            // estados.Remove("MG");
            // System.Console.WriteLine("Quantidade de elementos : " + estados.Count);

            // OperacoesArrays op = new OperacoesArrays();
            // int[] array = new int[5]{6,3,8,1,9};

            // string[] arrayCopiar = op.ConverterParaString(array);
            // System.Console.WriteLine(arrayCopiar.Length);

            // System.Console.WriteLine("Tamanho do array: " + array.Length);
            // op.redimensionarArray(ref array, array.Length * 2);
            // System.Console.WriteLine("Novo tamanho do array: " + array.Length);

            // int[] arrayCopia = new int[10];
            //int valorProcurado = 110;
            // bool existe = op.ExisteArray(array,valorProcurado);
            // int valorParaObter = 9;
            // //int valorAchado = op.obterValor(array,valorParaObter);
            // int valorAchado = op.obterIndice(array,valorParaObter);
            //   if(valorAchado > -1){
            //     System.Console.WriteLine($"Encontrei o valor no indice {valorAchado}");
            // }else{
            //     System.Console.WriteLine($"Não encontrei");
            // }
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
