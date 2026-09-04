using System.Configuration;
using System.Data.SqlClient;

namespace Biblioteca.DAL
{
    public class Conexao
    {
        private string connectionString;
        public Conexao() 
        {
            connectionString = ConfigurationManager.ConnectionStrings["BibliotecaConnectionString"].ConnectionString;
        }
        public SqlConnection AbrirConexao()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
