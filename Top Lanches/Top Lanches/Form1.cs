namespace Top_Lanches
{
    public partial class Form1 : Form
    {
        double valorHamburguer, valorOvo, valorPresunto, valorMussarela, valorBacon, valorFrango, valorAlface, valorTomate, valorMilhoverde, valorErvilha, valorTotalPedido, valorTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Somar()
        {
            valorTotalPedido = valorHamburguer + valorOvo + valorPresunto + valorMussarela + valorBacon + valorFrango + valorAlface + valorTomate + valorMilhoverde + valorErvilha;
            textBoxTotalLanche.Text = valorTotalPedido.ToString("F2");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void numericUpDownHamburguer_ValueChanged(object sender, EventArgs e)
        {
            valorHamburguer = (double)numericUpDownHamburguer.Value * 2;
            textBoxHamburguerReais.Text = valorHamburguer.ToString("F2");
            Somar();
        }
            
        private void textBoxHamburguerReais_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxValorTotalPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownOvo_ValueChanged(object sender, EventArgs e)
        {
            valorOvo = (double) numericUpDownOvo.Value *2;
            textBoxOvoReais.Text = valorOvo.ToString("F2");
            Somar();
        }

       

        private void numericUpDownPresunto_ValueChanged(object sender, EventArgs e)
        {
            valorPresunto = (double)numericUpDownPresunto.Value * 1;
            textBoxPresuntoReais.Text = valorPresunto.ToString("F2");
            Somar();
        }

        private void numericUpDownMussarela_ValueChanged(object sender, EventArgs e)
        {
            valorMussarela = (double)numericUpDownMussarela.Value * 1.5;
            textBoxMussarelaReais.Text = valorMussarela.ToString("F2");
            Somar();
        }

        private void numericUpDownBacon_ValueChanged(object sender, EventArgs e)
        {
            valorBacon = (double)numericUpDownBacon.Value * 2;
            textBoxBaconReais.Text = valorOvo.ToString("F2");
            Somar();
        }

        private void numericUpDownFrango_ValueChanged(object sender, EventArgs e)
        {
            valorFrango = (double)numericUpDownFrango.Value * 1.5;
            textBoxFrangoReais.Text = valorFrango.ToString("F2");
            Somar();
        }

        private void numericUpDownAlface_ValueChanged(object sender, EventArgs e)
        {
            valorAlface = (double)numericUpDownAlface.Value * 0.5;
            textBoxAlfaceReais.Text = valorAlface.ToString("F2");
            Somar();
        }

        private void numericUpDownTomate_ValueChanged(object sender, EventArgs e)
        {
            valorTomate = (double)numericUpDownTomate.Value * 0.7;
            textBoxTomateReais.Text = valorTomate.ToString("F2");
            Somar();
        }

        private void numericUpDownMilhoverde_ValueChanged(object sender, EventArgs e)
        {
            valorMilhoverde = (double)numericUpDownMilhoverde.Value * 0.5;
            textBoxMilhoverdeReais.Text = valorMilhoverde.ToString("F2");
            Somar();
        }

        private void numericUpDownErvilha_ValueChanged(object sender, EventArgs e)
        {
            valorErvilha = (double)numericUpDownErvilha.Value * 0.5ss;
            textBoxErvilhaReais.Text = valorErvilha.ToString("F2");
            Somar();
        }

        private void checkBoxHamburguer_CheckedChanged(object sender, EventArgs e)
        {
        if (checkBoxHamburguer.Checked == true)
            {
                numericUpDownHamburguer.Enabled = true;
                textBoxHamburguerReais.Enabled = true;
            }
            else
            {
                numericUpDownHamburguer.Enabled = false;
                textBoxHamburguerReais.Enabled = false;
                textBoxHamburguerReais.Text = "0,00";

                ;
            }
        }

        private void checkBoxOvo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOvo.Checked == true)
            {
                textBoxOvoReais.Enabled = true;  
                numericUpDownOvo.Enabled = true;
            }
            else
            {
                numericUpDownOvo.Enabled = false;
                textBoxOvoReais.Enabled = false;
                textBoxOvoReais.Text = "0,00";

                ;
            }
        }

        private void checkBoxPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPresunto.Checked == true)
            {
                numericUpDownPresunto.Enabled = true;
                textBoxPresuntoReais.Enabled = true;
            }
            else {
                numericUpDownPresunto.Enabled = false;
                textBoxPresuntoReais.Enabled = false;
                textBoxPresuntoReais.Text = "0,00";

                ; }
        }

        private void checkBoxMussarela_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMussarela.Checked == true)
            {
                numericUpDownMussarela.Enabled = true;
                textBoxMussarelaReais.Enabled = true;
            }
            else
            {
                numericUpDownMussarela.Enabled = false;
                textBoxMussarelaReais.Enabled = false;
                textBoxMussarelaReais.Text = "0,00";

                ;
            }
        }

        private void checkBoxBacon_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBacon.Checked == true)
            {
                numericUpDownBacon.Enabled = true;
                textBoxBaconReais.Enabled = true;
            }
            else
            {
                numericUpDownBacon.Enabled = false;
                textBoxBaconReais.Enabled = false;
                textBoxBaconReais.Text = "0,00";
                ;
            }
        }

        private void checkBoxFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrango.Checked == true)
            {
                numericUpDownFrango.Enabled = true;
                textBoxFrangoReais.Enabled = true;
            }
            else
            {
                numericUpDownFrango.Enabled = false;
                textBoxFrangoReais.Enabled = false;
                textBoxFrangoReais.Text = "0,00";
                ;
            }
        }

        private void checkBoxAlface_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlface.Checked == true)
            {
                numericUpDownAlface.Enabled = true;
                textBoxAlfaceReais.Enabled = true;
            }
            else
            {
                numericUpDownAlface.Enabled = false;
                textBoxAlfaceReais.Enabled = false;
                textBoxAlfaceReais.Text = "0,00";
                ;
            }
        }

        private void checkBoxTomate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTomate.Checked == true)
            {
                textBoxTomateReais.Enabled = true;
                numericUpDownTomate.Enabled = true; 
            }
            else
            {
                textBoxTomateReais.Enabled = false;
                numericUpDownTomate.Enabled = false;
                numericUpDownTomate.Text = "0,00";
                ;
            }
        }

        private void checkBoxMilhoverde_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMilhoverde.Checked == true)
            {
                textBoxMilhoverdeReais.Enabled = true;
                numericUpDownMilhoverde.Enabled = true;
            }
            else
            {
                textBoxMilhoverdeReais.Enabled = false;
                numericUpDownMilhoverde.Enabled = false;
                numericUpDownMilhoverde.Text = "0,00";
                ;
            }
        }

        private void checkBoxErvilha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxErvilha.Checked == true)
            {
                textBoxErvilhaReais.Enabled = true;
                numericUpDownErvilha.Enabled = true;
            }
            else
            {
                textBoxErvilhaReais.Enabled = false;
                numericUpDownErvilha.Enabled = false;
                numericUpDownErvilha.Text = "0,00";
                ;
            }
        }
    }
}