using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaçãoCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf;
            char[] vetor = new char[11];

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

            for (int contador = 0; contador < 11; contador++)
            {
                vetor[contador] = cpf[contador];
                cpf = cpf.Remove(contador, 1).Insert(contador, Convert.ToString(vetor[contador]));

            }
            for (int contador = 0; contador < 9; contador++)
            {
                soma1[contador] += Convert.ToInt32(cpf[contador].ToString()) * peso1[contador];
                total1 += soma1[contador];
                resto1 = (total1 * 10) % 11;

                if (resto1 == 10 || resto1 == 11)
                {
                    resto1 = 0;
                }
            }
            for (int contador = 0; contador < 10; contador++)
            {
                soma2[contador] = Convert.ToInt32(cpf[contador].ToString()) * peso2[contador];
                total2 += soma2[contador];
                resto2 = (total2 * 10) % 11;

                if (resto2 == 10 || resto2 == 11)
                {
                    resto2 += 0;
                }
            }
            Console.Clear();

            if (resto1 != Convert.ToInt32(cpf[9].ToString()) || resto2 != Convert.ToInt32(cpf[10].ToString()))
            {
                string y = string.Join("", cpf);
                Console.WriteLine("=====================================\n\n");
                string z = $"{y.Substring(0, 3)}.{y.Substring(3, 3)}.{y.Substring(6, 3)}-{y.Substring(9, 2)}";
                Console.WriteLine("\n\n------------------------------------\n");
                Console.WriteLine($"\nO CPF: {z} INVÁLIDO\n");
                Console.WriteLine("\n=====================================\n");
            }
            else
            {
                string y = string.Join("", cpf);
                Console.WriteLine("=====================================\n\n");
                string z = $"{y.Substring(0, 3)}.{y.Substring(3, 3)}.{y.Substring(6, 3)}-{y.Substring(9, 2)}";
                Console.WriteLine("\n\n------------------------------------\n");
                Console.WriteLine("\nCPF VÁLIDO\n");
                Console.WriteLine("\n=====================================\n");
            }
            
        }
    }

}
        
        
      
    

