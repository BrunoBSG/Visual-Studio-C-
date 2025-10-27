namespace Calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texVisor = new System.Windows.Forms.TextBox();
            this.buttonigual = new System.Windows.Forms.Button();
            this.buttonmais = new System.Windows.Forms.Button();
            this.buttonmenos = new System.Windows.Forms.Button();
            this.buttonvezes = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.buttoneight = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonvirgula = new System.Windows.Forms.Button();
            this.buttonthree = new System.Windows.Forms.Button();
            this.buttontwo = new System.Windows.Forms.Button();
            this.buttonone = new System.Windows.Forms.Button();
            this.buttonsix = new System.Windows.Forms.Button();
            this.buttonfive = new System.Windows.Forms.Button();
            this.buttonfour = new System.Windows.Forms.Button();
            this.buttonseven = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttondivisao = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.buttonapagar = new System.Windows.Forms.Button();
            this.lblOpercao = new System.Windows.Forms.Label();
            this.lblVisor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texVisor
            // 
            this.texVisor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texVisor.Location = new System.Drawing.Point(12, 53);
            this.texVisor.Multiline = true;
            this.texVisor.Name = "texVisor";
            this.texVisor.Size = new System.Drawing.Size(533, 84);
            this.texVisor.TabIndex = 0;
            this.texVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.texVisor.TextChanged += new System.EventHandler(this.texVisor_TextChanged);
            // 
            // buttonigual
            // 
            this.buttonigual.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonigual.Location = new System.Drawing.Point(421, 511);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(124, 66);
            this.buttonigual.TabIndex = 1;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = true;
            this.buttonigual.Click += new System.EventHandler(this.buttonigual_Click);
            // 
            // buttonmais
            // 
            this.buttonmais.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonmais.Location = new System.Drawing.Point(421, 439);
            this.buttonmais.Name = "buttonmais";
            this.buttonmais.Size = new System.Drawing.Size(124, 66);
            this.buttonmais.TabIndex = 2;
            this.buttonmais.Text = "+";
            this.buttonmais.UseVisualStyleBackColor = true;
            this.buttonmais.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonmenos
            // 
            this.buttonmenos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonmenos.Location = new System.Drawing.Point(421, 367);
            this.buttonmenos.Name = "buttonmenos";
            this.buttonmenos.Size = new System.Drawing.Size(124, 66);
            this.buttonmenos.TabIndex = 3;
            this.buttonmenos.Text = "-";
            this.buttonmenos.UseVisualStyleBackColor = true;
            this.buttonmenos.Click += new System.EventHandler(this.buttonmenos_Click);
            // 
            // buttonvezes
            // 
            this.buttonvezes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonvezes.Location = new System.Drawing.Point(421, 295);
            this.buttonvezes.Name = "buttonvezes";
            this.buttonvezes.Size = new System.Drawing.Size(124, 66);
            this.buttonvezes.TabIndex = 4;
            this.buttonvezes.Text = "x";
            this.buttonvezes.UseVisualStyleBackColor = true;
            this.buttonvezes.Click += new System.EventHandler(this.buttonvezes_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nine.Location = new System.Drawing.Point(291, 295);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(124, 66);
            this.nine.TabIndex = 5;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttoneight
            // 
            this.buttoneight.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttoneight.Location = new System.Drawing.Point(161, 295);
            this.buttoneight.Name = "buttoneight";
            this.buttoneight.Size = new System.Drawing.Size(124, 66);
            this.buttoneight.TabIndex = 6;
            this.buttoneight.Text = "8";
            this.buttoneight.UseVisualStyleBackColor = true;
            this.buttoneight.Click += new System.EventHandler(this.inserirNumero);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(31, 511);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 66);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(161, 511);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 66);
            this.button8.TabIndex = 8;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttonvirgula
            // 
            this.buttonvirgula.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonvirgula.Location = new System.Drawing.Point(291, 511);
            this.buttonvirgula.Name = "buttonvirgula";
            this.buttonvirgula.Size = new System.Drawing.Size(124, 66);
            this.buttonvirgula.TabIndex = 9;
            this.buttonvirgula.Text = ",";
            this.buttonvirgula.UseVisualStyleBackColor = true;
            // 
            // buttonthree
            // 
            this.buttonthree.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonthree.Location = new System.Drawing.Point(291, 439);
            this.buttonthree.Name = "buttonthree";
            this.buttonthree.Size = new System.Drawing.Size(124, 66);
            this.buttonthree.TabIndex = 12;
            this.buttonthree.Text = "3";
            this.buttonthree.UseVisualStyleBackColor = true;
            this.buttonthree.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttontwo
            // 
            this.buttontwo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttontwo.Location = new System.Drawing.Point(161, 439);
            this.buttontwo.Name = "buttontwo";
            this.buttontwo.Size = new System.Drawing.Size(124, 66);
            this.buttontwo.TabIndex = 11;
            this.buttontwo.Text = "2";
            this.buttontwo.UseVisualStyleBackColor = true;
            this.buttontwo.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttonone
            // 
            this.buttonone.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonone.Location = new System.Drawing.Point(31, 439);
            this.buttonone.Name = "buttonone";
            this.buttonone.Size = new System.Drawing.Size(124, 66);
            this.buttonone.TabIndex = 10;
            this.buttonone.Text = "1";
            this.buttonone.UseVisualStyleBackColor = true;
            this.buttonone.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttonsix
            // 
            this.buttonsix.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsix.Location = new System.Drawing.Point(291, 367);
            this.buttonsix.Name = "buttonsix";
            this.buttonsix.Size = new System.Drawing.Size(124, 66);
            this.buttonsix.TabIndex = 15;
            this.buttonsix.Text = "6";
            this.buttonsix.UseVisualStyleBackColor = true;
            this.buttonsix.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttonfive
            // 
            this.buttonfive.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonfive.Location = new System.Drawing.Point(161, 367);
            this.buttonfive.Name = "buttonfive";
            this.buttonfive.Size = new System.Drawing.Size(124, 66);
            this.buttonfive.TabIndex = 14;
            this.buttonfive.Text = "5";
            this.buttonfive.UseVisualStyleBackColor = true;
            this.buttonfive.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttonfour
            // 
            this.buttonfour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonfour.Location = new System.Drawing.Point(31, 367);
            this.buttonfour.Name = "buttonfour";
            this.buttonfour.Size = new System.Drawing.Size(124, 66);
            this.buttonfour.TabIndex = 13;
            this.buttonfour.Text = "4";
            this.buttonfour.UseVisualStyleBackColor = true;
            this.buttonfour.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttonseven
            // 
            this.buttonseven.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonseven.Location = new System.Drawing.Point(31, 295);
            this.buttonseven.Name = "buttonseven";
            this.buttonseven.Size = new System.Drawing.Size(124, 66);
            this.buttonseven.TabIndex = 16;
            this.buttonseven.Text = "7";
            this.buttonseven.UseVisualStyleBackColor = true;
            this.buttonseven.Click += new System.EventHandler(this.inserirNumero);
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonclear.Location = new System.Drawing.Point(291, 223);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(124, 66);
            this.buttonclear.TabIndex = 17;
            this.buttonclear.Text = "C";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.button17_Click);
            // 
            // buttondivisao
            // 
            this.buttondivisao.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttondivisao.Location = new System.Drawing.Point(421, 223);
            this.buttondivisao.Name = "buttondivisao";
            this.buttondivisao.Size = new System.Drawing.Size(124, 66);
            this.buttondivisao.TabIndex = 18;
            this.buttondivisao.Text = "÷";
            this.buttondivisao.UseVisualStyleBackColor = true;
            this.buttondivisao.Click += new System.EventHandler(this.buttondivisao_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(161, 223);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(124, 66);
            this.button19.TabIndex = 19;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.Location = new System.Drawing.Point(31, 223);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(124, 66);
            this.button20.TabIndex = 20;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // buttonapagar
            // 
            this.buttonapagar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonapagar.Location = new System.Drawing.Point(421, 151);
            this.buttonapagar.Name = "buttonapagar";
            this.buttonapagar.Size = new System.Drawing.Size(124, 66);
            this.buttonapagar.TabIndex = 21;
            this.buttonapagar.Text = "⌫";
            this.buttonapagar.UseVisualStyleBackColor = true;
            // 
            // lblOpercao
            // 
            this.lblOpercao.AutoSize = true;
            this.lblOpercao.Location = new System.Drawing.Point(32, 77);
            this.lblOpercao.Name = "lblOpercao";
            this.lblOpercao.Size = new System.Drawing.Size(0, 15);
            this.lblOpercao.TabIndex = 22;
            // 
            // lblVisor
            // 
            this.lblVisor.AutoSize = true;
            this.lblVisor.Location = new System.Drawing.Point(30, 67);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(0, 15);
            this.lblVisor.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 634);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.lblOpercao);
            this.Controls.Add(this.buttonapagar);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.buttondivisao);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonseven);
            this.Controls.Add(this.buttonsix);
            this.Controls.Add(this.buttonfive);
            this.Controls.Add(this.buttonfour);
            this.Controls.Add(this.buttonthree);
            this.Controls.Add(this.buttontwo);
            this.Controls.Add(this.buttonone);
            this.Controls.Add(this.buttonvirgula);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttoneight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.buttonvezes);
            this.Controls.Add(this.buttonmenos);
            this.Controls.Add(this.buttonmais);
            this.Controls.Add(this.buttonigual);
            this.Controls.Add(this.texVisor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox texVisor;
        private Button buttonigual;
        private Button buttonmais;
        private Button buttonmenos;
        private Button buttonvezes;
        private Button nine;
        private Button buttoneight;
        private Button button7;
        private Button button8;
        private Button buttonvirgula;
        private Button buttonthree;
        private Button buttontwo;
        private Button buttonone;
        private Button buttonsix;
        private Button buttonfive;
        private Button buttonfour;
        private Button buttonseven;
        private Button buttonclear;
        private Button buttondivisao;
        private Button button19;
        private Button button20;
        private Button buttonapagar;
        private Label lblOpercao;
        private Label lblVisor;
    }
}