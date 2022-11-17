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
    public partial class FormFornecedores : Form
    {
        Thread thread;
        public FormFornecedores()
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

        private void btnConsultaFornecedor_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();
            dataTable = banco.executaConsulta("select * from fornecedores");
            dataGridViewFornecedor.DataSource = dataTable;
        }

        private void btnSalvarFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.nomeFornecedor = textBoxNomeFornecedor.Text;
            fornecedores.cnpj = textBoxCNPJ.Text;
            
            if (fornecedores.Salvar())
            {
                MessageBox.Show("Fornecedor salvo com sucesso!", "Atenção!");
                textBoxNomeFornecedor.Clear();
                textBoxCNPJ.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao inserir o fornecedor.", "Atenção!");
            }
        }
    }
}
