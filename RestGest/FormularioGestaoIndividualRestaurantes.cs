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
    public partial class FormularioGestaoIndividualRestaurantes : Form
    {
        public static RestGestContainer restGestContainer;
        public FormularioGestaoIndividualRestaurantes()
        {
            InitializeComponent();
        }
        private void LerDados()
        {
            comboBoxRestaurantes.DataSource = restGestContainer.Restaurantes.ToList();
            listBoxItensMenu.DataSource = restGestContainer.ItemMenus.ToList();
        }
        private void buttonAdicionarTrabalhadores_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = comboBoxRestaurantes.SelectedItem as Restaurante;

            if(restauranteSelecionado != null)
            {
                using (FormAddTrabalhadores formAddTrabalhadores = new FormAddTrabalhadores())
                {
                    var result = formAddTrabalhadores.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Trabalhador novoTrabalhador = new Trabalhador();
                        novoTrabalhador.Nome = formAddTrabalhadores.nome;
                        novoTrabalhador.Morada = formAddTrabalhadores.morada;
                        novoTrabalhador.RestauranteId = formAddTrabalhadores.restauranteID;
                        novoTrabalhador.Salario = formAddTrabalhadores.salario;
                        novoTrabalhador.Posicao = formAddTrabalhadores.posicao;
                        novoTrabalhador.Telemovel = formAddTrabalhadores.telemovel;



                        restGestContainer.Pessoas.Add(novoTrabalhador);

                        restGestContainer.SaveChanges();
                        LerDados();
                    }
                }
            }
        }

        private void buttonRemoverTrabalhadores_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhadorSelecionado = listBoxTrabalhadores.SelectedItem as Trabalhador;
            if (trabalhadorSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um cliente!");
                return;
            }
            restGestContainer.Pessoas.Remove(trabalhadorSelecionado);
            restGestContainer.SaveChanges();
            LerDados();
        }

        private void buttonEditarTrabalhadores_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhadorSelecionado = listBoxTrabalhadores.SelectedItem as Trabalhador;
            if (trabalhadorSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um cliente!");
                return;
            }

            using (FormAddTrabalhadores formAddTrabalhadores = new FormAddTrabalhadores(trabalhadorSelecionado.Nome, trabalhadorSelecionado.Morada, trabalhadorSelecionado.Telemovel, trabalhadorSelecionado.Posicao, trabalhadorSelecionado.Salario, comboBoxRestaurantes.SelectedIndex))
            {
                var result = formAddTrabalhadores.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (Trabalhador trabalhador in restGestContainer.Pessoas.OfType<Trabalhador>())
                    {
                        if (trabalhador == trabalhadorSelecionado)
                        {
                            trabalhador.Nome = formAddTrabalhadores.nome;
                            trabalhador.Morada = formAddTrabalhadores.morada;
                            trabalhador.RestauranteId = formAddTrabalhadores.restauranteID;
                            trabalhador.Salario = formAddTrabalhadores.salario;
                            trabalhador.Posicao = formAddTrabalhadores.posicao;
                            trabalhador.Telemovel = formAddTrabalhadores.telemovel;
                        }

                    }

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonAdicionarItemMenu_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = comboBoxRestaurantes.SelectedItem as Restaurante;
            ItemMenu itemSelecionado = listBoxItensMenu.SelectedItem as ItemMenu;

            if(restauranteSelecionado != null)
            {
                if (itemSelecionado != null)
                {
                    restGestContainer.Restaurantes.Find(restauranteSelecionado).ItemMenus.Add(itemSelecionado);
                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonRemoverItemMenu_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = comboBoxRestaurantes.SelectedItem as Restaurante;
            ItemMenu itemSelecionado = listBoxItensMenu.SelectedItem as ItemMenu;
            if (restauranteSelecionado != null)
            {
                if (itemSelecionado != null)
                {
                    restGestContainer.Restaurantes.Find(restauranteSelecionado).ItemMenus.Remove(itemSelecionado);
                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }
        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            FormularioPedidos formPedidos = new FormularioPedidos();
            formPedidos.ShowDialog();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormularioMenu formMenu = new FormularioMenu();
            formMenu.ShowDialog();
        }

        private void FormularioGestaoIndividualRestaurantes_Load(object sender, EventArgs e)
        {
            restGestContainer = new RestGestContainer();
            LerDados();
        }

        private void FormularioGestaoIndividualRestaurantes_FormClosing(object sender, FormClosingEventArgs e)
        {

            restGestContainer.Dispose();
        }

        private void comboBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trabalhadores = restGestContainer.Pessoas.OfType<Trabalhador>();
            Restaurante restauranteSelecionado = comboBoxRestaurantes.SelectedItem as Restaurante;
            if(restauranteSelecionado != null)
            {
                var trabalhadoresFromRestaurante = from trabalhador in trabalhadores
                                                   where trabalhador.RestauranteId == restauranteSelecionado.Id
                                                   select trabalhador;
                listBoxTrabalhadores.DataSource = trabalhadoresFromRestaurante.ToList();
                listBoxMenu.DataSource = restauranteSelecionado.ItemMenus.ToList();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhadorSelecionado = listBoxTrabalhadores.SelectedItem as Trabalhador;
            if (trabalhadorSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um cliente!");
                return;
            }

            using (FormAddTrabalhadores formAddTrabalhadores = new FormAddTrabalhadores(trabalhadorSelecionado.Nome, trabalhadorSelecionado.Morada, trabalhadorSelecionado.Telemovel, trabalhadorSelecionado.Posicao, trabalhadorSelecionado.Salario, comboBoxRestaurantes.SelectedIndex, true))
            {
                formAddTrabalhadores.ShowDialog();
                
            }
        }
    }
}
