using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioMiniERP.Classes;

namespace DesafioMiniERP
{
    public partial class FormProdutos : Form
    {
        Thread thread;
        public FormProdutos()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            thread = new Thread(formMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void formMenu(object? obj)
        {
            Application.Run(new FormSelecionarDados());
        }

        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();
            dataTable = banco.executaConsulta("select * from produtos");
            dataGridViewProdutos.DataSource = dataTable;
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.nome = textBoxNomeProduto.Text;
            produtos.valor = float.Parse(textBoxValorProduto.Text);
            produtos.peso = float.Parse(textBoxPesoProduto.Text);
            produtos.idFornecedor = int.Parse(textBoxIDFornecedor.Text);
            if (produtos.Salvar())
            {
                MessageBox.Show("Produto salvo com sucesso!", "Atenção!");
                textBoxValorProduto.Clear();
                textBoxPesoProduto.Clear();
                textBoxIDFornecedor.Clear();
                textBoxNomeProduto.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao inserir o produto.", "Atenção!");
            }
        }
    }
}
