using System;
using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListString(List<string> lista){
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"O indice {i} tem o elemento {lista[i]}");    
            }
        }

        
    }
}