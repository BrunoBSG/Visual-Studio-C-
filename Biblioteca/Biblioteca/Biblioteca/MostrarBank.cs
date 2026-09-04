using Biblioteca.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class MostrarBank : Form
    {
        public MostrarBank()
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
            Mostrar mostrarForm = new Mostrar();
            mostrarForm.Show();
        }

        private void loadMostrarBank(object sender, EventArgs e)
        {
            Service.Servico servico = new Service.Servico();
            List<Livro> Livros = servico.mostrarLivros();
            dataGridView1.DataSource = Livros;

        }
    }
}
