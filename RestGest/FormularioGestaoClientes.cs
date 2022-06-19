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
        public static RestGestContainer restGestContainer;
        public FormularioGestaoClientes()
        {
            InitializeComponent();
        }
        private void FormularioGestaoClientes_Load(object sender, EventArgs e)
        {
            restGestContainer = new RestGestContainer();
            LerDados();
        }
        private void LerDados()
        {
            listBoxClientes.DataSource = restGestContainer.Pessoas.OfType<Cliente>().ToList();
        }
        private void FormularioGestaoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            restGestContainer.Dispose();
        }

        private void buttonAdicionarClientes_Click(object sender, EventArgs e)
        {
            using (FormAddClientes formAddClientes = new FormAddClientes())
            {
                var result = formAddClientes.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Cliente novoCliente = new Cliente();
                    novoCliente.Nome = formAddClientes.nome;
                    novoCliente.Morada = formAddClientes.morada;
                    novoCliente.NumContribuinte = formAddClientes.numContribuinte;
                    novoCliente.Telemovel = formAddClientes.telemovel;


                    restGestContainer.Pessoas.Add(novoCliente);

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um cliente!");
                return;
            }
            restGestContainer.Pessoas.Remove(clienteSelecionado);
            restGestContainer.SaveChanges();
            LerDados();
        }

        private void buttonEditarClientes_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um cliente!");
                return;
            }

            using (FormAddClientes formAddClientes = new FormAddClientes(clienteSelecionado.Nome, clienteSelecionado.Morada, clienteSelecionado.Telemovel, clienteSelecionado.NumContribuinte))
            {
                var result = formAddClientes.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach(Cliente cliente in restGestContainer.Pessoas.OfType<Cliente>())
                    {
                        if(cliente == clienteSelecionado)
                        {
                            cliente.Nome = formAddClientes.nome;
                            cliente.Morada = formAddClientes.morada;
                            cliente.Telemovel = formAddClientes.telemovel;
                            cliente.NumContribuinte = formAddClientes.numContribuinte;
                        }

                    }

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;
            if (clienteSelecionado != null)
            {
                labelNome.Text = clienteSelecionado.Nome;
                labelRua.Text = clienteSelecionado.Morada.Rua;
                labelCidade.Text = clienteSelecionado.Morada.Cidade;
                labelCodPostal.Text = clienteSelecionado.Morada.CodPostal;
                labelPais.Text = clienteSelecionado.Morada.Pais;
                labelTelemovel.Text = clienteSelecionado.Telemovel;
                labelTotalGasto.Text = clienteSelecionado.TotalGasto + "€";
                labelNumContribuinte.Text = clienteSelecionado.NumContribuinte;

            }
        }
    }
}
