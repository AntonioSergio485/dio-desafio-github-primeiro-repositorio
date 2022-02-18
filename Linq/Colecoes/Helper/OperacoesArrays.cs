using System;

namespace Colecoes.Helper
{
    public class OperacoesArrays
    {

        public void OrdenarBubbleSort(ref int[] array){
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if(array[j] > array[j + 1]){
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }   
            }
        }
        public void ImprimirArrays(int[] array){
            var linha = string.Join(", ",array);
            System.Console.WriteLine(linha);   
        }

        public void Ordenar(ref int[] array){
            Array.Sort(array);
        }

        public void Copiar(ref int[] array,ref int[] arrayDestino){
            Array.Copy(array,arrayDestino,array.Length);    
        }

        public bool ExisteArray(int[] array,int valor){
            return Array.Exists(array,elemento => elemento == valor);
        }

        public bool todosMaiorQue(int[] array, int valor){
            return Array.TrueForAll(array,elemento => elemento > valor);
        }

        public int obterValor(int[] array , int valor){
            return Array.Find(array, element => element == valor);
        }

        public int obterIndice(int[] array , int valor){
            return Array.IndexOf(array,valor);
        }
    }
}