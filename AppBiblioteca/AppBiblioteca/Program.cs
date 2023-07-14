using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.id = 1;
            livro.título = "Harry Poter";
            livro.Ano = 2021;
            livro.NumeroPaginas = 20;

            livro.MostrarDetalhes();
            Console.WriteLine("======================================");

            LivroDigital livroDigital = new LivroDigital();
            livroDigital.id = 2;
            livroDigital.título = "Diário de um Banana";
            livroDigital.Ano = 2016;
            livroDigital.NumeroPaginas = 60;
            livroDigital.tipoArquivo = "pdf";
            livroDigital.TamanhoMB = 250;

            livroDigital.MostrarDetalhes();
        }
    }
}
