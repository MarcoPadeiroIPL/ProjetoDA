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
    public partial class FormAddItem : Form
    {
        public string nome { get; set; }
        public string ingredientes { get; set; }
        public string imagem { get; set; }
        public Categoria categoria { get; set; }
        public decimal preco { get; set; }
        public bool ativo { get; set; }
        public IEnumerable<Categoria> categorias;
        public FormAddItem(IEnumerable<Categoria> categorias = null, string nome = null, string ingredientes = null, Categoria categoria = null, decimal preco = 0, bool ativo = false, string image = null)
        {
            InitializeComponent();
            this.categorias = categorias;
            this.categoria = categoria;
            this.nome = nome;
            this.ingredientes = ingredientes;
            this.imagem = image;
            this.preco = preco;
            this.ativo = ativo;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNome.Text.Trim()) || String.IsNullOrEmpty(textBoxIngredientes.Text.Trim()) || String.IsNullOrEmpty(textBoxPreço.Text.Trim()) || String.IsNullOrEmpty(imagem))
            {
                MessageBox.Show("Tem de preencher todos os campos!");
                return;
            }
            if (!Decimal.TryParse(textBoxPreço.Text, out var n))
            {
                MessageBox.Show("O preço tem de ser um numero decimal");
                return;
            }
            this.nome = textBoxNome.Text.Trim();
            this.ingredientes = textBoxIngredientes.Text.Trim();
            this.categoria = comboBoxCategoria.SelectedItem as Categoria;
            this.preco = Convert.ToDecimal(textBoxPreço.Text);
            this.ativo = radioButtonSim.Checked;
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Item inserido com sucesso!");
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            if(this.categorias != null)
            {
                comboBoxCategoria.DataSource = categorias.ToList();
            }
            if (this.nome != null)
            {
                textBoxNome.Text = this.nome;
            }
            if (this.ingredientes != null)
            {
                textBoxIngredientes.Text = this.ingredientes;
            }
            if(File.Exists(this.imagem))
            {
                pictureBox1.Image = new Bitmap(imagem);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            radioButtonSim.Checked = this.ativo;
            radioButtonNao.Checked = !this.ativo;
            textBoxPreço.Text = this.preco + "";
            if (this.categoria != null)
            {
                comboBoxCategoria.Text = this.categoria.ToString();
            }

        }

        private void buttonAdicionarImagem_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Imagens";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        this.imagem = path;
                        pictureBox1.Image = new Bitmap(path);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }
    }
}
