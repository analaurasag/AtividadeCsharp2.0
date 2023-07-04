using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoDoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.idLivro = 1;
            livro.Título = "Diário de um Banana";
            livro.Autor = "Ana Laura";
            livro.Preco = 19.90;
            livro.NumeroPaginas = 200;

            livro.ImprimirDetalhes();

            Livro livro2 = new Livro();

            livro2.idLivro = 2;
            livro2.Título = "Ana Linda";
            livro2.Autor = "Deus";
            livro2.Preco = 300.000;
            livro2.NumeroPaginas = 6;

            Console.WriteLine("Detalhes do livro 2");

            livro2.ImprimirDetalhes();

            Livro livro3 = new Livro(3, "Excel", "Jorge",100, 50.90);
            Console.WriteLine("Detalhes do livro 3");
            livro3.ImprimirDetalhes();


            Livro livro4 = new Livro( 4, numeroPaginas: 20, titulo: "C#", autor:"Celso", preco: 49.90);
            Console.WriteLine("Detalhes do livro 4");
            livro4.ImprimirDetalhes();

            Livro livro5 = new Livro()
            {
                idLivro = 5,
                Título = "Senac Livro",
                NumeroPaginas = 80,
                Preco = 100.000,
                Autor = "microsoft"

            };
            Console.WriteLine("Detalhes do livro 5");
            livro5.ImprimirDetalhes();
        }
    }
}
