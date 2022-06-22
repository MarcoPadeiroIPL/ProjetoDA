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
    public partial class FormAddTrabalhadores : Form
    {
        public string nome { get; set; }
        public string telemovel { get; set; }
        public Morada morada { get; set; }
        public int restauranteID { get; set; }
        public decimal salario { get; set; }
        public string posicao { get; set; }
        public bool consultar; 
        public static RestGestContainer restGestContainer;
        public FormAddTrabalhadores(string nome = null, Morada morada = null, string telemovel = null, string posicao = null, decimal salario = 0, int restauranteID = 0, bool consultar = false)
        {
            InitializeComponent();
            this.nome = nome;
            this.telemovel = telemovel;
            this.morada = morada;
            this.posicao = posicao;
            this.salario = salario;
            this.restauranteID = restauranteID;
            this.consultar = consultar;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!consultar)
            {
                //validações
                if (String.IsNullOrEmpty(textBoxNome.Text.Trim()) || String.IsNullOrEmpty(textBoxCidade.Text.Trim()) || String.IsNullOrEmpty(textBoxRua.Text.Trim()) || String.IsNullOrEmpty(textBoxPais.Text.Trim()) || String.IsNullOrEmpty(textBoxCodPostal.Text.Trim()) || String.IsNullOrEmpty(textBoxTelemovel.Text.Trim()) || String.IsNullOrEmpty(textBoxSalario.Text.Trim()) || String.IsNullOrEmpty(textBoxPosicao.Text.Trim()))
                {
                    MessageBox.Show("Tem de preencher todos os campos!");
                    return;
                }
                if (textBoxTelemovel.Text.Length != 9)
                {
                    MessageBox.Show("O telemovel tem de ter 9 digitos!");
                    return;
                }
                if (!Decimal.TryParse(textBoxSalario.Text, out var n))
                {
                    MessageBox.Show("O Salario tem de ser um numero decimal");
                    return;
                }
                for (int i = 0; i < 9; i++)
                {
                    if (!Char.IsDigit(textBoxTelemovel.Text[i]))
                    {
                        MessageBox.Show("Formato invalido! O telemovel tem de ser numerico!");
                        return;
                    }
                    
                }

                if (textBoxCodPostal.Text.Length != 8)
                {
                    MessageBox.Show("O código postal tem de ter 8 digitos!");
                    return;
                }
                else
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (i == 4)
                        {
                            if (textBoxCodPostal.Text[i] != '-')
                            {
                                MessageBox.Show("Formato invalido! Tem de ser xxxx-xxx !");
                                return;
                            }
                        }
                        else
                        {
                            if (!Char.IsDigit(textBoxCodPostal.Text[i]))
                            {
                                MessageBox.Show("Formato invalido! Tem de ser numerico 1234-123 !");
                                return;
                            }
                        }
                    }
                }
                //os dados que foram inseridos nas textBox são guardados
                Morada novaMorada = new Morada();
                novaMorada.Cidade = textBoxCidade.Text.Trim();
                novaMorada.Pais = textBoxPais.Text.Trim();
                novaMorada.CodPostal = textBoxCodPostal.Text.Trim();
                novaMorada.Rua = textBoxRua.Text.Trim();

                this.nome = textBoxNome.Text.Trim();
                this.telemovel = textBoxTelemovel.Text.Trim();
                this.posicao = textBoxPosicao.Text.Trim();
                this.restauranteID = (comboBoxRestaurante.SelectedItem as Restaurante).Id;
                this.salario = Convert.ToDecimal(textBoxSalario.Text);
                this.morada = novaMorada;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Trabalhador inserido com sucesso!");
            }
            
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddTrabalhadores_Load(object sender, EventArgs e)
        {
            //quando é aberto apenas para consulta dá disable nas textBox
            if (consultar)
            {
                textBoxNome.Enabled = false;
                textBoxRua.Enabled = false;
                textBoxCidade.Enabled = false;
                textBoxCodPostal.Enabled = false;
                textBoxPais.Enabled = false;
                comboBoxRestaurante.Enabled = false;
                textBoxTelemovel.Enabled = false;
                textBoxSalario.Enabled = false;
                textBoxPosicao.Enabled = false;
            }
            restGestContainer = new RestGestContainer();
            comboBoxRestaurante.DataSource = restGestContainer.Restaurantes.ToList();

            if (this.nome != null)
            {
                textBoxNome.Text = this.nome;
            }
            if (this.morada != null)
            {
                textBoxRua.Text = this.morada.Rua;
                textBoxCidade.Text = this.morada.Cidade;
                textBoxCodPostal.Text = this.morada.CodPostal;
                textBoxPais.Text = this.morada.Pais;
            }
            if (this.telemovel != null)
            {
                textBoxTelemovel.Text = this.telemovel;
            }
            if (this.salario != 0)
            {
                textBoxSalario.Text = this.salario + "";
            }
            if (this.posicao != null)
            {
                textBoxPosicao.Text = this.posicao;
            }
            if (this.restauranteID != 0)
            {
                comboBoxRestaurante.SelectedIndex = this.restauranteID;
            }
            
        }
    }
}
