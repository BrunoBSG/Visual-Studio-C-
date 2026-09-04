
using System;
using System.Linq;
using System.Windows.Forms;
using Biblioteca.DAL;
using Biblioteca.Service;
namespace Biblioteca
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
        }

        private void loadMostrar(object sender, EventArgs e)
        {
            mostrarTododsLivros();
        }

        public void mostrarTododsLivros()
        {
            lbMostrar.Items.Clear();
            Servico servico = new Servico();
            foreach (Livro livro in servico.mostrarLivros())
            {
                lbMostrar.Items.Add($"ID: {livro.idLivro}, Nome: {livro.Nome}, Categoria: {livro.Categoria}, Quantidade: {livro.Quantidade}");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.Trim();

            if (string.IsNullOrEmpty(pesquisa))
            {
                MessageBox.Show("Digite um valor para pesquisar.");
                return;
            }

            string tipoPesquisa = comboBoxTipodapesquisa.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tipoPesquisa))
            {
                MessageBox.Show("Selecione um tipo de pesquisa.");
                return;
            }

            lbMostrar.Items.Clear();

            Servico servico = new Servico();

            foreach (Livro livro in servico.mostrarLivros())
            {
                bool encontrou = false;

                if (tipoPesquisa == "Nome" &&
                    livro.Nome.Contains(pesquisa))
                {
                    encontrou = true;
                }
                else if (tipoPesquisa == "Categoria" &&
                         livro.Categoria.Contains(pesquisa))
                {
                    encontrou = true;
                }
                else if (tipoPesquisa == "Quantidade" &&
                         livro.Quantidade.ToString().Contains(pesquisa))
                {
                    encontrou = true;
                }
                else if (tipoPesquisa == "idLivro" &&
                         livro.idLivro.ToString().Contains(pesquisa))
                {
                    encontrou = true;
                }

                if (encontrou)
                {
                    lbMostrar.Items.Add(
                        $"ID: {livro.idLivro}, " +
                        $"Nome: {livro.Nome}, " +
                        $"Categoria: {livro.Categoria}, " +
                        $"Quantidade: {livro.Quantidade}"
                    );
                }
            }

            if (lbMostrar.Items.Count == 0)
            {
                MessageBox.Show("Nenhum resultado encontrado.");
            }
        }

        private void btnMostrarTodosLivros_Click(object sender, EventArgs e)
        {
            mostrarTododsLivros();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MostrarBank mostrarBankForm = new MostrarBank();
            mostrarBankForm.Show();
        }
    }
}
