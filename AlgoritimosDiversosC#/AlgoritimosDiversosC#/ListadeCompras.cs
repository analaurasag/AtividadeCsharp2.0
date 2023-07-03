using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosDiversosC_
{
    internal class ListadeCompras
    {
        static void ImprimeLista(List<int> lista)
        {
           
            foreach (int ListaDeCompras in lista)
            {
                Console.WriteLine(ListaDeCompras);
            }

        }
        static void Main()
        {
            List<string> ListaDeCompras = new List<string>();
            Console.WriteLine("::::::::  Programa de Lista de Compras  ::::::::");

            while (true)
            {
                Console.WriteLine("Digite  um item para adicionar á lista (ou 'parar' para SAIR): ");
                string item = Console.ReadLine();

                if (item.ToLower() == "parar") 
                {
                    break;
                }
                ListaDeCompras.Add(item);
                Console.WriteLine("Item adicionado com sucesso!");
            }
            Console.WriteLine("::::::::  Sua Lista de Compras  ::::::::");

            if (ListaDeCompras.Count <= 0)
            {
                Console.WriteLine("Não foi encontrado nenhum iten na lista ");
            }
            else
            {
                foreach (string item in ListaDeCompras)
                { 
                Console.WriteLine(item);
            }
               
            }
            
            //Imprimir a lista, porém caso esteja vazia, retornar o texto "A  lista está vazia",
            //Caso contrário, Imprimir todos os itens na tela

        }
    }
}
