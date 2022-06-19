namespace WindowsFormsApp1
{
    partial class FormAddCategoria
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(137, 116);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ativo:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 14;
            this.label.Text = "Nome:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(23, 116);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(23, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(190, 20);
            this.textBoxNome.TabIndex = 12;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(23, 82);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 24;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(114, 82);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 25;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Nao";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // FormAddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 160);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormAddCategoria";
            this.Text = "FormAddCategoria";
            this.Load += new System.EventHandler(this.FormAddCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.RadioButton radioButtonNao;
    }
}