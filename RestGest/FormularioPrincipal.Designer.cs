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
            this.SuspendLayout();
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(33, 81);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(122, 82);
            this.buttonClientes.TabIndex = 0;
            this.buttonClientes.Text = "Gestão Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonGlobalRestaurantes
            // 
            this.buttonGlobalRestaurantes.Location = new System.Drawing.Point(185, 81);
            this.buttonGlobalRestaurantes.Name = "buttonGlobalRestaurantes";
            this.buttonGlobalRestaurantes.Size = new System.Drawing.Size(122, 82);
            this.buttonGlobalRestaurantes.TabIndex = 1;
            this.buttonGlobalRestaurantes.Text = "Gestão global de restaurantes";
            this.buttonGlobalRestaurantes.UseVisualStyleBackColor = true;
            this.buttonGlobalRestaurantes.Click += new System.EventHandler(this.buttonGlobalRestaurantes_Click);
            // 
            // buttonIndividualRestaurantes
            // 
            this.buttonIndividualRestaurantes.Location = new System.Drawing.Point(335, 81);
            this.buttonIndividualRestaurantes.Name = "buttonIndividualRestaurantes";
            this.buttonIndividualRestaurantes.Size = new System.Drawing.Size(122, 82);
            this.buttonIndividualRestaurantes.TabIndex = 2;
            this.buttonIndividualRestaurantes.Text = "Gestão individual de restaurantes";
            this.buttonIndividualRestaurantes.UseVisualStyleBackColor = true;
            this.buttonIndividualRestaurantes.Click += new System.EventHandler(this.buttonIndividualRestaurantes_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 256);
            this.Controls.Add(this.buttonIndividualRestaurantes);
            this.Controls.Add(this.buttonGlobalRestaurantes);
            this.Controls.Add(this.buttonClientes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 295);
            this.MinimumSize = new System.Drawing.Size(530, 295);
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonGlobalRestaurantes;
        private System.Windows.Forms.Button buttonIndividualRestaurantes;
    }
}