namespace Calc
{
    public partial class Form1 : Form
        
    {

        string operacaoselecionada;
        int valor = 0;
        int resultado = 0;  
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor += int.Parse(texVisor.Text);
            lblVisor.Text = "+";
            operacaoselecionada = "Soma";
            texVisor.Text = "";
        }

        private void buttonone_Click(object sender, EventArgs e)
        {

        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            valor = int.Parse(texVisor.Text);
            lblVisor.Text = "-";
            operacaoselecionada = "Subtracao";
            texVisor.Text = "";
        }

        private void texVisor_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void buttonvezes_Click(object sender, EventArgs e)
        {
            if (valor == 0) { valor = 1; }
            valor *= int.Parse(texVisor.Text);
            lblVisor.Text = "x";
            operacaoselecionada = "Multiplicacao";
            texVisor.Text = "";
        }

        private void buttondivisao_Click(object sender, EventArgs e)
        {
            
            valor = int.Parse(texVisor.Text);
            lblVisor.Text = "÷";
            operacaoselecionada = "Divisao";
            texVisor.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            //IGUAL
            switch (operacaoselecionada)
            {
                case "Soma":
                    resultado = valor + int.Parse(texVisor.Text);

                    break;
                case "Subtracao":
                    resultado = valor - int.Parse(texVisor.Text);
                    break;
                case "Divisao":
                    resultado = valor / int.Parse(texVisor.Text);
                    break;
                case "Multiplicacao":
                    resultado = valor * int.Parse(texVisor.Text);
                    break;
               
            }
            lblVisor.Text = "";
            texVisor.Text = resultado.ToString();

        }

        private void inserirNu(object sender, EventArgs e)
        {

        }

        private void inserirNumero(object sender, EventArgs e)
        {
            //evento 
            texVisor.Text += ((Button)sender).Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //clear all
            texVisor.Text = "";
            valor = 0;
            operacaoselecionada = null;
            resultado = 0;
            lblVisor.Text = "";
            
        }
    }
}