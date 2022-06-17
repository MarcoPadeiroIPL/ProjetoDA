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
    public partial class FormularioGestaoClientes : Form
    {
        public bool editar=false;
        public static RestGestContainer restGestContainer;
        public FormularioGestaoClientes()
        {
            InitializeComponent();
            ChangeUI(true);
        }

        private void Limpar()
        {
            textBoxNome.Clear();
            textBoxRua.Clear();
            textBoxCidade.Clear();
            textBoxCodPostal.Clear();
            textBoxPais.Clear();
            textBoxTelemovel.Clear();
            textBoxNumContribuinte.Clear();
            textBoxTotalGasto.Clear();
        }
        private void ChangeUI(bool res)
        {
            Limpar();
            listBoxClientes.Enabled = res;
            buttonApagarCliente.Enabled = res;
            buttonEditarCliente.Enabled = res;
            buttonAdicionarCliente.Enabled = res;

            textBoxNome.Enabled = !res;
            textBoxRua.Enabled = !res;
            textBoxCidade.Enabled = !res;
            textBoxCodPostal.Enabled = !res;
            textBoxPais.Enabled = !res;
            textBoxTelemovel.Enabled = !res;
            textBoxNumContribuinte.Enabled = !res;
            textBoxTotalGasto.Enabled = !res;

            label7.Visible = res;
            textBoxTotalGasto.Visible = res;

            buttonDone.Visible = !res;
            buttonClose.Visible = !res;

        }
        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            editar = false;
            ChangeUI(false);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ChangeUI(true);
        }

        private void FormularioGestaoClientes_Load(object sender, EventArgs e)
        {
            restGestContainer = new RestGestContainer();
            LerDados();
        }
        private void LerDados()
        {
            listBoxClientes.DataSource
                = restGestContainer.Pessoas.ToList();
        }
        private void FormularioGestaoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            restGestContainer.Dispose();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Pessoa pessoaSelecionada = (Pessoa)listBoxClientes.SelectedItem;
            Pessoa pessoa = new Pessoa();
            Morada morada = new Morada();
            pessoa.Nome = textBoxNome.Text;
            morada.Rua = textBoxRua.Text;
            morada.Cidade = textBoxCidade.Text;
            morada.CodPostal = textBoxCodPostal.Text;
            morada.Pais = textBoxPais.Text;
            pessoa.Telemovel = textBoxTelemovel.Text;
            pessoa.Morada = morada;

            if(!editar)
            {
                restGestContainer.Pessoas.Add(pessoa);
            }
            else
            {
                Pessoa a = restGestContainer.Pessoas.Find(pessoaSelecionada.Id);
                a.Nome = pessoa.Nome;
                a.Morada.Rua = pessoa.Morada.Rua;
                a.Morada.Cidade = pessoa.Morada.Cidade;
                a.Morada.CodPostal = pessoa.Morada.CodPostal;
                a.Morada.Pais = pessoa.Morada.Pais;
                a.Telemovel = pessoa.Telemovel;

            }
            
            restGestContainer.SaveChanges();
            LerDados();
            ChangeUI(true);
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa pessoaSelecionada = (Pessoa)listBoxClientes.SelectedItem;
            textBoxNome.Text = pessoaSelecionada.Nome;
            textBoxRua.Text = pessoaSelecionada.Morada.Rua;
            textBoxCidade.Text = pessoaSelecionada.Morada.Cidade;
            textBoxCodPostal.Text = pessoaSelecionada.Morada.CodPostal;
            textBoxPais.Text = pessoaSelecionada.Morada.Pais;
            textBoxTelemovel.Text = pessoaSelecionada.Telemovel;

            
        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            ChangeUI(false);
            editar = true;
            Pessoa pessoaSelecionada = (Pessoa)listBoxClientes.SelectedItem;
            textBoxNome.Text = pessoaSelecionada.Nome;
            textBoxRua.Text = pessoaSelecionada.Morada.Rua;
            textBoxCidade.Text = pessoaSelecionada.Morada.Cidade;
            textBoxCodPostal.Text = pessoaSelecionada.Morada.CodPostal;
            textBoxPais.Text = pessoaSelecionada.Morada.Pais;
            textBoxTelemovel.Text = pessoaSelecionada.Telemovel;

        }

        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            Pessoa pessoaSelecionada = (Pessoa)listBoxClientes.SelectedItem;
            if (pessoaSelecionada == null)
            {
                return;
            }

            // Remove o cliente e os carros associados (cascade)
            restGestContainer.Pessoas.Remove(pessoaSelecionada);
            // Guarda alterações na DB
            restGestContainer.SaveChanges();
            Limpar();
            // Atualiza dados de clientes existentes
            LerDados();
        }
    }
}
