namespace WindowsFormsApp1
{
    partial class FormAddRestaurante
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(25, 47);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(190, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(25, 292);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rua:";
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(25, 88);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(190, 20);
            this.textBoxRua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cidade:";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(25, 136);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(190, 20);
            this.textBoxCidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cod.Postal";
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(25, 189);
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(190, 20);
            this.textBoxCodPostal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pais:";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(25, 237);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(190, 20);
            this.textBoxPais.TabIndex = 9;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(129, 292);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormAddRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 343);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodPostal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRua);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormAddRestaurante";
            this.Text = "FormAddRestaurante";
            this.Load += new System.EventHandler(this.FormAddRestaurante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Button buttonCancelar;
    }
}