using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradordeCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            bool ValidarCPF(string cpf)
            {
                
                cpf = new string(cpf.Where(char.IsDigit).ToArray());

                if (cpf.Length != 11)
                    return false;

                if (cpf.Distinct().Count() == 1)
                    return false;
    
         

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
    }
}
       
