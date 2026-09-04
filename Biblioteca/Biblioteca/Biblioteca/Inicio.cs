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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                this.Hide();
                Cadastrar cadastrarForm = new Cadastrar();
                cadastrarForm.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar mostrarForm = new Mostrar();
            mostrarForm.Show();
        }

        private void btnRemoverLivros_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoverLivros removerForm = new RemoverLivros();
            removerForm.Show();
        }
    }
}
