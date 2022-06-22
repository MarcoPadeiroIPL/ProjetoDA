using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddCategoria : Form
    {
        public string nome { get; set; }
        public bool ativo { get; set; }

        private bool consultar;

        public FormAddCategoria(string nome = null, bool ativo = true, bool consultar = false)
        {
            InitializeComponent();
            this.nome = nome;
            this.ativo = ativo;
            this.consultar = consultar;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!consultar)
            {
                //validações 
                if (String.IsNullOrEmpty(textBoxNome.Text.Trim()))
                {
                    MessageBox.Show("Tem de preencher todos os campos!");
                    return;
                }

                this.nome = textBoxNome.Text.Trim();
                this.ativo = radioButtonSim.Checked;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Categoria inserido com sucesso!");
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddCategoria_Load(object sender, EventArgs e)
        {
            if (consultar)
            {
                textBoxNome.Enabled = false;
                radioButtonSim.Enabled = false;
                radioButtonNao.Enabled = false;

            }
            if (this.nome != null)
            {
                textBoxNome.Text = this.nome;
            }
            radioButtonSim.Checked = this.ativo;
            radioButtonNao.Checked = !this.ativo;
        }
    }
}
