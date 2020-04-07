using System;
using System.IO;
using System.Windows.Forms;
using Biblioteca;

namespace Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsFormularioInvalido())
            {
                MessageBox.Show("É necessário preencher todos campos obrigatórios.");
            }
            else
            {
                try
                {
                    new FerramentaService().Adicionar(new Ferramenta(txtDescricao.Text, txtTipo.Text, txtMarca.Text, decimal.Parse(txtPreco.Text)));
                    LimparCampos();
                    MessageBox.Show("Ferramenta adicionada com sucesso.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("O preço informado é inválido.");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            dgvFerramentas.DataSource = null;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvFerramentas.DataSource = new FerramentaService().Listar();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtTipo.Clear();
            txtMarca.Clear();
            txtPreco.Clear();
            txtDescricao.Focus();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\Marcelo\Desktop\ralatorio-ferramenta" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".txt");
            foreach (var ferramenta in new FerramentaService().Listar())
            {
                writer.WriteLine(ferramenta + "\n-----------------------------");
            }
            writer.Close();
            MessageBox.Show("Relatório gerado com sucesso.");
        }

        private bool IsFormularioInvalido()
        {
            return string.IsNullOrWhiteSpace(txtDescricao.Text)
                || string.IsNullOrWhiteSpace(txtTipo.Text)
                || string.IsNullOrWhiteSpace(txtMarca.Text)
                || string.IsNullOrWhiteSpace(txtPreco.Text);
        }

    }
}
