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
            this.listBoxMenus = new System.Windows.Forms.ListBox();
            this.buttonAdicionarMenu = new System.Windows.Forms.Button();
            this.buttonEditarMenu = new System.Windows.Forms.Button();
            this.buttonRemoverMenu = new System.Windows.Forms.Button();
            this.buttonConsultarMenu = new System.Windows.Forms.Button();
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxMenus
            // 
            this.listBoxMenus.FormattingEnabled = true;
            this.listBoxMenus.Location = new System.Drawing.Point(237, 22);
            this.listBoxMenus.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMenus.Name = "listBoxMenus";
            this.listBoxMenus.Size = new System.Drawing.Size(182, 251);
            this.listBoxMenus.TabIndex = 0;
            // 
            // buttonAdicionarMenu
            // 
            this.buttonAdicionarMenu.Location = new System.Drawing.Point(267, 278);
            this.buttonAdicionarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionarMenu.Name = "buttonAdicionarMenu";
            this.buttonAdicionarMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonAdicionarMenu.TabIndex = 2;
            this.buttonAdicionarMenu.Text = "Adicionar Menu";
            this.buttonAdicionarMenu.UseVisualStyleBackColor = true;
            // 
            // buttonEditarMenu
            // 
            this.buttonEditarMenu.Location = new System.Drawing.Point(267, 301);
            this.buttonEditarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditarMenu.Name = "buttonEditarMenu";
            this.buttonEditarMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonEditarMenu.TabIndex = 3;
            this.buttonEditarMenu.Text = "Editar Menu";
            this.buttonEditarMenu.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverMenu
            // 
            this.buttonRemoverMenu.Location = new System.Drawing.Point(267, 325);
            this.buttonRemoverMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoverMenu.Name = "buttonRemoverMenu";
            this.buttonRemoverMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonRemoverMenu.TabIndex = 4;
            this.buttonRemoverMenu.Text = "Remover Menu";
            this.buttonRemoverMenu.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarMenu
            // 
            this.buttonConsultarMenu.Location = new System.Drawing.Point(267, 348);
            this.buttonConsultarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultarMenu.Name = "buttonConsultarMenu";
            this.buttonConsultarMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonConsultarMenu.TabIndex = 5;
            this.buttonConsultarMenu.Text = "Consultar Menu";
            this.buttonConsultarMenu.UseVisualStyleBackColor = true;
            // 
            // listBoxRestaurantes
            // 
            this.listBoxRestaurantes.FormattingEnabled = true;
            this.listBoxRestaurantes.Location = new System.Drawing.Point(11, 22);
            this.listBoxRestaurantes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRestaurantes.Name = "listBoxRestaurantes";
            this.listBoxRestaurantes.Size = new System.Drawing.Size(182, 251);
            this.listBoxRestaurantes.TabIndex = 6;
            this.listBoxRestaurantes.SelectedIndexChanged += new System.EventHandler(this.listBoxRestaurantes_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(502, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(502, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(502, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(502, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 20);
            this.textBox4.TabIndex = 11;
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 383);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxRestaurantes);
            this.Controls.Add(this.buttonConsultarMenu);
            this.Controls.Add(this.buttonRemoverMenu);
            this.Controls.Add(this.buttonEditarMenu);
            this.Controls.Add(this.buttonAdicionarMenu);
            this.Controls.Add(this.listBoxMenus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormularioMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenus;
        private System.Windows.Forms.Button buttonAdicionarMenu;
        private System.Windows.Forms.Button buttonEditarMenu;
        private System.Windows.Forms.Button buttonRemoverMenu;
        private System.Windows.Forms.Button buttonConsultarMenu;
        private System.Windows.Forms.ListBox listBoxRestaurantes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}