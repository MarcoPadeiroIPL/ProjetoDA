using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormularioMenu : Form
    {
        public static RestGestContainer restGestContainer;
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = (Restaurante)listBoxMenus.SelectedItem;
            foreach(ItemMenu itemMenu in restauranteSelecionado.ItemMenus)
            {
                listBoxMenus.Items.Add(itemMenu);
            }
        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {
            restGestContainer = new RestGestContainer();
            listBoxCategorias.DataSource = (from categoria in restGestContainer.Categorias.ToList()
                                           where categoria.Ativo == true
                                           select categoria).ToList();
            LerDados();
        }
        private void LerDados()
        {
            listBoxMenus.DataSource = restGestContainer.ItemMenus.ToList();
        }

        private void buttonAdicionarRestaurante_Click(object sender, EventArgs e)
        {
            var categorias = from categoria in restGestContainer.Categorias.ToList()
                             where categoria.Ativo == true
                             select categoria;
            using (FormAddItem formAddItem = new FormAddItem(categorias))
            {
                var result = formAddItem.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ItemMenu novoItem = new ItemMenu();
                    novoItem.Nome = formAddItem.nome;
                    novoItem.Categoria = formAddItem.categoria;
                    novoItem.Fotografia = formAddItem.imagem;
                    novoItem.Ingredientes = formAddItem.ingredientes;
                    novoItem.Preco = formAddItem.preco;
                    novoItem.Ativo = formAddItem.ativo;
                    restGestContainer.ItemMenus.Add(novoItem);
                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonRemoverRestaurante_Click(object sender, EventArgs e)
        {
            ItemMenu itemSelecionado = listBoxMenus.SelectedItem as ItemMenu;
            if (itemSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um item!");
                return;
            }
            foreach (Restaurante restaurante in restGestContainer.Restaurantes)
            {
                foreach(ItemMenu item in restaurante.ItemMenus)
                {
                    if(item == itemSelecionado)
                    {
                        restaurante.ItemMenus.Remove(item);
                    }
                }
            }
            restGestContainer.ItemMenus.Remove(itemSelecionado);
            restGestContainer.SaveChanges();
            LerDados();
        }

        private void buttonEditarRestaurante_Click(object sender, EventArgs e)
        {
            var categorias = from categoria in restGestContainer.Categorias.ToList()
                             where categoria.Ativo == true
                             select categoria;
            ItemMenu itemSelecionado = listBoxMenus.SelectedItem as ItemMenu;
            if (itemSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um item!");
                return;
            }

            using (FormAddItem formAddItem = new FormAddItem(categorias, itemSelecionado.Nome, itemSelecionado.Ingredientes, itemSelecionado.Categoria, itemSelecionado.Preco, itemSelecionado.Ativo, itemSelecionado.Fotografia))
            {
                var result = formAddItem.ShowDialog();
                if (result == DialogResult.OK)
                {
                    
                    itemSelecionado.Nome = formAddItem.nome; 
                    itemSelecionado.Categoria = formAddItem.categoria; 
                    itemSelecionado.Fotografia = formAddItem.imagem; 
                    itemSelecionado.Ingredientes = formAddItem.ingredientes; 
                    itemSelecionado.Preco = formAddItem.preco; 
                    itemSelecionado.Ativo = formAddItem.ativo; 

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void listBoxMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemMenu itemSelecionado = listBoxMenus.SelectedItem as ItemMenu;
            if (itemSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um item!");
                return;
            }
            if(File.Exists(itemSelecionado.Fotografia))
            {
                pictureBox.Image = new Bitmap(itemSelecionado.Fotografia);
            } else
            {
                pictureBox.Image = null;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            labelNome.Text = itemSelecionado.Nome;
            labelCategoria.Text = itemSelecionado.Categoria.Nome;
            labelIngredientes.Text = itemSelecionado.Ingredientes;
            labelPreco.Text = itemSelecionado.Preco + "€";
            labelAtivo.Text = itemSelecionado.Ativo ? "Sim" : "Não";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
