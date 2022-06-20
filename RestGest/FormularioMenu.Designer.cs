namespace WindowsFormsApp1
{
    partial class FormularioMenu
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
            this.groupBoxItensMenu = new System.Windows.Forms.GroupBox();
            this.buttonPesquisarRestaurantes = new System.Windows.Forms.Button();
            this.textBoxPesquisarRestaurantes = new System.Windows.Forms.TextBox();
            this.listBoxMenus = new System.Windows.Forms.ListBox();
            this.buttonAdicionarRestaurante = new System.Windows.Forms.Button();
            this.buttonEditarRestaurante = new System.Windows.Forms.Button();
            this.buttonRemoverRestaurante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxItensMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxItensMenu
            // 
            this.groupBoxItensMenu.Controls.Add(this.buttonPesquisarRestaurantes);
            this.groupBoxItensMenu.Controls.Add(this.textBoxPesquisarRestaurantes);
            this.groupBoxItensMenu.Controls.Add(this.listBoxMenus);
            this.groupBoxItensMenu.Controls.Add(this.buttonAdicionarRestaurante);
            this.groupBoxItensMenu.Controls.Add(this.buttonEditarRestaurante);
            this.groupBoxItensMenu.Controls.Add(this.buttonRemoverRestaurante);
            this.groupBoxItensMenu.Location = new System.Drawing.Point(232, 12);
            this.groupBoxItensMenu.Name = "groupBoxItensMenu";
            this.groupBoxItensMenu.Size = new System.Drawing.Size(670, 418);
            this.groupBoxItensMenu.TabIndex = 13;
            this.groupBoxItensMenu.TabStop = false;
            this.groupBoxItensMenu.Text = "Itens Menu Global";
            // 
            // buttonPesquisarRestaurantes
            // 
            this.buttonPesquisarRestaurantes.Location = new System.Drawing.Point(226, 42);
            this.buttonPesquisarRestaurantes.Name = "buttonPesquisarRestaurantes";
            this.buttonPesquisarRestaurantes.Size = new System.Drawing.Size(38, 23);
            this.buttonPesquisarRestaurantes.TabIndex = 13;
            this.buttonPesquisarRestaurantes.Text = "Pesquisar";
            this.buttonPesquisarRestaurantes.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisarRestaurantes
            // 
            this.textBoxPesquisarRestaurantes.Location = new System.Drawing.Point(16, 42);
            this.textBoxPesquisarRestaurantes.Name = "textBoxPesquisarRestaurantes";
            this.textBoxPesquisarRestaurantes.Size = new System.Drawing.Size(204, 20);
            this.textBoxPesquisarRestaurantes.TabIndex = 13;
            // 
            // listBoxMenus
            // 
            this.listBoxMenus.FormattingEnabled = true;
            this.listBoxMenus.Location = new System.Drawing.Point(16, 90);
            this.listBoxMenus.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMenus.Name = "listBoxMenus";
            this.listBoxMenus.Size = new System.Drawing.Size(248, 264);
            this.listBoxMenus.TabIndex = 0;
            // 
            // buttonAdicionarRestaurante
            // 
            this.buttonAdicionarRestaurante.Location = new System.Drawing.Point(16, 367);
            this.buttonAdicionarRestaurante.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarRestaurante.Name = "buttonAdicionarRestaurante";
            this.buttonAdicionarRestaurante.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarRestaurante.TabIndex = 3;
            this.buttonAdicionarRestaurante.Text = "Adicionar";
            this.buttonAdicionarRestaurante.UseVisualStyleBackColor = true;
            // 
            // buttonEditarRestaurante
            // 
            this.buttonEditarRestaurante.Location = new System.Drawing.Point(184, 367);
            this.buttonEditarRestaurante.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarRestaurante.Name = "buttonEditarRestaurante";
            this.buttonEditarRestaurante.Size = new System.Drawing.Size(80, 36);
            this.buttonEditarRestaurante.TabIndex = 6;
            this.buttonEditarRestaurante.Text = "Editar";
            this.buttonEditarRestaurante.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverRestaurante
            // 
            this.buttonRemoverRestaurante.Location = new System.Drawing.Point(100, 367);
            this.buttonRemoverRestaurante.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverRestaurante.Name = "buttonRemoverRestaurante";
            this.buttonRemoverRestaurante.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverRestaurante.TabIndex = 9;
            this.buttonRemoverRestaurante.Text = "Remover";
            this.buttonRemoverRestaurante.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 418);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 25);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 342);
            this.listBox1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 371);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Adicionar categorias";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxItensMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormularioMenu_Load);
            this.groupBoxItensMenu.ResumeLayout(false);
            this.groupBoxItensMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxItensMenu;
        private System.Windows.Forms.Button buttonPesquisarRestaurantes;
        private System.Windows.Forms.TextBox textBoxPesquisarRestaurantes;
        private System.Windows.Forms.ListBox listBoxMenus;
        private System.Windows.Forms.Button buttonAdicionarRestaurante;
        private System.Windows.Forms.Button buttonEditarRestaurante;
        private System.Windows.Forms.Button buttonRemoverRestaurante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
    }
}