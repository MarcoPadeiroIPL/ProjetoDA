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
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.buttonAdicionarMenu = new System.Windows.Forms.Button();
            this.buttonEditarMenu = new System.Windows.Forms.Button();
            this.buttonRemoverMenu = new System.Windows.Forms.Button();
            this.buttonConsultarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMenus
            // 
            this.listBoxMenus.FormattingEnabled = true;
            this.listBoxMenus.Location = new System.Drawing.Point(315, 21);
            this.listBoxMenus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMenus.Name = "listBoxMenus";
            this.listBoxMenus.Size = new System.Drawing.Size(182, 251);
            this.listBoxMenus.TabIndex = 0;
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.Location = new System.Drawing.Point(2, 32);
            this.listBoxCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(182, 251);
            this.listBoxCategorias.TabIndex = 1;
            // 
            // buttonAdicionarMenu
            // 
            this.buttonAdicionarMenu.Location = new System.Drawing.Point(344, 277);
            this.buttonAdicionarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdicionarMenu.Name = "buttonAdicionarMenu";
            this.buttonAdicionarMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonAdicionarMenu.TabIndex = 2;
            this.buttonAdicionarMenu.Text = "Adicionar Menu";
            this.buttonAdicionarMenu.UseVisualStyleBackColor = true;
            // 
            // buttonEditarMenu
            // 
            this.buttonEditarMenu.Location = new System.Drawing.Point(344, 300);
            this.buttonEditarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditarMenu.Name = "buttonEditarMenu";
            this.buttonEditarMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonEditarMenu.TabIndex = 3;
            this.buttonEditarMenu.Text = "Editar Menu";
            this.buttonEditarMenu.UseVisualStyleBackColor = true;
            // 
            // buttonRemoverMenu
            // 
            this.buttonRemoverMenu.Location = new System.Drawing.Point(344, 324);
            this.buttonRemoverMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemoverMenu.Name = "buttonRemoverMenu";
            this.buttonRemoverMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonRemoverMenu.TabIndex = 4;
            this.buttonRemoverMenu.Text = "Remover Menu";
            this.buttonRemoverMenu.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarMenu
            // 
            this.buttonConsultarMenu.Location = new System.Drawing.Point(344, 347);
            this.buttonConsultarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConsultarMenu.Name = "buttonConsultarMenu";
            this.buttonConsultarMenu.Size = new System.Drawing.Size(116, 19);
            this.buttonConsultarMenu.TabIndex = 5;
            this.buttonConsultarMenu.Text = "Consultar Menu";
            this.buttonConsultarMenu.UseVisualStyleBackColor = true;
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 378);
            this.Controls.Add(this.buttonConsultarMenu);
            this.Controls.Add(this.buttonRemoverMenu);
            this.Controls.Add(this.buttonEditarMenu);
            this.Controls.Add(this.buttonAdicionarMenu);
            this.Controls.Add(this.listBoxCategorias);
            this.Controls.Add(this.listBoxMenus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenus;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Button buttonAdicionarMenu;
        private System.Windows.Forms.Button buttonEditarMenu;
        private System.Windows.Forms.Button buttonRemoverMenu;
        private System.Windows.Forms.Button buttonConsultarMenu;
    }
}