﻿using System;
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
        public Restaurante restaurante { get; set; }
        public decimal salario { get; set; }
        public string posicao { get; set; }
        public static RestGestContainer restGestContainer;
        public FormAddTrabalhadores(string nome = null, Morada morada = null, string telemovel = null, string posicao = null, decimal salario = 0, Restaurante restaurante = null)
        {
            InitializeComponent();
            this.nome = nome;
            this.telemovel = telemovel;
            this.morada = morada;
            this.posicao = posicao;
            this.salario = salario;
            this.restaurante = restaurante;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNome.Text.Trim()) || String.IsNullOrEmpty(textBoxCidade.Text.Trim()) || String.IsNullOrEmpty(textBoxRua.Text.Trim()) || String.IsNullOrEmpty(textBoxPais.Text.Trim()) || String.IsNullOrEmpty(textBoxCodPostal.Text.Trim()) || String.IsNullOrEmpty(textBoxTelemovel.Text.Trim()) || String.IsNullOrEmpty(textBoxSalario.Text.Trim()) || String.IsNullOrEmpty(textBoxPosicao.Text.Trim()))
            {
                MessageBox.Show("Tem de preencher todos os campos!");
                return;
            }

            Morada novaMorada = new Morada();
            novaMorada.Cidade = textBoxCidade.Text.Trim();
            novaMorada.Pais = textBoxPais.Text.Trim();
            novaMorada.CodPostal = textBoxCodPostal.Text.Trim();
            novaMorada.Rua = textBoxRua.Text.Trim();

            this.nome = textBoxNome.Text.Trim();
            this.telemovel = textBoxTelemovel.Text.Trim();
            this.posicao = textBoxPosicao.Text.Trim();
            this.restaurante = comboBoxRestaurante.SelectedItem as Restaurante;
            this.salario = Convert.ToDecimal(textBoxSalario.Text);
            this.morada = novaMorada;
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Trabalhador inserido com sucesso!");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddTrabalhadores_Load(object sender, EventArgs e)
        {
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
        }
    }
}