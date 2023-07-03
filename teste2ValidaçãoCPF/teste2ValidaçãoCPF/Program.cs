using System;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu CPF:");
        string cpf = Console.ReadLine();



        while (!ValidarCPF(cpf))
        {
            Console.WriteLine("CPF inválido. Digite novamente:");
            cpf = Console.ReadLine();
        }



        Console.WriteLine("CPF válido!");
        Console.WriteLine("Digite 'Sair' para SAIR ou qualquer tecla para DIGITAR NOVAMENTE:");
        string opcao = Console.ReadLine();
        if (opcao.Equals("Sair", StringComparison.OrdinalIgnoreCase)) 
        {
            bool sair = true;
           
        }

        Console.WriteLine("Digite novamente o CPF:");
        cpf = Console.ReadLine();
    }

            if (sair)
                break;

            Console.WriteLine("CPF válido!");

            Console.WriteLine("Digite 'S' para sair ou qualquer tecla para digitar outro CPF:");
            string escolha = Console.ReadLine();

            if (escolha.Equals("S", StringComparison.OrdinalIgnoreCase))
                sair = true;
        }

Console.WriteLine("Programa encerrado.");
Console.ReadLine();
    }

    static bool ValidarCPF(string cpf)
{
    
}
}



    static bool ValidarCPF(string cpf)
    {

        cpf = new string(cpf.Where(char.IsDigit).ToArray());


        if (cpf.Length != 11)
            return false;


        if (cpf.Distinct().Count() == 1)
            return false;


        int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };



        string cpfParcial = cpf.Substring(0, 9);



        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpfParcial[i].ToString()) * multiplicadoresPrimeiroDigito[i];



        int resto = soma % 11;
        int primeiroDigitoVerificador = (resto < 2) ? 0 : 11 - resto;



        if (int.Parse(cpf[9].ToString()) != primeiroDigitoVerificador)
            return false;



        cpfParcial += primeiroDigitoVerificador;
        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += int.Parse(cpfParcial[i].ToString()) * multiplicadoresSegundoDigito[i];



        resto = soma % 11;
        int segundoDigitoVerificador = (resto < 2) ? 0 : 11 - resto;



        if (int.Parse(cpf[10].ToString()) != segundoDigitoVerificador)
            return false;



        return true;
    }
}
