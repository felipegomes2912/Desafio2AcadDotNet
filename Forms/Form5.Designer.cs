namespace DesafioMiniERP
{
    partial class FormNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewNotas = new System.Windows.Forms.DataGridView();
            this.btnConsultaNota = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnSalvarNota = new System.Windows.Forms.Button();
            this.textBoxIDProduto = new System.Windows.Forms.TextBox();
            this.textBoxIDCliente = new System.Windows.Forms.TextBox();
            this.textBoxDtEmissao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotas
            // 
            this.dataGridViewNotas.AllowUserToAddRows = false;
            this.dataGridViewNotas.AllowUserToDeleteRows = false;
            this.dataGridViewNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotas.Location = new System.Drawing.Point(12, 173);
            this.dataGridViewNotas.Name = "dataGridViewNotas";
            this.dataGridViewNotas.ReadOnly = true;
            this.dataGridViewNotas.RowTemplate.Height = 25;
            this.dataGridViewNotas.Size = new System.Drawing.Size(237, 254);
            this.dataGridViewNotas.TabIndex = 19;
            // 
            // btnConsultaNota
            // 
            this.btnConsultaNota.Location = new System.Drawing.Point(174, 107);
            this.btnConsultaNota.Name = "btnConsultaNota";
            this.btnConsultaNota.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaNota.TabIndex = 18;
            this.btnConsultaNota.Text = "Consulta";
            this.btnConsultaNota.UseVisualStyleBackColor = true;
            this.btnConsultaNota.Click += new System.EventHandler(this.btnConsultaNota_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(93, 107);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.Location = new System.Drawing.Point(12, 107);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarNota.TabIndex = 16;
            this.btnSalvarNota.Text = "Salvar";
            this.btnSalvarNota.UseVisualStyleBackColor = true;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // textBoxIDProduto
            // 
            this.textBoxIDProduto.Location = new System.Drawing.Point(149, 68);
            this.textBoxIDProduto.Name = "textBoxIDProduto";
            this.textBoxIDProduto.Size = new System.Drawing.Size(100, 23);
            this.textBoxIDProduto.TabIndex = 15;
            // 
            // textBoxIDCliente
            // 
            this.textBoxIDCliente.Location = new System.Drawing.Point(149, 38);
            this.textBoxIDCliente.Name = "textBoxIDCliente";
            this.textBoxIDCliente.Size = new System.Drawing.Size(100, 23);
            this.textBoxIDCliente.TabIndex = 14;
            // 
            // textBoxDtEmissao
            // 
            this.textBoxDtEmissao.Location = new System.Drawing.Point(149, 9);
            this.textBoxDtEmissao.Name = "textBoxDtEmissao";
            this.textBoxDtEmissao.Size = new System.Drawing.Size(100, 23);
            this.textBoxDtEmissao.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID do cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data da emissão";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(12, 136);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 439);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dataGridViewNotas);
            this.Controls.Add(this.btnConsultaNota);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSalvarNota);
            this.Controls.Add(this.textBoxIDProduto);
            this.Controls.Add(this.textBoxIDCliente);
            this.Controls.Add(this.textBoxDtEmissao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNotas";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewNotas;
        private Button btnConsultaNota;
        private Button btnMenu;
        private Button btnSalvarNota;
        private TextBox textBoxIDProduto;
        private TextBox textBoxIDCliente;
        private TextBox textBoxDtEmissao;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnExportar;
    }
}