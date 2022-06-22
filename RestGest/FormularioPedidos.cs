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


        private void buttonCriarNovoPedido_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Estado estado = restGestContainer.Estados.Find(1);
            List<Cliente> clientes = restGestContainer.Pessoas.OfType<Cliente>().ToList();
            List<Trabalhador> trabalhadors = restGestContainer.Pessoas.OfType<Trabalhador>().ToList();
            List<ItemMenu> totalItensMenus = restGestContainer.ItemMenus.ToList();
            using (FormAddPedido formAddPedido = new FormAddPedido(clientes, trabalhadors, totalItensMenus, new List<ItemMenu>(), estado))
=======
            var estado = restGestContainer.Estados.Find(1);
            using (FormAddPedido formAddPedido = new FormAddPedido(restaurante, new List<ItemMenu>(), estado))
>>>>>>> a2d8ea5ef91f0ce7b720b6e925120d81b42c58eb
            {
                var result = formAddPedido.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Pedido novoPedido = new Pedido();
<<<<<<< HEAD
                    novoPedido.Restaurante = restGestContainer.Restaurantes.Find(restaurante.Id);
                    novoPedido.Estado = estado;
=======
                    novoPedido.Restaurante = restaurante;
                    novoPedido.Estado = formAddPedido.estado;
>>>>>>> a2d8ea5ef91f0ce7b720b6e925120d81b42c58eb
                    novoPedido.Trabalhador = formAddPedido.trabalhador;
                    novoPedido.Cliente = formAddPedido.cliente;

                    if(novoPedido.ItemMenus != null)
                    {
                        foreach (ItemMenu item in formAddPedido.itensMenu)
                        {
                            novoPedido.ItemMenus.Add(item);
                            novoPedido.ValorTotal += item.Preco;
                        }
                    }

                    restGestContainer.Pedidos.Add(novoPedido);

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void LerDados()
        {
            var todosPedidos = restGestContainer.Pedidos;
            listBoxPedidosRecebidos.DataSource = (from pedido in todosPedidos
                                                 where pedido.Estado.Id == 1
                                                 select pedido).ToList();
            listBoxPedidosEmProcessamento.DataSource = (from pedido in todosPedidos
                                                 where pedido.Estado.Id == 2 
                                                 select pedido).ToList();
            listBoxPedidosCompletos.DataSource = (from pedido in todosPedidos
                                                 where pedido.Estado.Id == 4
                                                 select pedido).ToList();
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
            pedidoSelecionado.EstadoId = 2;
            restGestContainer.SaveChanges();
            LerDados();
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
            Decimal valorPago = 0;
            if (pedidoSelecionado.Pagamentos.Count > 0)
            {
                foreach (Pagamento pagamento in pedidoSelecionado.Pagamentos)
                {
                    valorPago += pagamento.Valor;
                }
            }
            if (valorPago == pedidoSelecionado.ValorTotal)
            {
                pedidoSelecionado.EstadoId = 4;
                restGestContainer.SaveChanges();
                LerDados();
            }
            else
            {
                MessageBox.Show("O pedido ainda não está pago!");
                return;
            }
            
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosCompletos.SelectedItem as Pedido;
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um pedido em processamento!");
                return;
            }
            string[] lines =
            {
                "--------------------------------------------------------------------------------------",
                "Trabalhador: " + pedidoSelecionado.Trabalhador.Nome + "(" + pedidoSelecionado.Trabalhador.Telemovel + ")",
                "--------------------------------------------------------------------------------------",
                "Cliente: " + pedidoSelecionado.Cliente.Nome + "(" + pedidoSelecionado.Cliente.Telemovel + ")",
                "--------------------------------------------------------------------------------------",
                "Restaurante: " + pedidoSelecionado.Restaurante.Nome,
                "--------------------------------------------------------------------------------------",
                "Estado: " + pedidoSelecionado.Estado.EstadoAtual,
                "--------------------------------------------------------------------------------------"
            };
            foreach(Pagamento pagamento in pedidoSelecionado.Pagamentos)
            {
                lines.Append("Pagamento: " + pagamento.MetodoPagamento + " - " + pagamento.Valor);
                lines.Append("--------------------------------------------------------------------------------------");
            }
            foreach(ItemMenu item in pedidoSelecionado.ItemMenus)
            {
                lines.Append("Pagamento: " + item.Nome + " (" + item.Categoria + ") - " + item.Preco);
                lines.Append("--------------------------------------------------------------------------------------");
            }
            File.WriteAllLines("Pedido" + pedidoSelecionado.Id + ".txt", lines);
        }

        private void buttonAdicionarPagamentos_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosEmProcessamento.SelectedItem as Pedido;
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Tem de selecionar um item em processamento");
                return;
            }
            Decimal valorPago = 0;
            if (pedidoSelecionado.Pagamentos.Count > 0)
            {
                foreach(Pagamento pagamento in pedidoSelecionado.Pagamentos)
                {
                    valorPago += pagamento.Valor;
                }
            }
            using (FormAddPagamento formAddPagamento = new FormAddPagamento(restGestContainer.MetodosPagamento.ToList(), pedidoSelecionado.ValorTotal-valorPago))
            {
                var result = formAddPagamento.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Pagamento novoPagamento = new Pagamento();
                    novoPagamento.MetodoPagamento = formAddPagamento.metodoPagamento;
                    novoPagamento.Valor = formAddPagamento.valor;
                    novoPagamento.Pedido = pedidoSelecionado;

                    restGestContainer.Pagamentos.Add(novoPagamento);

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void listBoxPedidosEmProcessamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosEmProcessamento.SelectedItem as Pedido;
            decimal valorPorPagar = 0;
            decimal valorPago = 0;
            foreach(Pagamento pagamento in pedidoSelecionado.Pagamentos)
            {
                valorPago += pagamento.Valor; 
            }
            valorPorPagar = pedidoSelecionado.ValorTotal - valorPago;
            labelValorTotal.Text = pedidoSelecionado.ValorTotal + "€";
            labelValorPago.Text = valorPago + "€";
            labelValorPorPagar.Text = valorPorPagar + "€";

        }

        private void listBoxPedidosCompletos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosCompletos.SelectedItem as Pedido;
            decimal valorPorPagar = 0;
            decimal valorPago = 0;
            foreach (Pagamento pagamento in pedidoSelecionado.Pagamentos)
            {
                valorPago += pagamento.Valor;
            }
            valorPorPagar = pedidoSelecionado.ValorTotal - valorPago;
            labelValorTotal.Text = pedidoSelecionado.ValorTotal + "€";
            labelValorPago.Text = valorPago + "€";
            labelValorPorPagar.Text = valorPorPagar + "€";

        }

        private void buttonGerirPedido_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosRecebidos.SelectedItem as Pedido;
            if(pedidoSelecionado == null)
            {
                MessageBox.Show("Tem que selecionar um pedido recebido");
                return;
            }


            Estado estado = pedidoSelecionado.Estado;
            List<Cliente> clientes = restGestContainer.Pessoas.OfType<Cliente>().ToList();
            List<Trabalhador> trabalhadors = restGestContainer.Pessoas.OfType<Trabalhador>().ToList();
            List<ItemMenu> totalItensMenus = restGestContainer.ItemMenus.ToList();
            using (FormAddPedido formAddPedido = new FormAddPedido(clientes, trabalhadors, totalItensMenus, pedidoSelecionado.ItemMenus.ToList(), estado, pedidoSelecionado.Cliente, pedidoSelecionado.Trabalhador ))
            {
                var result = formAddPedido.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pedidoSelecionado.Restaurante = restGestContainer.Restaurantes.Find(restaurante.Id);
                    pedidoSelecionado.Estado = estado;
                    pedidoSelecionado.Trabalhador = formAddPedido.trabalhador;
                    pedidoSelecionado.Cliente = formAddPedido.cliente;

                    if (pedidoSelecionado.ItemMenus != null)
                    {
                        pedidoSelecionado.ValorTotal = 0;
                        foreach (ItemMenu item in formAddPedido.itensMenu)
                        {
                            pedidoSelecionado.ItemMenus.Add(item);
                            pedidoSelecionado.ValorTotal += item.Preco;
                        }
                    }

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonGerirPedidoProcessamento_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = listBoxPedidosEmProcessamento.SelectedItem as Pedido;
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Tem que selecionar um pedido recebido");
                return;
            }


            Estado estado = pedidoSelecionado.Estado;
            List<Cliente> clientes = restGestContainer.Pessoas.OfType<Cliente>().ToList();
            List<Trabalhador> trabalhadors = restGestContainer.Pessoas.OfType<Trabalhador>().ToList();
            List<ItemMenu> totalItensMenus = restGestContainer.ItemMenus.ToList();
            using (FormAddPedido formAddPedido = new FormAddPedido(clientes, trabalhadors, totalItensMenus, pedidoSelecionado.ItemMenus.ToList(), estado, pedidoSelecionado.Cliente, pedidoSelecionado.Trabalhador))
            {
                var result = formAddPedido.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pedidoSelecionado.Restaurante = restGestContainer.Restaurantes.Find(restaurante.Id);
                    pedidoSelecionado.Estado = estado;
                    pedidoSelecionado.Trabalhador = formAddPedido.trabalhador;
                    pedidoSelecionado.Cliente = formAddPedido.cliente;

                    if (pedidoSelecionado.ItemMenus != null)
                    {
                        pedidoSelecionado.ValorTotal = 0;
                        foreach (ItemMenu item in formAddPedido.itensMenu)
                        {
                            pedidoSelecionado.ItemMenus.Add(item);
                            pedidoSelecionado.ValorTotal += item.Preco;
                        }
                    }

                    restGestContainer.SaveChanges();
                    LerDados();
                }
            }
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
        }
    }
}
