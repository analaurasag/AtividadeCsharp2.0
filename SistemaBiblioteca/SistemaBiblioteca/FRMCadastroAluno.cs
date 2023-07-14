using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class frmCadastroAluno : Form
    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        public frmCadastroAluno()
        {
            InitializeComponent();
            // String de conexão
            conexaoString = "Data Source=MAR0625644W10-1;Initial Catalog=Biblioteca;Integrated Security=True";
            
            //Inicializando a conexão com banco de dados
            conexaoDB = new SqlConnection(conexaoString);
        }


        private void frmCadastroAluno_Load(object sender, EventArgs e)
        {
            carregarDadosAlunos();
        }
        private void carregarDadosAlunos()
        {
            try
            {
                conexaoDB.Open();
                string Sql = "SELECT * FROM Alunos";

                SqlDataAdapter Adapter = new SqlDataAdapter(Sql, conexaoDB);
                DataTable dataTable = new DataTable();
                Adapter.Fill(dataTable);

                dgvAlunos.DataSource = dataTable;
                conexaoDB.Close();
            } catch (SqlException ex) 
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
              
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Alunos(Nome, CPF, Email, Telefone, Celular, Data_Nascimento) VALUES (@Nome, @CPF, @Email, @Telefone, @Celular, @Data_Nascimento) ";
                conexaoDB.Open();
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("Nome", txtNome.Text);
                sqlCmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                sqlCmd.Parameters.AddWithValue("Email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("Telefone", txtTelefone.Text);
                sqlCmd.Parameters.AddWithValue("Celular", txtCelular.Text);
                DateTime dataNascimento;
                DateTime.TryParse(txtDataNascimento.Text, out dataNascimento);
                sqlCmd.Parameters.AddWithValue("@Data_Nascimento", dataNascimento);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso.");
                conexaoDB.Close();
                carregarDadosAlunos();
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex);
            }


        }
    }
}
