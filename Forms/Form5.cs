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
    public partial class FormNotas : Form
    {
        Thread thread;
        public FormNotas()
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

        private void btnConsultaNota_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            DataTable dataTable = new DataTable();
            dataTable = banco.executaConsulta("select * from notas");
            dataGridViewNotas.DataSource = dataTable;
        }

        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.data = textBoxDtEmissao.Text;
            notas.idCliente = int.Parse(textBoxIDCliente.Text);
            notas.idProd = int.Parse(textBoxIDProduto.Text);

            if (notas.Salvar())
            {
                MessageBox.Show("Nota salva com sucesso!", "Atenção!");
                textBoxIDCliente.Clear();
                textBoxIDProduto.Clear();
                textBoxDtEmissao.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao inserir a nota.", "Atenção!");
            }
        }
    }
}
