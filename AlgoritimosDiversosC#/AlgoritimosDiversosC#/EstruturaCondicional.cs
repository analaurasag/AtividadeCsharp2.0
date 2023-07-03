using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimosDiversosC_
{
    internal class EstruturaCondicional
    {
    static void Main()

     {
            Console.WriteLine("========== Estrutura Condicional ==========");
            int nota = 8;

            if (nota >=7)
            {
                Console.WriteLine("Aluno Aprovado");
            }

            Console.WriteLine("===========================================");
            if (nota >= 7) 
            {
                Console.WriteLine("Aluno Aprovado");
            }else{
                Console.WriteLine("Aluno Reprovado");
            }

            Console.WriteLine("===========================================");

            if (nota >= 9)
            {
                Console.WriteLine("Aluno nota A");
            } else if (nota >= 7)
            {
                Console.WriteLine("Aluno nota B");
            } else if (nota >= 5)
            {
                Console.WriteLine("Aluno Nota C");
            } else if (nota >= 3)
            {
                Console.WriteLine("Aluno nota D");
            } else
            {
                Console.WriteLine("Aluno nota E");
            }
            Console.WriteLine("===========================================");

            string cor = "vermelho";
            switch (cor)
            {
                case "verde":
                    Console.WriteLine("A cor é verde");
                    break;

                case "vermelho":
                Console.WriteLine("A cor é vermelho");
                    break;

                case "azul":
                Console.WriteLine("A cor é Azul");
                    break;

                default:
                    Console.WriteLine("A cor não foi reconhecida");
                    break;
            }

        }
    }
}
