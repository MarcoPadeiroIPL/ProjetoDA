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
        public FormularioPedidos(Restaurante restaurante = null)
        {
            InitializeComponent();
            this.restaurante = restaurante;
        }

        private void buttonCriarNovoPedido_Click(object sender, EventArgs e)
        {
            if (restaurante == null)
            {
                MessageBox.Show("Tem de selecionar um restaurante");
                return;
            }
            Estado estado = restGestContainer.Estados.Find(1);
            List<Cliente> clientes = restGestContainer.Pessoas.OfType<Cliente>().ToList();
            List<Trabalhador> trabalhadors = restGestContainer.Pessoas.OfType<Trabalhador>().ToList();
            List<ItemMenu> totalItensMenus = (from item in restGestContainer.ItemMenus.ToList()
                                             where item.Ativo == true
                                             select item).ToList();
            
            //apresenta o formulário para criar um novo pedido e adiciona os dados na lista do pedidos recebidos
            using (FormAddPedido formAddPedido = new FormAddPedido(clientes, trabalhadors, totalItensMenus, new List<ItemMenu>(), estado))
            {
                var result = formAddPedido.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Pedido novoPedido = new Pedido();
                    novoPedido.Restaurante = restGestContainer.Restaurantes.Find(restaurante.Id);
                    novoPedido.Estado = estado;
                    novoPedido.Trabalhador = formAddPedido.trabalhador;
                    novoPedido.Cliente = formAddPedido.cliente;

                    if(formAddPedido.itensMenu != null)
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
            //apresenta os pedidos dependendo do seu estado 
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
            //avança o estado do pedido recebido selecionado
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
            //remove o pedido recebido selecionado
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
            //passa para o estado "concluido" o pedido selecionado

            Pedido pedidoSelecionado = listBoxPedidosEmProcessamento.SelectedItem as Pedido;

            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um pedido em processamento!");
                return;
            }

            //verifica se o pedido foi pago

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
                pedidoSelecionado.Cliente.TotalGasto += pedidoSelecionado.ValorTotal;
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
            //exporta os dados do pedido selecionado
            Pedido pedidoSelecionado = listBoxPedidosCompletos.SelectedItem as Pedido;
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Precisa de selecionar um pedido concluido!");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\PedidosExportados";
            saveFileDialog1.Title = "Guardar Pedido";
            saveFileDialog1.FileName = "Pedido" + pedidoSelecionado.Id;
            saveFileDialog1.Filter = "Text File | *.txt";
            

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());

               
                writer.WriteLine("--------------------------------------------------------------------------------------");
                writer.WriteLine("Trabalhador: " + pedidoSelecionado.Trabalhador.Nome + "(" + pedidoSelecionado.Trabalhador.Telemovel + ")");
                writer.WriteLine("--------------------------------------------------------------------------------------");
                writer.WriteLine("Cliente: " + pedidoSelecionado.Cliente.Nome + "(" + pedidoSelecionado.Cliente.Telemovel + ")");
                writer.WriteLine("--------------------------------------------------------------------------------------");
                writer.WriteLine("Restaurante: " + pedidoSelecionado.Restaurante.Nome);
                writer.WriteLine("--------------------------------------------------------------------------------------");
                writer.WriteLine("Estado: " + pedidoSelecionado.Estado.EstadoAtual);
                writer.WriteLine("--------------------------------------------------------------------------------------");
                foreach (Pagamento pagamento in pedidoSelecionado.Pagamentos)
                {
                    writer.WriteLine("Pagamento: " + pagamento.MetodoPagamento + " - " + pagamento.Valor + "€");
                    
                }
                writer.WriteLine("--------------------------------------------------------------------------------------");
                foreach (ItemMenu item in pedidoSelecionado.ItemMenus)
                {
                    writer.WriteLine("Item: " + item.Nome + " (" + item.Categoria + ") - " + item.Preco + "€");
                    
                }
                writer.WriteLine("--------------------------------------------------------------------------------------");
            

                writer.Dispose();

                writer.Close();
            }
            /* string[] lines =
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
             File.WriteAllLines("Pedido" + pedidoSelecionado.Id + ".txt", lines);*/

        }

        private void buttonAdicionarPagamentos_Click(object sender, EventArgs e)
        {
            //adiciona um pagamento ao pedido selecionado
            Pedido pedidoSelecionado = listBoxPedidosEmProcessamento.SelectedItem as Pedido;
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Tem de selecionar um item em processamento");
                return;
            }
            //por cada pagamento feito calcula o valor que foi pago e reduz do total para calcular o que ainda falta pagar
            Decimal valorPago = 0;
            if (pedidoSelecionado.Pagamentos.Count > 0)
            {
                foreach(Pagamento pagamento in pedidoSelecionado.Pagamentos)
                {
                    valorPago += pagamento.Valor;
                }
            }
            List<MetodoPagamento> metodosPagamento = (from metodo in restGestContainer.MetodosPagamento.ToList()
                                                      where metodo.Ativo == true
                                                      select metodo).ToList();
            using (FormAddPagamento formAddPagamento = new FormAddPagamento(metodosPagamento, pedidoSelecionado.ValorTotal-valorPago))
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
            //apresenta o valor total, pago e por pagar dos pedidos em processamento
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
            //apresenta o valor total, pago e por pagar dos pedidos completos
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
            //mostra o pedido recebido selecionado
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
            using (FormAddPedido formAddPedido = new FormAddPedido(clientes, trabalhadors, totalItensMenus, pedidoSelecionado.ItemMenus.ToList(), estado, false, pedidoSelecionado.Cliente, pedidoSelecionado.Trabalhador ))
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
            //mostra o pedido em processamento selecionado
            Pedido pedidoSelecionado = listBoxPedidosEmProcessamento.SelectedItem as Pedido;
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Tem que selecionar um pedido em processamento");
                return;
            }


            Estado estado = pedidoSelecionado.Estado;
            List<Cliente> clientes = restGestContainer.Pessoas.OfType<Cliente>().ToList();
            List<Trabalhador> trabalhadors = restGestContainer.Pessoas.OfType<Trabalhador>().ToList();
            List<ItemMenu> totalItensMenus = restGestContainer.ItemMenus.ToList();
            using (FormAddPedido formAddPedido = new FormAddPedido(clientes, trabalhadors, totalItensMenus, pedidoSelecionado.ItemMenus.ToList(), estado, false, pedidoSelecionado.Cliente, pedidoSelecionado.Trabalhador))
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

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //mostra o pedido em processamento selecionado
            Pedido pedidoSelecionado = listBoxPedidosCompletos.SelectedItem as Pedido;
            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Tem que selecionar um pedido em processamento");
                return;
            }


            Estado estado = pedidoSelecionado.Estado;
            List<Cliente> clientes = restGestContainer.Pessoas.OfType<Cliente>().ToList();
            List<Trabalhador> trabalhadors = restGestContainer.Pessoas.OfType<Trabalhador>().ToList();
            List<ItemMenu> totalItensMenus = restGestContainer.ItemMenus.ToList();
            using (FormAddPedido formAddPedido = new FormAddPedido(clientes, trabalhadors, totalItensMenus, pedidoSelecionado.ItemMenus.ToList(), estado, true, pedidoSelecionado.Cliente, pedidoSelecionado.Trabalhador))
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
    }
}
