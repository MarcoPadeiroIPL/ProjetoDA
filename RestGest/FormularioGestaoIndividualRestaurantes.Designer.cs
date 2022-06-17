namespace WindowsFormsApp1
{
    partial class FormularioGestaoIndividualRestaurantes
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
            this.listBoxTrabalhadores = new System.Windows.Forms.ListBox();
            this.buttonAdicionarTrabalhador = new System.Windows.Forms.Button();
            this.buttonEditarTrabalhador = new System.Windows.Forms.Button();
            this.buttonRemoverTrabalhador = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTrabalhadores
            // 
            this.listBoxTrabalhadores.FormattingEnabled = true;
            this.listBoxTrabalhadores.Location = new System.Drawing.Point(40, 20);
            this.listBoxTrabalhadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTrabalhadores.Name = "listBoxTrabalhadores";
            this.listBoxTrabalhadores.Size = new System.Drawing.Size(183, 290);
            this.listBoxTrabalhadores.TabIndex = 0;
            // 
            // buttonAdicionarTrabalhador
            // 
            this.buttonAdicionarTrabalhador.Location = new System.Drawing.Point(40, 323);
            this.buttonAdicionarTrabalhador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarTrabalhador.Name = "buttonAdicionarTrabalhador";
            this.buttonAdicionarTrabalhador.Size = new System.Drawing.Size(82, 41);
            this.buttonAdicionarTrabalhador.TabIndex = 3;
            this.buttonAdicionarTrabalhador.Text = "Adicionar Trabalhador";
            this.buttonAdicionarTrabalhador.UseVisualStyleBackColor = true;
            // 
            // buttonEditarTrabalhador
            // 
            this.buttonEditarTrabalhador.Location = new System.Drawing.Point(140, 323);
            this.buttonEditarTrabalhador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditarTrabalhador.Name = "buttonEditarTrabalhador";
            this.buttonEditarTrabalhador.Size = new System.Drawing.Size(82, 41);
            this.buttonEditarTrabalhador.TabIndex = 4;
            this.buttonEditarTrabalhador.Text = "Editar Trabalhador";
            this.buttonEditarTrabalhador.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverTrabalhador
            // 
            this.buttonRemoverTrabalhador.Location = new System.Drawing.Point(90, 368);
            this.buttonRemoverTrabalhador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemoverTrabalhador.Name = "buttonRemoverTrabalhador";
            this.buttonRemoverTrabalhador.Size = new System.Drawing.Size(82, 41);
            this.buttonRemoverTrabalhador.TabIndex = 5;
            this.buttonRemoverTrabalhador.Text = "Remover Trabalhador";
            this.buttonRemoverTrabalhador.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(361, 180);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(82, 41);
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.Text = "Ver Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Location = new System.Drawing.Point(361, 243);
            this.buttonPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(82, 41);
            this.buttonPedidos.TabIndex = 9;
            this.buttonPedidos.Text = "Ver pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = true;
            // 
            // FormularioGestaoIndividualRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 453);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonRemoverTrabalhador);
            this.Controls.Add(this.buttonEditarTrabalhador);
            this.Controls.Add(this.buttonAdicionarTrabalhador);
            this.Controls.Add(this.listBoxTrabalhadores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioGestaoIndividualRestaurantes";
            this.Text = "Gestão de Restaurante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTrabalhadores;
        private System.Windows.Forms.Button buttonAdicionarTrabalhador;
        private System.Windows.Forms.Button buttonEditarTrabalhador;
        private System.Windows.Forms.Button buttonRemoverTrabalhador;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonPedidos;
    }
}