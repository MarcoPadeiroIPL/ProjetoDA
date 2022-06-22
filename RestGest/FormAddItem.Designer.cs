namespace WindowsFormsApp1
{
    partial class FormAddItem
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
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPreço = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxIngredientes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdicionarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Preço";
            // 
            // textBoxPreço
            // 
            this.textBoxPreço.Location = new System.Drawing.Point(121, 147);
            this.textBoxPreço.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPreço.Name = "textBoxPreço";
            this.textBoxPreço.Size = new System.Drawing.Size(173, 20);
            this.textBoxPreço.TabIndex = 48;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(47, 107);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 13);
            this.label.TabIndex = 47;
            this.label.Text = "Ingredientes";
            // 
            // textBoxIngredientes
            // 
            this.textBoxIngredientes.Location = new System.Drawing.Point(121, 104);
            this.textBoxIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIngredientes.Name = "textBoxIngredientes";
            this.textBoxIngredientes.Size = new System.Drawing.Size(173, 20);
            this.textBoxIngredientes.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 68);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Categoria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(121, 22);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(173, 20);
            this.textBoxNome.TabIndex = 42;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(280, 218);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 41;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(121, 218);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 40;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(121, 65);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(173, 21);
            this.comboBoxCategoria.TabIndex = 56;
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(169, 181);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNao.TabIndex = 59;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Nao";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(121, 181);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSim.TabIndex = 58;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Ativo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(328, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdicionarImagem
            // 
            this.buttonAdicionarImagem.Location = new System.Drawing.Point(328, 126);
            this.buttonAdicionarImagem.Name = "buttonAdicionarImagem";
            this.buttonAdicionarImagem.Size = new System.Drawing.Size(100, 23);
            this.buttonAdicionarImagem.TabIndex = 61;
            this.buttonAdicionarImagem.Text = "Adicionar Imagem";
            this.buttonAdicionarImagem.UseVisualStyleBackColor = true;
            this.buttonAdicionarImagem.Click += new System.EventHandler(this.buttonAdicionarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 264);
            this.Controls.Add(this.buttonAdicionarImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonNao);
            this.Controls.Add(this.radioButtonSim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPreço);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxIngredientes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 303);
            this.MinimumSize = new System.Drawing.Size(461, 303);
            this.Name = "FormAddItem";
            this.Text = "FormAddItem";
            this.Load += new System.EventHandler(this.FormAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPreço;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxIngredientes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdicionarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}