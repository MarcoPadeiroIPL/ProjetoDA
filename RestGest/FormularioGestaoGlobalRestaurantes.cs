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
    public partial class FormularioGestaoGlobalRestaurantes : Form
    {

        public static RestGestContainer restGestContainer;
        public FormularioGestaoGlobalRestaurantes()
        {
            InitializeComponent();
        }

        private void buttonAdicionarRestaurante_Click(object sender, EventArgs e)
        {
            using (FormAddRestaurante formAddRestaurante = new FormAddRestaurante())
            {
                var result = formAddRestaurante.ShowDialog();
                if(result == DialogResult.OK)
                {
                    Restaurante novoRestaurante = new Restaurante();
                    novoRestaurante.Nome = formAddRestaurante.nome;
                    novoRestaurante.Morada = formAddRestaurante.morada;


                    restGestContainer.Restaurantes.Add(novoRestaurante);

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonRemoverRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = listBoxRestaurantes.SelectedItem as Restaurante;
            if (restauranteSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um restaurante!");
                return;
            }
            restGestContainer.Restaurantes.Remove(restauranteSelecionado);
            restGestContainer.SaveChanges();
            LerDados();
        }

        private void buttonEditarRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = listBoxRestaurantes.SelectedItem as Restaurante;
            if(restauranteSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um restaurante!");
                return;
            }

            using (FormAddRestaurante formAddRestaurante = new FormAddRestaurante(restauranteSelecionado.Nome, restauranteSelecionado.Morada))
            {
                var result = formAddRestaurante.ShowDialog();
                if (result == DialogResult.OK)
                {
                    restGestContainer.Restaurantes.Find(restauranteSelecionado.Id).Nome = formAddRestaurante.nome;
                    restGestContainer.Restaurantes.Find(restauranteSelecionado.Id).Morada = formAddRestaurante.morada;

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonAdicionarCategoria_Click(object sender, EventArgs e)
        {
            using (FormAddCategoria formAddCategoria = new FormAddCategoria())
            {
                var result = formAddCategoria.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Categoria novaCategoria = new Categoria();
                    novaCategoria.Ativo = formAddCategoria.ativo;
                    novaCategoria.Nome = formAddCategoria.nome;


                    restGestContainer.Categorias.Add(novaCategoria);

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonRemoverCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoriaSelecionada = listBoxCategorias.SelectedItem as Categoria;
            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Precisa de selecionar uma categoria!");
                return;
            }
            restGestContainer.Categorias.Remove(categoriaSelecionada);
            restGestContainer.SaveChanges();
            LerDados();
        }

        private void buttonEditarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoriaSelecionada = listBoxCategorias.SelectedItem as Categoria;
            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Precisa de selecionar uma categoria!");
                return;
            }

            using (FormAddCategoria formAddCategoria = new FormAddCategoria(categoriaSelecionada.Nome, categoriaSelecionada.Ativo))
            {
                var result = formAddCategoria.ShowDialog();
                if (result == DialogResult.OK)
                {
                    restGestContainer.Categorias.Find(categoriaSelecionada.Id).Nome = formAddCategoria.nome;
                    restGestContainer.Categorias.Find(categoriaSelecionada.Id).Ativo = formAddCategoria.ativo;

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonAdicionarMetodo_Click(object sender, EventArgs e)
        {
            using (FormAddMetodo formAddMetodo = new FormAddMetodo())
            {
                var result = formAddMetodo.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MetodoPagamento novoMetodo = new MetodoPagamento();
                    novoMetodo.Ativo = formAddMetodo.ativo;
                    novoMetodo.Metodo = formAddMetodo.metodoPagamento;


                    restGestContainer.MetodosPagamento.Add(novoMetodo);

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonRemoverMetodo_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodoSelecionado = listBoxMetodosPagamento.SelectedItem as MetodoPagamento;
            if (metodoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um metodo!");
                return;
            }
            restGestContainer.MetodosPagamento.Remove(metodoSelecionado);
            restGestContainer.SaveChanges();
            LerDados();
        }

        private void buttonEditarMetodo_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodoSelecionado = listBoxMetodosPagamento.SelectedItem as MetodoPagamento;
            if (metodoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um metodo!");
                return;
            }

            using (FormAddMetodo formAddMetodo = new FormAddMetodo(metodoSelecionado.Metodo, metodoSelecionado.Ativo))
            {
                var result = formAddMetodo.ShowDialog();
                if (result == DialogResult.OK)
                {
                    restGestContainer.MetodosPagamento.Find(metodoSelecionado.Id).Metodo = formAddMetodo.metodoPagamento;
                    restGestContainer.MetodosPagamento.Find(metodoSelecionado.Id).Ativo = formAddMetodo.ativo;

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void FormularioGestaoGlobalRestaurantes_Load(object sender, EventArgs e)
        {
            restGestContainer = new RestGestContainer();
            LerDados();
        }
        private void LerDados()
        {
            listBoxRestaurantes.DataSource = restGestContainer.Restaurantes.ToList();
            listBoxCategorias.DataSource = restGestContainer.Categorias.ToList();
            listBoxMetodosPagamento.DataSource = restGestContainer.MetodosPagamento.ToList();
        }
    }
}
