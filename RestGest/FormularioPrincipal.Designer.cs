namespace WindowsFormsApp1
{
    partial class FormularioPrincipal
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
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonGlobalRestaurantes = new System.Windows.Forms.Button();
            this.buttonIndividualRestaurantes = new System.Windows.Forms.Button();
            this.buttonMenus = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(44, 34);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(122, 82);
            this.buttonClientes.TabIndex = 0;
            this.buttonClientes.Text = "Gestão Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonGlobalRestaurantes
            // 
            this.buttonGlobalRestaurantes.Location = new System.Drawing.Point(185, 34);
            this.buttonGlobalRestaurantes.Name = "buttonGlobalRestaurantes";
            this.buttonGlobalRestaurantes.Size = new System.Drawing.Size(122, 82);
            this.buttonGlobalRestaurantes.TabIndex = 1;
            this.buttonGlobalRestaurantes.Text = "Gestão global de restaurantes";
            this.buttonGlobalRestaurantes.UseVisualStyleBackColor = true;
            this.buttonGlobalRestaurantes.Click += new System.EventHandler(this.buttonGlobalRestaurantes_Click);
            // 
            // buttonIndividualRestaurantes
            // 
            this.buttonIndividualRestaurantes.Location = new System.Drawing.Point(324, 34);
            this.buttonIndividualRestaurantes.Name = "buttonIndividualRestaurantes";
            this.buttonIndividualRestaurantes.Size = new System.Drawing.Size(122, 82);
            this.buttonIndividualRestaurantes.TabIndex = 2;
            this.buttonIndividualRestaurantes.Text = "Gestão individual de restaurantes";
            this.buttonIndividualRestaurantes.UseVisualStyleBackColor = true;
            this.buttonIndividualRestaurantes.Click += new System.EventHandler(this.buttonIndividualRestaurantes_Click);
            // 
            // buttonMenus
            // 
            this.buttonMenus.Location = new System.Drawing.Point(116, 140);
            this.buttonMenus.Name = "buttonMenus";
            this.buttonMenus.Size = new System.Drawing.Size(122, 82);
            this.buttonMenus.TabIndex = 3;
            this.buttonMenus.Text = "Gestão de menus";
            this.buttonMenus.UseVisualStyleBackColor = true;
            this.buttonMenus.Click += new System.EventHandler(this.buttonMenus_Click);
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Location = new System.Drawing.Point(255, 140);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(122, 82);
            this.buttonPedidos.TabIndex = 4;
            this.buttonPedidos.Text = "Gestão de pedidos";
            this.buttonPedidos.UseVisualStyleBackColor = true;
            this.buttonPedidos.Click += new System.EventHandler(this.buttonPedidos_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 260);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.buttonMenus);
            this.Controls.Add(this.buttonIndividualRestaurantes);
            this.Controls.Add(this.buttonGlobalRestaurantes);
            this.Controls.Add(this.buttonClientes);
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonGlobalRestaurantes;
        private System.Windows.Forms.Button buttonIndividualRestaurantes;
        private System.Windows.Forms.Button buttonMenus;
        private System.Windows.Forms.Button buttonPedidos;
    }
}