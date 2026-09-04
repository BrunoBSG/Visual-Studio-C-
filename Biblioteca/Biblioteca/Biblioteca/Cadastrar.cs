using System;
using System.Drawing;
using System.Windows.Forms;
using Biblioteca.DAL;
using Biblioteca.Service;

namespace Biblioteca
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome do Livro");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Preencha o campo Categoria");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Preencha o campo Quantidade");
                return;
            }

            Servico servico = new Service.Servico();

            Livro l = new Livro();
            l.Nome = txtNome.Text;
            l.Categoria = txtCategoria.Text;
            l.Quantidade = int.Parse(txtQuantidade.Text);

            if (servico.cadastrarLivro(l)) 
            { 
                MessageBox.Show("Livro cadastrado com sucesso!");
            }

            this.Close();
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterNome(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome do Livro")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
            }
        }

        private void loadCadastrar(object sender, EventArgs e)
        {
            txtNome.Text = "Nome do Livro";
            txtCategoria.Text = "Categoria";
            txtQuantidade.Text = "Quantidade";
            txtNome.ForeColor = Color.Gray;
            txtCategoria.ForeColor = Color.Gray;
            txtQuantidade.ForeColor = Color.Gray;
        }

        private void leaveNome(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome do Livro";
                txtNome.ForeColor = Color.Gray;
            }
        }

        private void leaveCategoria(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                txtCategoria.Text = "Categoria";
                txtCategoria.ForeColor = Color.Gray;
            }
        }

        private void enterCategoria(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = "";
                txtCategoria.ForeColor = Color.Black;
            }
        }

        private void leaveQuantidade(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                txtQuantidade.Text = "Quantidade";
                txtQuantidade.ForeColor = Color.Gray;
            }
        }

        private void enterQuantidade(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "Quantidade")
            {
                txtQuantidade.Text = "";
                txtQuantidade.ForeColor = Color.Black;
            }
        }


    }
}
