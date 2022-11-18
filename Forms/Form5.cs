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
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Environment;

namespace DesafioMiniERP
{
    public partial class FormNotas : Form
    {
        List<string> lista = new List<string>();
        string arquivoNotas = Path.Join(Environment.GetFolderPath(SpecialFolder.Desktop), "notas.pdf");
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotas.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "Notas.pdf";
                bool erro = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            erro = true;
                            MessageBox.Show("Erro ao exportar para PDF.\n" + ex.Message, "Atenção!");
                        }
                    }
                    if (!erro)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridViewNotas.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage= 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn coluna in dataGridViewNotas.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(coluna.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow verLinha in dataGridViewNotas.Rows)
                            {
                                foreach (DataGridViewCell dCell in verLinha.Cells)
                                {
                                    pTable.AddCell(dCell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Arquivo exportado com sucesso!", "Atenção!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao exportar arquivo.\n" + ex.Message, "Atenção!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arquivo não encontrado", "Atenção!");
                    }
                }
            }
        }
    }
}
