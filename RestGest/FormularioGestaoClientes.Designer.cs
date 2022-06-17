namespace WindowsFormsApp1
{
    partial class FormularioGestaoClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            this.buttonApagarCliente = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.textBoxTotalGasto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumContribuinte = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(9, 10);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(212, 316);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(9, 346);
            this.buttonAdicionarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(211, 19);
            this.buttonAdicionarCliente.TabIndex = 1;
            this.buttonAdicionarCliente.Text = "Adicionar Cliente";
            this.buttonAdicionarCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.Location = new System.Drawing.Point(9, 370);
            this.buttonEditarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(211, 19);
            this.buttonEditarCliente.TabIndex = 2;
            this.buttonEditarCliente.Text = "Editar Cliente";
            this.buttonEditarCliente.UseVisualStyleBackColor = true;
            this.buttonEditarCliente.Click += new System.EventHandler(this.buttonEditarCliente_Click);
            // 
            // buttonApagarCliente
            // 
            this.buttonApagarCliente.Location = new System.Drawing.Point(9, 393);
            this.buttonApagarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonApagarCliente.Name = "buttonApagarCliente";
            this.buttonApagarCliente.Size = new System.Drawing.Size(211, 19);
            this.buttonApagarCliente.TabIndex = 3;
            this.buttonApagarCliente.Text = "Apagar Cliente";
            this.buttonApagarCliente.UseVisualStyleBackColor = true;
            this.buttonApagarCliente.Click += new System.EventHandler(this.buttonApagarCliente_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(318, 33);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(173, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rua";
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(318, 76);
            this.textBoxRua.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(173, 20);
            this.textBoxRua.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(318, 115);
            this.textBoxCidade.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(173, 20);
            this.textBoxCidade.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CodPostal";
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(318, 158);
            this.textBoxCodPostal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(173, 20);
            this.textBoxCodPostal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pais";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(318, 197);
            this.textBoxPais.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(173, 20);
            this.textBoxPais.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telemovel";
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(318, 236);
            this.textBoxTelemovel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(173, 20);
            this.textBoxTelemovel.TabIndex = 15;
            // 
            // textBoxTotalGasto
            // 
            this.textBoxTotalGasto.Location = new System.Drawing.Point(318, 306);
            this.textBoxTotalGasto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalGasto.Name = "textBoxTotalGasto";
            this.textBoxTotalGasto.Size = new System.Drawing.Size(173, 20);
            this.textBoxTotalGasto.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Num Contribuinte";
            // 
            // textBoxNumContribuinte
            // 
            this.textBoxNumContribuinte.Location = new System.Drawing.Point(318, 272);
            this.textBoxNumContribuinte.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumContribuinte.Name = "textBoxNumContribuinte";
            this.textBoxNumContribuinte.Size = new System.Drawing.Size(173, 20);
            this.textBoxNumContribuinte.TabIndex = 19;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(251, 358);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(106, 42);
            this.buttonDone.TabIndex = 21;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Visible = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(376, 358);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(106, 42);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Visible = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Gasto";
            // 
            // FormularioGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 473);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNumContribuinte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTotalGasto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTelemovel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCodPostal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonApagarCliente);
            this.Controls.Add(this.buttonEditarCliente);
            this.Controls.Add(this.buttonAdicionarCliente);
            this.Controls.Add(this.listBoxClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioGestaoClientes";
            this.Text = "Gestão de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioGestaoClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormularioGestaoClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.Button buttonEditarCliente;
        private System.Windows.Forms.Button buttonApagarCliente;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelemovel;
        private System.Windows.Forms.TextBox textBoxTotalGasto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumContribuinte;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label7;
    }
}

