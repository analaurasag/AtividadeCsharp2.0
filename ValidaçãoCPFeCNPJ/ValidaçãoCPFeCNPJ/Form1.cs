using System;
using System.Linq;
using System.Windows.Forms;

namespace ValidaçãoCPFeCNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeLifetimeService();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbCPF.Checked)
            {
                string cpf = txtCPFeCNPJ.Text;
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
        }
    }
}
            
    

