using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarCPFeCNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdCpf.Checked)
            {
                string cpf = txtCPFouCNPJ.Text;
                string cpfSemCaracteres = cpf.Replace(".", "").Replace("-", "");

                int[] cpfInt = cpfSemCaracteres.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();
                int soma1 = 0, soma2 = 0;
                int resto1 = 0, resto2 = 0;

                for (int i = 0; i < 9; i++)
                {
                    soma1 += cpfInt[i] * (10 - i);
                    resto1 = (soma1 * 10) % 11;
                }

                for (int i = 0; i < 10; i++)
                {
                    soma2 += cpfInt[i] * (11 - i);
                    resto2 = (soma2 * 10) % 11;
                }

                resto1 = (resto1 == 10 || resto1 == 11) ? 0 : resto1;
                resto2 = (resto2 == 10 || resto2 == 11) ? 0 : resto2;

                string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";

                if (resto1 == cpfInt[9] && resto2 == cpfInt[10])
                {
                    MessageBox.Show("Seu CPF é válido", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seu CPF é inválido, Tente novamente", "CPF", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            if (rdCNPJ.Checked)
            {
                int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                string cnpj = txtCPFouCNPJ.Text;
                int[] numerosInteiro = cnpj.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();
                int soma1 = 0;

                for (int i = 0; i < 12; i++)
                {
                    soma1 += numerosInteiro[i] * peso1[i];
                }

                int resto1 = soma1 % 11;

                if (resto1 < 2)
                {
                    resto1 = 0;
                }
                else
                {
                    resto1 = 11 - resto1;
                }

                int soma2 = 0;

                for (int i = 0; i < 13; i++)
                {
                    soma2 += numerosInteiro[i] * peso2[i];
                }

                int resto2 = soma2 % 11;

                if (resto2 < 2)
                {
                    resto2 = 0;
                }
                else
                {
                    resto2 = 11 - resto2;
                }

                string cnpjFormatado = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";

                if (resto1 == numerosInteiro[12] && resto2 == numerosInteiro[13])
                {
                    MessageBox.Show("Seu CNPJ é válido", "CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seu CNPJ é inválido, Tente novamente", "CNPJ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void geradorDeCPFECNPJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void validarCPFECNPJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void btnGeradorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GerarCPF()
        {
            Random random = new Random();
            int[] cpfArray = new int[11];

            for (int i = 0; i < 9; i++)
            {
                int randomNumber = random.Next(10);
                cpfArray[i] = randomNumber;
            }

            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += cpfArray[i] * (10 - i);
            }

            int primeiroDigito = (soma * 10) % 11;
            primeiroDigito = (primeiroDigito == 10 || primeiroDigito == 11) ? 0 : primeiroDigito;
            cpfArray[9] = primeiroDigito;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += cpfArray[i] * (11 - i);
            }
            int segundoDigito = (soma * 10) % 11;
            segundoDigito = (segundoDigito == 10 || segundoDigito == 11) ? 0 : segundoDigito;
            cpfArray[10] = segundoDigito;

            string cpfGerado = $"{cpfArray[0]}{cpfArray[1]}{cpfArray[2]}.{cpfArray[3]}{cpfArray[4]}{cpfArray[5]}.{cpfArray[6]}{cpfArray[7]}{cpfArray[8]}-{cpfArray[9]}{cpfArray[10]}";

            txtGeradorCPFeCNPJ.Text = cpfGerado;
        }

        private void GerarCNPJ()
        {
            Random random = new Random();
            int[] cnpjArray = new int[14];



            for (int i = 0; i < cnpjArray.Length; i++)
            {
                int randomNumber = random.Next(10);
                cnpjArray[i] = randomNumber;
            }



            int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };



            int soma1 = 0;
            for (int i = 0; i < 12; i++)
            {
                soma1 += cnpjArray[i] * peso1[i];
            }



            int resto1 = soma1 % 11;
            resto1 = (resto1 < 2) ? 0 : 11 - resto1;



            cnpjArray[12] = resto1;



            int soma2 = 0;
            for (int i = 0; i < 13; i++)
            {
                soma2 += cnpjArray[i] * peso2[i];
            }



            int resto2 = soma2 % 11;
            resto2 = (resto2 < 2) ? 0 : 11 - resto2;



            cnpjArray[13] = resto2;



            string cnpj = string.Concat(cnpjArray);
            string cnpjFormatado = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";



            txtGeradorCPFeCNPJ.Text = cnpjFormatado;
        }

        private void btnGeradorOK_Click(object sender, EventArgs e)
        {
            if (rdbGeradorCPF.Checked)
            {
                GerarCPF();

            }
            else if (rdbGeradorCNPJ.Checked)
            {
                GerarCNPJ();
            }
        }
    }
}
    
    

    

