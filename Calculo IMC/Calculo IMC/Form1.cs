namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        TextBox textativo;
        double calculo, altura, peso;
         

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEventClick(object sender, EventArgs e)
        {
            //event de click
            if (textativo != null)
            {
                Button botao = (Button)sender;
                textativo.Text += botao.Text;
                string valor = botao.Text;
                if (valor == "," && textativo.Text.Contains(","))
                {
                    return;
                }
            }
            //Impede mais e uma virgula
            

        }

        private void Focus1(object sender, EventArgs e)
        {
            textBoxAltura.BackColor = System.Drawing.Color.White;
            textboxPeso.BackColor = System.Drawing.Color.Red;
            
            textativo = textboxPeso;
        }
        private void FocusTwo(object sender, EventArgs e)
        {
            textboxPeso.BackColor = System.Drawing.Color.White;
            textBoxAltura.BackColor = System.Drawing.Color.Red;
            textativo = textBoxAltura;
        }

        private void FocusLeave1(object sender, EventArgs e)
        {
            
        }

        private void FocusTwoLeave(object sender, EventArgs e)
        {
            
        }

        private void ButtonEventClickDEL(object sender, EventArgs e)
        {
            textativo.Text = "";
            if (textativo == textboxPeso)
            {
                peso = 0;
            }
            if (textativo == textBoxAltura)
            {
                altura = 0;
            }   
        }
        private void buttonCalculo_Click(object sender, EventArgs e)
        {
            
            altura = double.Parse(textBoxAltura.Text);
            peso = double.Parse(textboxPeso.Text);
            calculo = peso/(altura * altura);
            calculo = Math.Round(calculo, 2);
            textBoxIMC.Text = calculo.ToString ();
            
        }
    }
}
