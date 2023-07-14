using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Descricao : produto
    {
        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine("Id Cliente: 1");
            Console.WriteLine("Nome Completo: Ana Laura Aguiar");
            Console.WriteLine("Endereço: Rua Ana Banana, 69");
        }
    }
}
