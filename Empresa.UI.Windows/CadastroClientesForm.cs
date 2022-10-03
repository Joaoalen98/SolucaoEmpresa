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

namespace WindowsApp
{
    public partial class CadastroClientesForm : Form
    {
        public CadastroClientesForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CadastroClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string nome = nomeTextBox.Text;
            string email = emailTextBox.Text;
            string telefone = telefoneTextBox.Text;


            try
            {
                string sqlConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial " +
                    "Catalog=Empresa;Integrated Security=True;Connect " +
                    "Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var db = new SqlConnection(sqlConnectionString);
                db.Open();

                var query = new SqlCommand("INSERT INTO Cliente (Id, Nome, Email, Telefone)" +
                    $"VALUES (@Id, @Nome, @Email, @Telefone)");
                query.Connection = db;

                query.Parameters.AddWithValue("@Id", id);
                query.Parameters.AddWithValue("@Nome", nome);
                query.Parameters.AddWithValue("@Email", email);
                query.Parameters.AddWithValue("@Telefone", telefone);

                int rowsAffect = query.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado com sucesso");
                db.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void listarUsuariosButton_Click(object sender, EventArgs e)
        {

           
        }
    }
}
