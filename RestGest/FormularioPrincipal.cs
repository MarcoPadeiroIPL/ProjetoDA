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
        RestGestContainer restGestContainer;
        private FormularioGestaoClientes formClientes;
        private FormularioGestaoGlobalRestaurantes formGlobalRestaurantes;
        private FormularioGestaoIndividualRestaurantes formIndividualRestaurantes;
        public FormularioPrincipal()
        {
            InitializeComponent();
            restGestContainer = new RestGestContainer();
            formClientes = new FormularioGestaoClientes();
            formGlobalRestaurantes = new FormularioGestaoGlobalRestaurantes();
            formIndividualRestaurantes = new FormularioGestaoIndividualRestaurantes();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            //abre o formulario da gestão dos clientes
            formClientes.ShowDialog();
        }

        private void buttonGlobalRestaurantes_Click(object sender, EventArgs e)
        {
            //abre o formulario da gestão global de restaurantes
            formGlobalRestaurantes.ShowDialog();
        }

        private void buttonIndividualRestaurantes_Click(object sender, EventArgs e)
        {
            //abre o formulario da gestão individual de restaurantes
            formIndividualRestaurantes.ShowDialog();

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            if(restGestContainer.Estados.Find(1) == null)
            {
                Estado estado = new Estado();
                estado.EstadoAtual = "Recebido";
                restGestContainer.Estados.Add(estado);
            }
            if (restGestContainer.Estados.Find(2) == null)
            {
                Estado estado = new Estado();
                estado.EstadoAtual = "Em processamento";
                restGestContainer.Estados.Add(estado);
            }
            if (restGestContainer.Estados.Find(3) == null)
            {
                Estado estado = new Estado();
                estado.EstadoAtual = "Cancelado";
                restGestContainer.Estados.Add(estado);
            }
            if (restGestContainer.Estados.Find(4) == null)
            {
                Estado estado = new Estado();
                estado.EstadoAtual = "Concluido";
                restGestContainer.Estados.Add(estado);
            }
            restGestContainer.SaveChanges();

        }
    }
}
