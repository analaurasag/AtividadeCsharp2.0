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
    public partial class FRMCadastroLivro : Form
    {

        public string conexaoStringLivro;
        private SqlConnection conexaoDBLivro;
        public FRMCadastroLivro()
        {
            InitializeComponent();
            conexaoStringLivro = "Data Source=MAR0625644W10-1;Initial Catalog=Biblioteca;Integrated Security=True";
            conexaoDBLivro = new SqlConnection(conexaoStringLivro);
        }
        private void FRMCadastroLivro_Load(object sender, EventArgs e)
        {
            carregarDadosLivros();
        }
        private void carregarDadosLivros()
        {
            try
            {
                conexaoDBLivro.Open();
                string Sql = "SELECT * FROM Livros";

                SqlDataAdapter Adapter = new SqlDataAdapter(Sql, conexaoDBLivro);
                DataTable dataTable = new DataTable();
                Adapter.Fill(dataTable);

                dgvLivros.DataSource = dataTable;
                conexaoDBLivro.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao carregar dados." + ex);
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Livros(Título, Autor, NumeroPaginas, Preco, AnoPublicacao, ISBN) VALUES (@Título, @Autor, @NumeroPaginas, @Preco, @AnoPublicacao, @ISBN)";
                conexaoDBLivro.Open();
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDBLivro);

                sqlCmd.Parameters.AddWithValue("Título", txtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("Autor", txtAutor.Text);
                sqlCmd.Parameters.AddWithValue("NumeroPaginas", txtNumeroPaginas.Text);
                sqlCmd.Parameters.AddWithValue("Preco", txtPreco.Text);
                sqlCmd.Parameters.AddWithValue("AnoPublicacao", txtAnoPublicacao.Text);
                sqlCmd.Parameters.AddWithValue("ISBN", txtISBN.Text);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso.");
                conexaoDBLivro.Close();
                carregarDadosLivros();
            } catch (SqlException ex) 
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex);
            }
        }
    }
}
