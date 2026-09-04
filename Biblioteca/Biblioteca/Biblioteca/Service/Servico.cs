using Biblioteca.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Service
{
    public class Servico
    {
        private Conexao conexao = new Conexao();
        public bool cadastrarLivro(Livro livro)
        {

            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    string sqlQuery = @"INSERT INTO Livro (Nome, Categoria, Quantidade) 
                                VALUES (@Nome,@Categoria,@Quantidade)";


                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                    cmd.Parameters.AddWithValue("@Nome", livro.Nome);
                    cmd.Parameters.AddWithValue("@Categoria", livro.Categoria);
                    cmd.Parameters.AddWithValue("@Quantidade", livro.Quantidade);

                    cmd.ExecuteNonQuery();
                } 
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar livro");
                return false;
            }
            
           
            return true;
        }
        public List<Livro> mostrarLivros()
        {
            try
            {
                List<Livro> livros = new List<Livro>();
                Conexao conexao = new Conexao();
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    string sql = "SELECT * FROM Livro";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livro livro = new Livro();
                            livro.idLivro = reader.GetInt32(reader.GetOrdinal("idLivro"));
                            livro.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                            livro.Categoria = reader.GetString(reader.GetOrdinal("Categoria"));
                            livro.Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade"));

                            livros.Add(livro);
                        }
                    }
                }
                return livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao mostrar livros\nErro:\n{ex}");
                return null;
            }
    
                
            }
        }
    }

