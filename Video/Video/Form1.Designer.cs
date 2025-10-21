namespace Video
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOrdens = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonReporting = new System.Windows.Forms.Button();
            this.buttonNotifications = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.buttonSetting);
            this.panel1.Controls.Add(this.buttonNotifications);
            this.panel1.Controls.Add(this.buttonReporting);
            this.panel1.Controls.Add(this.buttonCustomer);
            this.panel1.Controls.Add(this.buttonOrdens);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 493);
            this.panel1.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::Video.Properties.Resources.icons8_carrinho_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Products";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonOrdens
            // 
            this.buttonOrdens.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrdens.FlatAppearance.BorderSize = 0;
            this.buttonOrdens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdens.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOrdens.Image = global::Video.Properties.Resources.icons8_lista_de_tarefas_48;
            this.buttonOrdens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrdens.Location = new System.Drawing.Point(0, 140);
            this.buttonOrdens.Name = "buttonOrdens";
            this.buttonOrdens.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonOrdens.Size = new System.Drawing.Size(220, 60);
            this.buttonOrdens.TabIndex = 2;
            this.buttonOrdens.Text = "Ordens";
            this.buttonOrdens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrdens.UseVisualStyleBackColor = true;
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCustomer.Image = global::Video.Properties.Resources.icons8_usuário_de_gênero_neutro_50;
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.Location = new System.Drawing.Point(0, 200);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCustomer.Size = new System.Drawing.Size(220, 60);
            this.buttonCustomer.TabIndex = 3;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonReporting
            // 
            this.buttonReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReporting.FlatAppearance.BorderSize = 0;
            this.buttonReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporting.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonReporting.Image = global::Video.Properties.Resources.icons8_carrinho_48;
            this.buttonReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporting.Location = new System.Drawing.Point(0, 260);
            this.buttonReporting.Name = "buttonReporting";
            this.buttonReporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonReporting.Size = new System.Drawing.Size(220, 60);
            this.buttonReporting.TabIndex = 4;
            this.buttonReporting.Text = "Reporting";
            this.buttonReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReporting.UseVisualStyleBackColor = true;
            // 
            // buttonNotifications
            // 
            this.buttonNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotifications.FlatAppearance.BorderSize = 0;
            this.buttonNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotifications.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNotifications.Image = global::Video.Properties.Resources.icons8_sino_50;
            this.buttonNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotifications.Location = new System.Drawing.Point(0, 320);
            this.buttonNotifications.Name = "buttonNotifications";
            this.buttonNotifications.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonNotifications.Size = new System.Drawing.Size(220, 60);
            this.buttonNotifications.TabIndex = 5;
            this.buttonNotifications.Text = "Notifications";
            this.buttonNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNotifications.UseVisualStyleBackColor = true;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSetting.Image = global::Video.Properties.Resources.icons8_configurações_50;
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(0, 380);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSetting.Size = new System.Drawing.Size(220, 60);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 493);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "|";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonSetting;
        private Button buttonNotifications;
        private Button buttonReporting;
        private Button buttonCustomer;
        private Button buttonOrdens;
        private Button button1;
        private Panel panelLogo;
    }
}