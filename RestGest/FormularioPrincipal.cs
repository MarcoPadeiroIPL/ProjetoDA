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
    public partial class FormularioPrincipal : Form
    {
        private FormularioGestaoClientes formClientes;
        private FormularioGestaoGlobalRestaurantes formGlobalRestaurantes;
        private FormularioGestaoIndividualRestaurantes formIndividualRestaurantes;
        private FormularioMenu formMenu;
        private FormularioPedidos formPedidos;
        public FormularioPrincipal()
        {
            InitializeComponent();
            formClientes = new FormularioGestaoClientes();
            formGlobalRestaurantes = new FormularioGestaoGlobalRestaurantes();
            formIndividualRestaurantes = new FormularioGestaoIndividualRestaurantes();
            formMenu = new FormularioMenu();
            formPedidos = new FormularioPedidos();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            formClientes.ShowDialog();
        }

        private void buttonGlobalRestaurantes_Click(object sender, EventArgs e)
        {
            formGlobalRestaurantes.ShowDialog();
        }

        private void buttonIndividualRestaurantes_Click(object sender, EventArgs e)
        {
            formIndividualRestaurantes.ShowDialog();

        }

        private void buttonMenus_Click(object sender, EventArgs e)
        {
            formMenu.ShowDialog();

        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            formPedidos.ShowDialog();
        }
    }
}
