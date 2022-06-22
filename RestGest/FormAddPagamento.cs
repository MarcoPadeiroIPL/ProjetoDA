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
    public partial class FormAddPagamento : Form
    {
        public MetodoPagamento metodoPagamento { get; set; }
        public Decimal valor { get; set; }
        private List<MetodoPagamento> metodosPagamento;
        public Decimal valorPorPagar { get; set; }
        public FormAddPagamento(List<MetodoPagamento> metodosPagamento, decimal valorPorPagar)
        {
            InitializeComponent();
            this.metodosPagamento = metodosPagamento;
            this.valorPorPagar = valorPorPagar;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBoxValor.Text.Trim()) || comboBoxMetodoPagamento.SelectedItem == null)
            {
                MessageBox.Show("Tem de preencher todos os campos!");
                return;
            }

            if(!Decimal.TryParse(textBoxValor.Text.Trim(), out var n))
            {
                MessageBox.Show("O valor tem de ser um numero decimal!");
                return;
            }
            

            this.metodoPagamento = comboBoxMetodoPagamento.SelectedItem as MetodoPagamento;
            this.valor = Convert.ToDecimal(textBoxValor.Text.Trim());
            if (this.valor > this.valorPorPagar)
            {
                MessageBox.Show("O valor tem de ser inferior ou igual ao valor por pagar!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Pagamento inserido com sucesso!");
            
            this.Close();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddPagamento_Load(object sender, EventArgs e)
        {

            labelValorPagar.Text = this.valorPorPagar + "€";
            
            if (this.metodosPagamento != null)
            {
                comboBoxMetodoPagamento.DataSource = metodosPagamento;
            }
            
        }
    }
}
