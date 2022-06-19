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
    public partial class FormAddClientes : Form
    {
        public string nome { get; set; }
        public Morada morada { get; set; }
        public string telemovel { get; set; }
        public string numContribuinte { get; set; }
        public FormAddClientes(string nome = null, Morada morada = null, string telemovel = null, string numContribuinte = null)
        {
            InitializeComponent();
            this.nome = nome;
            this.morada = morada;
            this.telemovel = telemovel;
            this.numContribuinte = numContribuinte;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNome.Text.Trim()) || String.IsNullOrEmpty(textBoxCidade.Text.Trim()) || String.IsNullOrEmpty(textBoxRua.Text.Trim()) || String.IsNullOrEmpty(textBoxPais.Text.Trim()) || String.IsNullOrEmpty(textBoxCodPostal.Text.Trim()) || String.IsNullOrEmpty(textBoxTelemovel.Text.Trim()) || String.IsNullOrEmpty(textBoxNumContribuinte.Text.Trim()))
            {
                MessageBox.Show("Tem de preencher todos os campos!");
                return;
            }

            Morada novaMorada = new Morada();
            novaMorada.Cidade = textBoxCidade.Text.Trim();
            novaMorada.Pais = textBoxPais.Text.Trim();
            novaMorada.CodPostal = textBoxCodPostal.Text.Trim();
            novaMorada.Rua = textBoxRua.Text.Trim();

            this.nome = textBoxNome.Text.Trim();
            this.telemovel = textBoxTelemovel.Text.Trim();
            this.numContribuinte = textBoxNumContribuinte.Text.Trim();
            this.morada = novaMorada;
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Cliente inserido com sucesso!");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddClientes_Load(object sender, EventArgs e)
        {
            if (this.nome != null)
            {
                textBoxNome.Text = this.nome;
            }
            if (this.morada != null)
            {
                textBoxRua.Text = this.morada.Rua;
                textBoxCidade.Text = this.morada.Cidade;
                textBoxCodPostal.Text = this.morada.CodPostal;
                textBoxPais.Text = this.morada.Pais;
            }
            if (this.telemovel != null)
            {
                textBoxTelemovel.Text = this.telemovel;
            }
            if (this.numContribuinte != null)
            {
                textBoxNumContribuinte.Text = this.numContribuinte;
            }

        }
    }
}
