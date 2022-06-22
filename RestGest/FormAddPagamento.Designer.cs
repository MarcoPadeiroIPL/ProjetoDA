namespace WindowsFormsApp1
{
    partial class FormAddPagamento
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
            this.label = new System.Windows.Forms.Label();
            this.comboBoxMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelValorPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 13);
            this.label.TabIndex = 30;
            this.label.Text = "Metodo Pagamento:";
            // 
            // comboBoxMetodoPagamento
            // 
            this.comboBoxMetodoPagamento.FormattingEnabled = true;
            this.comboBoxMetodoPagamento.Location = new System.Drawing.Point(12, 25);
            this.comboBoxMetodoPagamento.Name = "comboBoxMetodoPagamento";
            this.comboBoxMetodoPagamento.Size = new System.Drawing.Size(193, 21);
            this.comboBoxMetodoPagamento.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(12, 80);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(193, 20);
            this.textBoxValor.TabIndex = 33;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 139);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 34;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(118, 139);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Valor a Pagar:";
            // 
            // labelValorPagar
            // 
            this.labelValorPagar.AutoSize = true;
            this.labelValorPagar.Location = new System.Drawing.Point(89, 114);
            this.labelValorPagar.Name = "labelValorPagar";
            this.labelValorPagar.Size = new System.Drawing.Size(13, 13);
            this.labelValorPagar.TabIndex = 37;
            this.labelValorPagar.Text = "0";
            // 
            // FormAddPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 179);
            this.Controls.Add(this.labelValorPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMetodoPagamento);
            this.Controls.Add(this.label);
            this.Name = "FormAddPagamento";
            this.Text = "FormAddPagamento";
            this.Load += new System.EventHandler(this.FormAddPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBoxMetodoPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelValorPagar;
    }
}