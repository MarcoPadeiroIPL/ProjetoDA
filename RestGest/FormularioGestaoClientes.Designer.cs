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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonAdicionarClientes = new System.Windows.Forms.Button();
            this.buttonEditarClientes = new System.Windows.Forms.Button();
            this.buttonRemoverClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTelemovel = new System.Windows.Forms.Label();
            this.labelNumContribuinte = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelTotalGasto = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxClientes);
            this.groupBox1.Controls.Add(this.buttonAdicionarClientes);
            this.groupBox1.Controls.Add(this.buttonEditarClientes);
            this.groupBox1.Controls.Add(this.buttonRemoverClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 418);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(16, 25);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(248, 329);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // buttonAdicionarClientes
            // 
            this.buttonAdicionarClientes.Location = new System.Drawing.Point(16, 367);
            this.buttonAdicionarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarClientes.Name = "buttonAdicionarClientes";
            this.buttonAdicionarClientes.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarClientes.TabIndex = 3;
            this.buttonAdicionarClientes.Text = "Adicionar";
            this.buttonAdicionarClientes.UseVisualStyleBackColor = true;
            this.buttonAdicionarClientes.Click += new System.EventHandler(this.buttonAdicionarClientes_Click);
            // 
            // buttonEditarClientes
            // 
            this.buttonEditarClientes.Location = new System.Drawing.Point(184, 367);
            this.buttonEditarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarClientes.Name = "buttonEditarClientes";
            this.buttonEditarClientes.Size = new System.Drawing.Size(80, 36);
            this.buttonEditarClientes.TabIndex = 6;
            this.buttonEditarClientes.Text = "Editar";
            this.buttonEditarClientes.UseVisualStyleBackColor = true;
            this.buttonEditarClientes.Click += new System.EventHandler(this.buttonEditarClientes_Click);
            // 
            // buttonRemoverClientes
            // 
            this.buttonRemoverClientes.Location = new System.Drawing.Point(100, 367);
            this.buttonRemoverClientes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverClientes.Name = "buttonRemoverClientes";
            this.buttonRemoverClientes.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverClientes.TabIndex = 9;
            this.buttonRemoverClientes.Text = "Remover";
            this.buttonRemoverClientes.UseVisualStyleBackColor = true;
            this.buttonRemoverClientes.Click += new System.EventHandler(this.buttonRemoverClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTelemovel);
            this.groupBox2.Controls.Add(this.labelNumContribuinte);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelPais);
            this.groupBox2.Controls.Add(this.labelCodPostal);
            this.groupBox2.Controls.Add(this.labelRua);
            this.groupBox2.Controls.Add(this.labelCidade);
            this.groupBox2.Controls.Add(this.labelTotalGasto);
            this.groupBox2.Controls.Add(this.labelNome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 418);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do cliente";
            // 
            // labelTelemovel
            // 
            this.labelTelemovel.AutoSize = true;
            this.labelTelemovel.Location = new System.Drawing.Point(31, 169);
            this.labelTelemovel.Name = "labelTelemovel";
            this.labelTelemovel.Size = new System.Drawing.Size(0, 13);
            this.labelTelemovel.TabIndex = 15;
            // 
            // labelNumContribuinte
            // 
            this.labelNumContribuinte.AutoSize = true;
            this.labelNumContribuinte.Location = new System.Drawing.Point(198, 169);
            this.labelNumContribuinte.Name = "labelNumContribuinte";
            this.labelNumContribuinte.Size = new System.Drawing.Size(0, 13);
            this.labelNumContribuinte.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nº Contribuinte:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Telemovel:";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(201, 362);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(0, 13);
            this.labelPais.TabIndex = 11;
            // 
            // labelCodPostal
            // 
            this.labelCodPostal.AutoSize = true;
            this.labelCodPostal.Location = new System.Drawing.Point(34, 362);
            this.labelCodPostal.Name = "labelCodPostal";
            this.labelCodPostal.Size = new System.Drawing.Size(0, 13);
            this.labelCodPostal.TabIndex = 10;
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Location = new System.Drawing.Point(34, 267);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(0, 13);
            this.labelRua.TabIndex = 9;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(201, 267);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(0, 13);
            this.labelCidade.TabIndex = 8;
            // 
            // labelTotalGasto
            // 
            this.labelTotalGasto.AutoSize = true;
            this.labelTotalGasto.Location = new System.Drawing.Point(453, 72);
            this.labelTotalGasto.Name = "labelTotalGasto";
            this.labelTotalGasto.Size = new System.Drawing.Size(0, 13);
            this.labelTotalGasto.TabIndex = 7;
            this.labelTotalGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(29, 72);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 13);
            this.labelNome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cod. Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Gasto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // FormularioGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioGestaoClientes";
            this.Text = "Gestão de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioGestaoClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormularioGestaoClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonAdicionarClientes;
        private System.Windows.Forms.Button buttonEditarClientes;
        private System.Windows.Forms.Button buttonRemoverClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelTotalGasto;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTelemovel;
        private System.Windows.Forms.Label labelNumContribuinte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

