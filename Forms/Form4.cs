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
    public partial class FormClientes : Form
    {
        Thread thread;
        public FormClientes()
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

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();
            dataTable = banco.executaConsulta("select * from clientes");
            dataGridViewCliente.DataSource = dataTable;
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.nomeCli = textBoxNomeCliente.Text;
            clientes.cpf = textBoxCPF.Text;

            if (clientes.Salvar())
            {
                MessageBox.Show("Cliente salvo com sucesso!", "Atenção!");
                textBoxNomeCliente.Clear();
                textBoxCPF.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao inserir o cliente.", "Atenção!");
            }
        }
    }
}
