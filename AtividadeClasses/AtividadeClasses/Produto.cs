using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    public class produto
        {
           public int idProduto = 1;
            public string nomeProduto = "Teclado Gamer RGB";
            public double valor = 9.90;
            public int quantidade = 80;
           
           

            public virtual void MostrarDetalhes()
            {
                Console.WriteLine("Id: {0}", idProduto);
                Console.WriteLine("Nome Produto: {0}", nomeProduto);
                Console.WriteLine("Valor Produto: {0}", valor);
                Console.WriteLine("Quantidade: {0}", quantidade);
            }
        }
    }

