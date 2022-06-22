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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.listBoxTrabalhadores = new System.Windows.Forms.ListBox();
            this.buttonAdicionarTrabalhadores = new System.Windows.Forms.Button();
            this.buttonEditarTrabalhadores = new System.Windows.Forms.Button();
            this.buttonRemoverTrabalhadores = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxRestaurantes = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxItensMenu = new System.Windows.Forms.ListBox();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.buttonAdicionarItemMenu = new System.Windows.Forms.Button();
            this.buttonRemoverItemMenu = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConsultar);
            this.groupBox1.Controls.Add(this.listBoxTrabalhadores);
            this.groupBox1.Controls.Add(this.buttonAdicionarTrabalhadores);
            this.groupBox1.Controls.Add(this.buttonEditarTrabalhadores);
            this.groupBox1.Controls.Add(this.buttonRemoverTrabalhadores);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 418);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalhadores";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(268, 367);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(80, 36);
            this.buttonConsultar.TabIndex = 14;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // listBoxTrabalhadores
            // 
            this.listBoxTrabalhadores.FormattingEnabled = true;
            this.listBoxTrabalhadores.Location = new System.Drawing.Point(16, 25);
            this.listBoxTrabalhadores.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTrabalhadores.Name = "listBoxTrabalhadores";
            this.listBoxTrabalhadores.Size = new System.Drawing.Size(332, 329);
            this.listBoxTrabalhadores.TabIndex = 0;
            // 
            // buttonAdicionarTrabalhadores
            // 
            this.buttonAdicionarTrabalhadores.Location = new System.Drawing.Point(16, 367);
            this.buttonAdicionarTrabalhadores.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarTrabalhadores.Name = "buttonAdicionarTrabalhadores";
            this.buttonAdicionarTrabalhadores.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarTrabalhadores.TabIndex = 3;
            this.buttonAdicionarTrabalhadores.Text = "Adicionar";
            this.buttonAdicionarTrabalhadores.UseVisualStyleBackColor = true;
            this.buttonAdicionarTrabalhadores.Click += new System.EventHandler(this.buttonAdicionarTrabalhadores_Click);
            // 
            // buttonEditarTrabalhadores
            // 
            this.buttonEditarTrabalhadores.Location = new System.Drawing.Point(184, 367);
            this.buttonEditarTrabalhadores.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarTrabalhadores.Name = "buttonEditarTrabalhadores";
            this.buttonEditarTrabalhadores.Size = new System.Drawing.Size(80, 36);
            this.buttonEditarTrabalhadores.TabIndex = 6;
            this.buttonEditarTrabalhadores.Text = "Editar";
            this.buttonEditarTrabalhadores.UseVisualStyleBackColor = true;
            this.buttonEditarTrabalhadores.Click += new System.EventHandler(this.buttonEditarTrabalhadores_Click);
            // 
            // buttonRemoverTrabalhadores
            // 
            this.buttonRemoverTrabalhadores.Location = new System.Drawing.Point(100, 367);
            this.buttonRemoverTrabalhadores.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverTrabalhadores.Name = "buttonRemoverTrabalhadores";
            this.buttonRemoverTrabalhadores.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverTrabalhadores.TabIndex = 9;
            this.buttonRemoverTrabalhadores.Text = "Remover";
            this.buttonRemoverTrabalhadores.UseVisualStyleBackColor = true;
            this.buttonRemoverTrabalhadores.Click += new System.EventHandler(this.buttonRemoverTrabalhadores_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxRestaurantes);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 53);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restaurante";
            // 
            // comboBoxRestaurantes
            // 
            this.comboBoxRestaurantes.FormattingEnabled = true;
            this.comboBoxRestaurantes.Location = new System.Drawing.Point(16, 19);
            this.comboBoxRestaurantes.Name = "comboBoxRestaurantes";
            this.comboBoxRestaurantes.Size = new System.Drawing.Size(902, 21);
            this.comboBoxRestaurantes.TabIndex = 0;
            this.comboBoxRestaurantes.SelectedIndexChanged += new System.EventHandler(this.comboBoxRestaurantes_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAtualizar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.listBoxItensMenu);
            this.groupBox3.Controls.Add(this.listBoxMenu);
            this.groupBox3.Controls.Add(this.buttonAdicionarItemMenu);
            this.groupBox3.Controls.Add(this.buttonRemoverItemMenu);
            this.groupBox3.Location = new System.Drawing.Point(414, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 252);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(147, 202);
            this.buttonAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(80, 36);
            this.buttonAtualizar.TabIndex = 13;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Itens menu - Restaurante Individual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Itens menu - Restaurante Global";
            // 
            // listBoxItensMenu
            // 
            this.listBoxItensMenu.FormattingEnabled = true;
            this.listBoxItensMenu.Location = new System.Drawing.Point(16, 51);
            this.listBoxItensMenu.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxItensMenu.Name = "listBoxItensMenu";
            this.listBoxItensMenu.Size = new System.Drawing.Size(248, 147);
            this.listBoxItensMenu.TabIndex = 10;
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(268, 51);
            this.listBoxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(248, 147);
            this.listBoxMenu.TabIndex = 0;
            // 
            // buttonAdicionarItemMenu
            // 
            this.buttonAdicionarItemMenu.Location = new System.Drawing.Point(45, 202);
            this.buttonAdicionarItemMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarItemMenu.Name = "buttonAdicionarItemMenu";
            this.buttonAdicionarItemMenu.Size = new System.Drawing.Size(80, 36);
            this.buttonAdicionarItemMenu.TabIndex = 3;
            this.buttonAdicionarItemMenu.Text = "Adicionar";
            this.buttonAdicionarItemMenu.UseVisualStyleBackColor = true;
            this.buttonAdicionarItemMenu.Click += new System.EventHandler(this.buttonAdicionarItemMenu_Click);
            // 
            // buttonRemoverItemMenu
            // 
            this.buttonRemoverItemMenu.Location = new System.Drawing.Point(352, 202);
            this.buttonRemoverItemMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverItemMenu.Name = "buttonRemoverItemMenu";
            this.buttonRemoverItemMenu.Size = new System.Drawing.Size(80, 36);
            this.buttonRemoverItemMenu.TabIndex = 9;
            this.buttonRemoverItemMenu.Text = "Remover";
            this.buttonRemoverItemMenu.UseVisualStyleBackColor = true;
            this.buttonRemoverItemMenu.Click += new System.EventHandler(this.buttonRemoverItemMenu_Click);
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Location = new System.Drawing.Point(471, 376);
            this.buttonPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(170, 97);
            this.buttonPedidos.TabIndex = 14;
            this.buttonPedidos.Text = "Ver Pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = true;
            this.buttonPedidos.Click += new System.EventHandler(this.buttonPedidos_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(718, 376);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(170, 97);
            this.buttonMenu.TabIndex = 15;
            this.buttonMenu.Text = "Gerir Itens de Menu Globais";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // FormularioGestaoIndividualRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 513);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(972, 552);
            this.MinimumSize = new System.Drawing.Size(972, 552);
            this.Name = "FormularioGestaoIndividualRestaurantes";
            this.Text = "Gestão de Restaurante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioGestaoIndividualRestaurantes_FormClosing);
            this.Load += new System.EventHandler(this.FormularioGestaoIndividualRestaurantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxTrabalhadores;
        private System.Windows.Forms.Button buttonAdicionarTrabalhadores;
        private System.Windows.Forms.Button buttonEditarTrabalhadores;
        private System.Windows.Forms.Button buttonRemoverTrabalhadores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxRestaurantes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Button buttonAdicionarItemMenu;
        private System.Windows.Forms.Button buttonRemoverItemMenu;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxItensMenu;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}