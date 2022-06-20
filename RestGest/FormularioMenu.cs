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
            LerDados();
        }
        private void LerDados()
        {
            listBoxMenus.DataSource = restGestContainer.Restaurantes.ToList();
        }

    }
}
