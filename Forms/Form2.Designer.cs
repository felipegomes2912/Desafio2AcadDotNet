namespace DesafioMiniERP
{
    partial class FormProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.textBoxValorProduto = new System.Windows.Forms.TextBox();
            this.textBoxPesoProduto = new System.Windows.Forms.TextBox();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnConsultaProduto = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDFornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso do produto";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(177, 14);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomeProduto.TabIndex = 3;
            // 
            // textBoxValorProduto
            // 
            this.textBoxValorProduto.Location = new System.Drawing.Point(177, 43);
            this.textBoxValorProduto.Name = "textBoxValorProduto";
            this.textBoxValorProduto.Size = new System.Drawing.Size(100, 23);
            this.textBoxValorProduto.TabIndex = 4;
            // 
            // textBoxPesoProduto
            // 
            this.textBoxPesoProduto.Location = new System.Drawing.Point(177, 73);
            this.textBoxPesoProduto.Name = "textBoxPesoProduto";
            this.textBoxPesoProduto.Size = new System.Drawing.Size(100, 23);
            this.textBoxPesoProduto.TabIndex = 5;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(15, 146);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProduto.TabIndex = 7;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(111, 146);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.Location = new System.Drawing.Point(202, 146);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaProduto.TabIndex = 9;
            this.btnConsultaProduto.Text = "Consulta";
            this.btnConsultaProduto.UseVisualStyleBackColor = true;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(15, 192);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(265, 254);
            this.dataGridViewProdutos.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID do fornecedor do produto";
            // 
            // textBoxIDFornecedor
            // 
            this.textBoxIDFornecedor.Location = new System.Drawing.Point(177, 102);
            this.textBoxIDFornecedor.Name = "textBoxIDFornecedor";
            this.textBoxIDFornecedor.Size = new System.Drawing.Size(100, 23);
            this.textBoxIDFornecedor.TabIndex = 6;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 458);
            this.Controls.Add(this.textBoxIDFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btnConsultaProduto);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.textBoxPesoProduto);
            this.Controls.Add(this.textBoxValorProduto);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxValorProduto;
        private TextBox textBoxPesoProduto;
        private Button btnSalvarProduto;
        private Button btnMenu;
        private Button btnConsultaProduto;
        private DataGridView dataGridViewProdutos;
        private Label label4;
        private TextBox textBoxIDFornecedor;
    }
}