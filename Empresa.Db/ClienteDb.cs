using System.Data.SqlClient;
using Empresa.Models;

namespace Empresa.Db
{
    public class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand("INSERT INTO Cliente (Nome, Email, Telefone)" +
                "VALUES(@Nome, @Email, @Telefone)", cn);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Alterar(Cliente cliente)
        {
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand("UPDATE Cliente SET Nome=@Nome, Email=@Email, Telefone=@Telefone " +
                "WHERE Id=@Id", cn);
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Excluir(int Id)
        {
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand("DELETE Cliente WHERE Id=@Id", cn);
            cmd.Parameters.AddWithValue("@Id", Id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public List<Cliente> Listar()
        {
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand("SELECT Id, Nome, Email, Telefone FROM Cliente", cn);

            List<Cliente> list = new List<Cliente>();
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

                list.Add(cliente);
            }

            return list;
        }

        public Cliente ObterPorId(int id)
        {
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand("SELECT Id, Nome, Email, Telefone FROM Cliente WHERE Id=@Id", cn);
            cmd.Parameters.AddWithValue("@Id", id);

            Cliente cliente = new Cliente();

            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente.Id = Convert.ToInt32(reader["Id"]);
                cliente.Nome = reader["Nome"].ToString();
                cliente.Email = reader["Email"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();
            }

            return cliente;
        }
    }
}
