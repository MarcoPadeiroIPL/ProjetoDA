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
            this.listBoxPedidosProgresso = new System.Windows.Forms.ListBox();
            this.listBoxPedidosCompletos = new System.Windows.Forms.ListBox();
            this.buttonNovoPedido = new System.Windows.Forms.Button();
            this.buttonAdicionarPagamento = new System.Windows.Forms.Button();
            this.buttonFinalizarPedido = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonVerMaisDetalhes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPedidosProgresso
            // 
            this.listBoxPedidosProgresso.FormattingEnabled = true;
            this.listBoxPedidosProgresso.Location = new System.Drawing.Point(146, 20);
            this.listBoxPedidosProgresso.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPedidosProgresso.Name = "listBoxPedidosProgresso";
            this.listBoxPedidosProgresso.Size = new System.Drawing.Size(162, 238);
            this.listBoxPedidosProgresso.TabIndex = 0;
            // 
            // listBoxPedidosCompletos
            // 
            this.listBoxPedidosCompletos.FormattingEnabled = true;
            this.listBoxPedidosCompletos.Location = new System.Drawing.Point(350, 20);
            this.listBoxPedidosCompletos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPedidosCompletos.Name = "listBoxPedidosCompletos";
            this.listBoxPedidosCompletos.Size = new System.Drawing.Size(162, 238);
            this.listBoxPedidosCompletos.TabIndex = 1;
            // 
            // buttonNovoPedido
            // 
            this.buttonNovoPedido.Location = new System.Drawing.Point(9, 139);
            this.buttonNovoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovoPedido.Name = "buttonNovoPedido";
            this.buttonNovoPedido.Size = new System.Drawing.Size(122, 19);
            this.buttonNovoPedido.TabIndex = 2;
            this.buttonNovoPedido.Text = "Novo Pedido";
            this.buttonNovoPedido.UseVisualStyleBackColor = true;
            this.buttonNovoPedido.Click += new System.EventHandler(this.buttonNovoPedido_Click);
            // 
            // buttonAdicionarPagamento
            // 
            this.buttonAdicionarPagamento.Location = new System.Drawing.Point(157, 265);
            this.buttonAdicionarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarPagamento.Name = "buttonAdicionarPagamento";
            this.buttonAdicionarPagamento.Size = new System.Drawing.Size(138, 37);
            this.buttonAdicionarPagamento.TabIndex = 3;
            this.buttonAdicionarPagamento.Text = "Adicionar Metodo Pagamento";
            this.buttonAdicionarPagamento.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizarPedido
            // 
            this.buttonFinalizarPedido.Location = new System.Drawing.Point(157, 306);
            this.buttonFinalizarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFinalizarPedido.Name = "buttonFinalizarPedido";
            this.buttonFinalizarPedido.Size = new System.Drawing.Size(138, 37);
            this.buttonFinalizarPedido.TabIndex = 4;
            this.buttonFinalizarPedido.Text = "Finalizar Pedido";
            this.buttonFinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(364, 306);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(138, 37);
            this.buttonExportar.TabIndex = 6;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = true;
            // 
            // buttonVerMaisDetalhes
            // 
            this.buttonVerMaisDetalhes.Location = new System.Drawing.Point(364, 265);
            this.buttonVerMaisDetalhes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerMaisDetalhes.Name = "buttonVerMaisDetalhes";
            this.buttonVerMaisDetalhes.Size = new System.Drawing.Size(138, 37);
            this.buttonVerMaisDetalhes.TabIndex = 5;
            this.buttonVerMaisDetalhes.Text = "Ver mais detalhes";
            this.buttonVerMaisDetalhes.UseVisualStyleBackColor = true;
            // 
            // FormularioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonVerMaisDetalhes);
            this.Controls.Add(this.buttonFinalizarPedido);
            this.Controls.Add(this.buttonAdicionarPagamento);
            this.Controls.Add(this.buttonNovoPedido);
            this.Controls.Add(this.listBoxPedidosCompletos);
            this.Controls.Add(this.listBoxPedidosProgresso);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioPedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPedidosProgresso;
        private System.Windows.Forms.ListBox listBoxPedidosCompletos;
        private System.Windows.Forms.Button buttonNovoPedido;
        private System.Windows.Forms.Button buttonAdicionarPagamento;
        private System.Windows.Forms.Button buttonFinalizarPedido;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonVerMaisDetalhes;
    }
}