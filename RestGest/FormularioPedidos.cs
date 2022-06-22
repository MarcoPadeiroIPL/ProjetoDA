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
    public partial class FormularioPedidos : Form
    {
        public static RestGestContainer restGestContainer;
        public Restaurante restaurante { get; set; }
        public FormularioPedidos(Restaurante restaurante)
        {
            InitializeComponent();
            this.restaurante = restaurante;
        }

        private void buttonNovoPedido_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoverRestaurante_Click(object sender, EventArgs e)
        {

        }

        private void buttonCriarNovoPedido_Click(object sender, EventArgs e)
        {
            Pedido novoPedido = new Pedido();
            novoPedido.Restaurante = restaurante;
            novoPedido.EstadoId = 1;


            using (FormAddPedido formAddPedido = new FormAddPedido(novoPedido))
            {
                var result = formAddPedido.ShowDialog();
                if (result == DialogResult.OK)
                {
                    novoPedido = formAddPedido.pedido;

                    restGestContainer.Pedidos.Add(novoPedido);

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void LerDados()
        {
            var todosPedidos = restGestContainer.Pedidos;
            listBoxPedidosRecebidos.DataSource = from pedido in todosPedidos
                                                 where pedido.Estado.EstadoAtual == "Recebido"
                                                 select pedido;
            listBoxPedidosEmProcessamento.DataSource = from pedido in todosPedidos
                                                 where pedido.Estado.EstadoAtual == "Em Processamento"
                                                 select pedido;
            listBoxPedidosCompletos.DataSource = from pedido in todosPedidos
                                                 where pedido.Estado.EstadoAtual == "Concluido"
                                                 select pedido;
        }
        private void FormularioPedidos_Load(object sender, EventArgs e)
        {
            restGestContainer = new RestGestContainer();
            LerDados();
        }

        private void buttonAvancarRecebidos_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosRecebidos.SelectedItem as Pedido;

            if(pedidoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um pedido recebido!");
                return;
            }
            restGestContainer.Pedidos.Find(pedidoSelecionado).EstadoId = 2;
        }

        private void buttonRemoverPedidosRecebidos_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosRecebidos.SelectedItem as Pedido;

            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um pedido recebido!");
                return;
            }
            restGestContainer.Pedidos.Remove(pedidoSelecionado);
        }

        private void buttonCompletar_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosEmProcessamento.SelectedItem as Pedido;

            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um pedido em processamento!");
                return;
            }
            restGestContainer.Pedidos.Find(pedidoSelecionado).EstadoId = 4;
        }

        private void buttonRemoverPedidosCompletos_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosCompletos.SelectedItem as Pedido;

            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um pedido completo!");
                return;
            }
            restGestContainer.Pedidos.Remove(pedidoSelecionado);
        }
    }
}
