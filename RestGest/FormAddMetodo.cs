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
    public partial class FormAddMetodo : Form
    {
        public string metodoPagamento { get; set; }
        public bool ativo { get; set; }
        private bool consultar;
        public FormAddMetodo(string metodoPagamento = null, bool ativo = true, bool consultar = false)
        {
            InitializeComponent();
            this.metodoPagamento = metodoPagamento;
            this.ativo = ativo;
            this.consultar = consultar;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(!consultar)
            {
                //validações
                if (String.IsNullOrEmpty(textBoxMetodoPagamento.Text.Trim()))
                {
                    MessageBox.Show("Tem de preencher todos os campos!");
                    return;
                }

                this.metodoPagamento = textBoxMetodoPagamento.Text.Trim();
                this.ativo = radioButtonSim.Checked;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Metodo Pagamento inserido com sucesso!");
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddMetodo_Load(object sender, EventArgs e)
        {
            if (consultar)
            {
                radioButtonNao.Enabled = false;
                radioButtonSim.Enabled = false;
                textBoxMetodoPagamento.Enabled = false;
            }
            if (this.metodoPagamento != null)
            {
                textBoxMetodoPagamento.Text = this.metodoPagamento;
            }
            radioButtonSim.Checked = this.ativo;
            radioButtonNao.Checked = !this.ativo;
        }
    }
}
