using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validção_cpf_
{
    internal class Program
    {
        private static void Main(string[] args, string cpf, int contador
        {
            Main(args, cpf, contador);
        }

        static void Main(string[] args, string cpf, int contador, int contadorr)
        {
            string CPF;
            char[] vetor = new char[11];

            _ = new int[11];
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] soma1 = new int[9];
            int total1 = 0;
            int resto1 = 0;

            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] soma2 = new int[10];
            int total2 = 0;
            int resto2 = 0;

            Console.Write("Digite seu CPF: ");
            cpf = Console.ReadLine();

            while (cpf.Length != 11) ;
            {
                Console.WriteLine("CPF inválido!");
                Console.WriteLine("\n\n=====================================\n");
                Console.Write("\nDigite seu CPF: ");
                cpf = Console.ReadLine();
            }
            for (int contador2 = 0; contador2 < 11; contador2++)
            {
                vetor[contador2] = cpf[contador2];
                cpf[contador] = Convert.ToInt32(vetor[contador2].ToString());
            }
        }
    }
    }
}
