using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosDiversosC_
{
    internal class TrabalhandoLista
    {
        static void ImprimeLista(List<int> lista, String título = "===========")
        {
            Console.WriteLine("============= " + título + " =============");

            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

        }
        static void Main()
        {

                    //Add: Adicionando elemento na lista 
            List<int> lista = new List<int>();

            lista.Add(90);
            lista.Add(10);
            lista.Add(50);
            lista.Add(40);
            lista.Add(1);
            lista.Add(70);

            ImprimeLista(lista, "Adicionando Elemento Na Lista");

            


                    //Remove: Remove a primeira ocorrência de um elemento da lista 

            lista.Remove(10);

            ImprimeLista(lista, "Remove a primeira ocorrência de um elemento da lista");

           


                    //RemoveAt: Remove o elemento de um índice 
            
            lista.RemoveAt(0);

            ImprimeLista(lista, "Remove o elemento de um índice ");

            ImprimeLista(lista);

            //Sort: Ordenar os elementos em ordem crescente 

            lista.Sort();
            ImprimeLista(lista, "Ordenar Lista");


            //Reverse: Ordenar os elementos em ordem decrescente 

            lista.Reverse();
            ImprimeLista(lista, "Ordem Inversa");

            //Count: Retorna a quantidade de elementos na lista 

            int numeroItem = lista.Count();
            Console.WriteLine("Existe {0} itens na lista", numeroItem);


            // Contain: Verifica se a lista contém um determinado elemento 

            if (lista.Contains(40))
            {
                Console.WriteLine("Foi encontrado o item na lista");
            } else
            {
                Console.WriteLine("Não foi encontrado nenhum iten na lista ");
            }


            //Insert: Insere um elemento em um determinado indice da lista 
            lista.Insert(2, 45);
            ImprimeLista(lista, "Insere um elemento em um determinado indice da lista");


            //Clear: Limpar os itens da lista 
            lista.Clear();
        }
    }
}