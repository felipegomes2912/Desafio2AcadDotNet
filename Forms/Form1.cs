using System.Threading;

namespace DesafioMiniERP
{
    public partial class FormSelecionarDados : Form
    {
        Thread thread;
        public FormSelecionarDados()
        {
            InitializeComponent();
        }

        private void btnAbrirProduto_Click(object sender, EventArgs e)
        {
            thread = new Thread(form2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void form2(object? obj)
        {
            Application.Run(new FormProdutos());
        }

        private void btnAbrirFornecedores_Click(object sender, EventArgs e)
        {
            thread = new Thread(form3);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void form3(object? obj)
        {
            Application.Run(new FormFornecedores());
        }

        private void btnAbrirClientes_Click(object sender, EventArgs e)
        {
            thread = new Thread(form4);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void form4(object? obj)
        {
            Application.Run(new FormClientes());
        }

        private void btnAbrirNotas_Click(object sender, EventArgs e)
        {
            thread = new Thread(form5);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void form5(object? obj)
        {
            Application.Run(new FormNotas());
        }
    }
}