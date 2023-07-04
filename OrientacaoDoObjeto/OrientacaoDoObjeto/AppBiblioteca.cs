using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoDoObjeto
{
    internal class AppBiblioteca
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Nome = ("Senac Marília");

            Livro livro = new Livro();
            livro.idLivro = 1;
            livro.Título = "Diário de um Banana";
            livro.Autor = "Ana Laura";
            livro.Preco = 19.90;
            livro.NumeroPaginas = 200;
            biblioteca.CadastrarLivro(livro);

            Livro livro2 = new Livro();
            livro2.idLivro = 2;
            livro2.Título = "Ana Linda";
            livro2.Autor = "Deus";
            livro2.Preco = 300.000;
            livro2.NumeroPaginas = 6;

            biblioteca.CadastrarLivro(livro2);
            biblioteca.MostrarCatalogo();



        }
    }
}
