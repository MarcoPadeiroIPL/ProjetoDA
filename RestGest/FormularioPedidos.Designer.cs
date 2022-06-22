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
            this.buttonGerirPedidoProcessamento = new System.Windows.Forms.Button();
            this.buttonCompletar = new System.Windows.Forms.Button();
            this.listBoxPedidosEmProcessamento = new System.Windows.Forms.ListBox();
            this.groupBoxItensMenu = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarPagamentos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAvancarRecebidos = new System.Windows.Forms.Button();
            this.buttonGerirPedido = new System.Windows.Forms.Button();
            this.listBoxPedidosRecebidos = new System.Windows.Forms.ListBox();
            this.buttonRemoverPedidosRecebidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValorPago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValorPorPagar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxItensMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.buttonCriarNovoPedido.Click += new System.EventHandler(this.buttonCriarNovoPedido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConsultar);
            this.groupBox1.Controls.Add(this.listBoxPedidosCompletos);
            this.groupBox1.Controls.Add(this.buttonExportar);
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
            this.listBoxPedidosCompletos.SelectedIndexChanged += new System.EventHandler(this.listBoxPedidosCompletos_SelectedIndexChanged);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(159, 367);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(80, 36);
            this.buttonExportar.TabIndex = 6;
            this.buttonExportar.Text = "Exportar (.txt)";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // buttonGerirPedidoProcessamento
            // 
            this.buttonGerirPedidoProcessamento.Location = new System.Drawing.Point(16, 367);
            this.buttonGerirPedidoProcessamento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGerirPedidoProcessamento.Name = "buttonGerirPedidoProcessamento";
            this.buttonGerirPedidoProcessamento.Size = new System.Drawing.Size(80, 36);
            this.buttonGerirPedidoProcessamento.TabIndex = 9;
            this.buttonGerirPedidoProcessamento.Text = "Gerir Pedido";
            this.buttonGerirPedidoProcessamento.UseVisualStyleBackColor = true;
            this.buttonGerirPedidoProcessamento.Click += new System.EventHandler(this.buttonGerirPedidoProcessamento_Click);
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
            this.buttonCompletar.Click += new System.EventHandler(this.buttonCompletar_Click);
            // 
            // listBoxPedidosEmProcessamento
            // 
            this.listBoxPedidosEmProcessamento.FormattingEnabled = true;
            this.listBoxPedidosEmProcessamento.Location = new System.Drawing.Point(16, 25);
            this.listBoxPedidosEmProcessamento.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPedidosEmProcessamento.Name = "listBoxPedidosEmProcessamento";
            this.listBoxPedidosEmProcessamento.Size = new System.Drawing.Size(248, 329);
            this.listBoxPedidosEmProcessamento.TabIndex = 0;
            this.listBoxPedidosEmProcessamento.SelectedIndexChanged += new System.EventHandler(this.listBoxPedidosEmProcessamento_SelectedIndexChanged);
            // 
            // groupBoxItensMenu
            // 
            this.groupBoxItensMenu.Controls.Add(this.buttonAdicionarPagamentos);
            this.groupBoxItensMenu.Controls.Add(this.listBoxPedidosEmProcessamento);
            this.groupBoxItensMenu.Controls.Add(this.buttonCompletar);
            this.groupBoxItensMenu.Controls.Add(this.buttonGerirPedidoProcessamento);
            this.groupBoxItensMenu.Location = new System.Drawing.Point(450, 12);
            this.groupBoxItensMenu.Name = "groupBoxItensMenu";
            this.groupBoxItensMenu.Size = new System.Drawing.Size(284, 418);
            this.groupBoxItensMenu.TabIndex = 14;
            this.groupBoxItensMenu.TabStop = false;
            this.groupBoxItensMenu.Text = "Pedidos em processamento";
            // 
            // buttonAdicionarPagamentos
            // 
            this.buttonAdicionarPagamentos.Location = new System.Drawing.Point(184, 367);
            this.buttonAdicionarPagamentos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarPagamentos.Name = "buttonAdicionarPagamentos";
            this.buttonAdicionarPagamentos.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarPagamentos.TabIndex = 10;
            this.buttonAdicionarPagamentos.Text = "Adicionar Pagamento";
            this.buttonAdicionarPagamentos.UseVisualStyleBackColor = true;
            this.buttonAdicionarPagamentos.Click += new System.EventHandler(this.buttonAdicionarPagamentos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAvancarRecebidos);
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
            // buttonAvancarRecebidos
            // 
            this.buttonAvancarRecebidos.Location = new System.Drawing.Point(100, 367);
            this.buttonAvancarRecebidos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAvancarRecebidos.Name = "buttonAvancarRecebidos";
            this.buttonAvancarRecebidos.Size = new System.Drawing.Size(80, 36);
            this.buttonAvancarRecebidos.TabIndex = 11;
            this.buttonAvancarRecebidos.Text = "Avançar";
            this.buttonAvancarRecebidos.UseVisualStyleBackColor = true;
            this.buttonAvancarRecebidos.Click += new System.EventHandler(this.buttonAvancarRecebidos_Click);
            // 
            // buttonGerirPedido
            // 
            this.buttonGerirPedido.Location = new System.Drawing.Point(16, 367);
            this.buttonGerirPedido.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGerirPedido.Name = "buttonGerirPedido";
            this.buttonGerirPedido.Size = new System.Drawing.Size(80, 36);
            this.buttonGerirPedido.TabIndex = 10;
            this.buttonGerirPedido.Text = "Gerir Pedido";
            this.buttonGerirPedido.UseVisualStyleBackColor = true;
            this.buttonGerirPedido.Click += new System.EventHandler(this.buttonGerirPedido_Click);
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
            this.buttonRemoverPedidosRecebidos.Location = new System.Drawing.Point(184, 367);
            this.buttonRemoverPedidosRecebidos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverPedidosRecebidos.Name = "buttonRemoverPedidosRecebidos";
            this.buttonRemoverPedidosRecebidos.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverPedidosRecebidos.TabIndex = 9;
            this.buttonRemoverPedidosRecebidos.Text = "Remover";
            this.buttonRemoverPedidosRecebidos.UseVisualStyleBackColor = true;
            this.buttonRemoverPedidosRecebidos.Click += new System.EventHandler(this.buttonRemoverPedidosRecebidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valor Total:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(83, 25);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(13, 13);
            this.labelValorTotal.TabIndex = 17;
            this.labelValorTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Valor Pago:";
            // 
            // labelValorPago
            // 
            this.labelValorPago.AutoSize = true;
            this.labelValorPago.Location = new System.Drawing.Point(83, 51);
            this.labelValorPago.Name = "labelValorPago";
            this.labelValorPago.Size = new System.Drawing.Size(13, 13);
            this.labelValorPago.TabIndex = 19;
            this.labelValorPago.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Valor a Pagar:";
            // 
            // labelValorPorPagar
            // 
            this.labelValorPorPagar.AutoSize = true;
            this.labelValorPorPagar.Location = new System.Drawing.Point(83, 81);
            this.labelValorPorPagar.Name = "labelValorPorPagar";
            this.labelValorPorPagar.Size = new System.Drawing.Size(13, 13);
            this.labelValorPorPagar.TabIndex = 21;
            this.labelValorPorPagar.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelValorPorPagar);
            this.groupBox3.Controls.Add(this.labelValorTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.labelValorPago);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 103);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagamentos";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(55, 367);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(80, 36);
            this.buttonConsultar.TabIndex = 7;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // FormularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxItensMenu);
            this.Controls.Add(this.buttonCriarNovoPedido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1049, 475);
            this.MinimumSize = new System.Drawing.Size(1049, 475);
            this.Name = "FormularioPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FormularioPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxItensMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCriarNovoPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPedidosCompletos;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonGerirPedidoProcessamento;
        private System.Windows.Forms.Button buttonCompletar;
        private System.Windows.Forms.ListBox listBoxPedidosEmProcessamento;
        private System.Windows.Forms.GroupBox groupBoxItensMenu;
        private System.Windows.Forms.Button buttonAdicionarPagamentos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGerirPedido;
        private System.Windows.Forms.ListBox listBoxPedidosRecebidos;
        private System.Windows.Forms.Button buttonRemoverPedidosRecebidos;
        private System.Windows.Forms.Button buttonAvancarRecebidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValorPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValorPorPagar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonConsultar;
    }
}