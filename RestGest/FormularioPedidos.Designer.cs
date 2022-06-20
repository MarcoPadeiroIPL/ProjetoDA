namespace WindowsFormsApp1
{
    partial class FormularioPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCriarNovoPedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPedidosCompletos = new System.Windows.Forms.ListBox();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonRemoverPedidosCompletos = new System.Windows.Forms.Button();
            this.buttonRemoverPedidosProcessamento = new System.Windows.Forms.Button();
            this.buttonCompletar = new System.Windows.Forms.Button();
            this.listBoxPedidosEmProcessamento = new System.Windows.Forms.ListBox();
            this.groupBoxItensMenu = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGerirPedido = new System.Windows.Forms.Button();
            this.listBoxPedidosRecebidos = new System.Windows.Forms.ListBox();
            this.buttonRemoverPedidosRecebidos = new System.Windows.Forms.Button();
            this.buttonAdicionarPagamentos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxItensMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCriarNovoPedido
            // 
            this.buttonCriarNovoPedido.Location = new System.Drawing.Point(28, 168);
            this.buttonCriarNovoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCriarNovoPedido.Name = "buttonCriarNovoPedido";
            this.buttonCriarNovoPedido.Size = new System.Drawing.Size(111, 90);
            this.buttonCriarNovoPedido.TabIndex = 3;
            this.buttonCriarNovoPedido.Text = "Criar novo pedido";
            this.buttonCriarNovoPedido.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPedidosCompletos);
            this.groupBox1.Controls.Add(this.buttonExportar);
            this.groupBox1.Controls.Add(this.buttonRemoverPedidosCompletos);
            this.groupBox1.Location = new System.Drawing.Point(740, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 418);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos completos";
            // 
            // listBoxPedidosCompletos
            // 
            this.listBoxPedidosCompletos.FormattingEnabled = true;
            this.listBoxPedidosCompletos.Location = new System.Drawing.Point(16, 25);
            this.listBoxPedidosCompletos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPedidosCompletos.Name = "listBoxPedidosCompletos";
            this.listBoxPedidosCompletos.Size = new System.Drawing.Size(248, 329);
            this.listBoxPedidosCompletos.TabIndex = 0;
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(46, 367);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(80, 36);
            this.buttonExportar.TabIndex = 6;
            this.buttonExportar.Text = "Exportar (.txt)";
            this.buttonExportar.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverPedidosCompletos
            // 
            this.buttonRemoverPedidosCompletos.Location = new System.Drawing.Point(159, 367);
            this.buttonRemoverPedidosCompletos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverPedidosCompletos.Name = "buttonRemoverPedidosCompletos";
            this.buttonRemoverPedidosCompletos.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverPedidosCompletos.TabIndex = 9;
            this.buttonRemoverPedidosCompletos.Text = "Remover";
            this.buttonRemoverPedidosCompletos.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverPedidosProcessamento
            // 
            this.buttonRemoverPedidosProcessamento.Location = new System.Drawing.Point(184, 367);
            this.buttonRemoverPedidosProcessamento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverPedidosProcessamento.Name = "buttonRemoverPedidosProcessamento";
            this.buttonRemoverPedidosProcessamento.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverPedidosProcessamento.TabIndex = 9;
            this.buttonRemoverPedidosProcessamento.Text = "Remover";
            this.buttonRemoverPedidosProcessamento.UseVisualStyleBackColor = true;
            this.buttonRemoverPedidosProcessamento.Click += new System.EventHandler(this.buttonRemoverRestaurante_Click);
            // 
            // buttonCompletar
            // 
            this.buttonCompletar.Location = new System.Drawing.Point(100, 367);
            this.buttonCompletar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCompletar.Name = "buttonCompletar";
            this.buttonCompletar.Size = new System.Drawing.Size(80, 36);
            this.buttonCompletar.TabIndex = 6;
            this.buttonCompletar.Text = "Completar";
            this.buttonCompletar.UseVisualStyleBackColor = true;
            // 
            // listBoxPedidosEmProcessamento
            // 
            this.listBoxPedidosEmProcessamento.FormattingEnabled = true;
            this.listBoxPedidosEmProcessamento.Location = new System.Drawing.Point(16, 25);
            this.listBoxPedidosEmProcessamento.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPedidosEmProcessamento.Name = "listBoxPedidosEmProcessamento";
            this.listBoxPedidosEmProcessamento.Size = new System.Drawing.Size(248, 329);
            this.listBoxPedidosEmProcessamento.TabIndex = 0;
            // 
            // groupBoxItensMenu
            // 
            this.groupBoxItensMenu.Controls.Add(this.buttonAdicionarPagamentos);
            this.groupBoxItensMenu.Controls.Add(this.listBoxPedidosEmProcessamento);
            this.groupBoxItensMenu.Controls.Add(this.buttonCompletar);
            this.groupBoxItensMenu.Controls.Add(this.buttonRemoverPedidosProcessamento);
            this.groupBoxItensMenu.Location = new System.Drawing.Point(450, 12);
            this.groupBoxItensMenu.Name = "groupBoxItensMenu";
            this.groupBoxItensMenu.Size = new System.Drawing.Size(284, 418);
            this.groupBoxItensMenu.TabIndex = 14;
            this.groupBoxItensMenu.TabStop = false;
            this.groupBoxItensMenu.Text = "Pedidos em processamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGerirPedido);
            this.groupBox2.Controls.Add(this.listBoxPedidosRecebidos);
            this.groupBox2.Controls.Add(this.buttonRemoverPedidosRecebidos);
            this.groupBox2.Location = new System.Drawing.Point(160, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 418);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedidos recebidos";
            // 
            // buttonGerirPedido
            // 
            this.buttonGerirPedido.Location = new System.Drawing.Point(48, 367);
            this.buttonGerirPedido.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGerirPedido.Name = "buttonGerirPedido";
            this.buttonGerirPedido.Size = new System.Drawing.Size(80, 36);
            this.buttonGerirPedido.TabIndex = 10;
            this.buttonGerirPedido.Text = "Gerir Pedido";
            this.buttonGerirPedido.UseVisualStyleBackColor = true;
            // 
            // listBoxPedidosRecebidos
            // 
            this.listBoxPedidosRecebidos.FormattingEnabled = true;
            this.listBoxPedidosRecebidos.Location = new System.Drawing.Point(16, 25);
            this.listBoxPedidosRecebidos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPedidosRecebidos.Name = "listBoxPedidosRecebidos";
            this.listBoxPedidosRecebidos.Size = new System.Drawing.Size(248, 329);
            this.listBoxPedidosRecebidos.TabIndex = 0;
            // 
            // buttonRemoverPedidosRecebidos
            // 
            this.buttonRemoverPedidosRecebidos.Location = new System.Drawing.Point(156, 367);
            this.buttonRemoverPedidosRecebidos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverPedidosRecebidos.Name = "buttonRemoverPedidosRecebidos";
            this.buttonRemoverPedidosRecebidos.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverPedidosRecebidos.TabIndex = 9;
            this.buttonRemoverPedidosRecebidos.Text = "Remover";
            this.buttonRemoverPedidosRecebidos.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarPagamentos
            // 
            this.buttonAdicionarPagamentos.Location = new System.Drawing.Point(16, 367);
            this.buttonAdicionarPagamentos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarPagamentos.Name = "buttonAdicionarPagamentos";
            this.buttonAdicionarPagamentos.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarPagamentos.TabIndex = 10;
            this.buttonAdicionarPagamentos.Text = "Adicionar Pagamento";
            this.buttonAdicionarPagamentos.UseVisualStyleBackColor = true;
            // 
            // FormularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxItensMenu);
            this.Controls.Add(this.buttonCriarNovoPedido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioPedidos";
            this.Text = "Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxItensMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCriarNovoPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPedidosCompletos;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonRemoverPedidosCompletos;
        private System.Windows.Forms.Button buttonRemoverPedidosProcessamento;
        private System.Windows.Forms.Button buttonCompletar;
        private System.Windows.Forms.ListBox listBoxPedidosEmProcessamento;
        private System.Windows.Forms.GroupBox groupBoxItensMenu;
        private System.Windows.Forms.Button buttonAdicionarPagamentos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGerirPedido;
        private System.Windows.Forms.ListBox listBoxPedidosRecebidos;
        private System.Windows.Forms.Button buttonRemoverPedidosRecebidos;
    }
}