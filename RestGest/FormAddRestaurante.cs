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
    public partial class FormAddRestaurante : Form
    {
        public string nome { get; set; }
        public Morada morada { get; set; }

        private bool consultar;

        public FormAddRestaurante(string nome = null, Morada morada = null, bool consultar = false)
        {
            InitializeComponent();
            this.nome = nome;
            this.morada = morada;
            this.consultar = consultar;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!consultar)
            {
                if (String.IsNullOrEmpty(textBoxNome.Text.Trim()) || String.IsNullOrEmpty(textBoxCidade.Text.Trim()) || String.IsNullOrEmpty(textBoxRua.Text.Trim()) || String.IsNullOrEmpty(textBoxPais.Text.Trim()) || String.IsNullOrEmpty(textBoxCodPostal.Text.Trim()))
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
                this.morada = novaMorada;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Restaurante inserido com sucesso!");
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddRestaurante_Load(object sender, EventArgs e)
        {
            if (consultar)
            {
                textBoxNome.Enabled = false;
                textBoxRua.Enabled = false;
                textBoxCidade.Enabled = false;
                textBoxCodPostal.Enabled = false;
                textBoxPais.Enabled = false;
            }
            if(nome != null)
            {
                textBoxNome.Text = nome;
            }
            if(morada != null)
            {
                textBoxRua.Text = morada.Rua;
                textBoxCidade.Text = morada.Cidade;
                textBoxCodPostal.Text = morada.CodPostal;
                textBoxPais.Text = morada.Pais;
            }
        }
    }
}
