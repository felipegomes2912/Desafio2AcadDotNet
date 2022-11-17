namespace DesafioMiniERP
{
    partial class FormFornecedores
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeFornecedor = new System.Windows.Forms.TextBox();
            this.textBoxCNPJ = new System.Windows.Forms.TextBox();
            this.btnSalvarFornecedores = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnConsultaFornecedor = new System.Windows.Forms.Button();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ do forncedor";
            // 
            // textBoxNomeFornecedor
            // 
            this.textBoxNomeFornecedor.Location = new System.Drawing.Point(149, 9);
            this.textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            this.textBoxNomeFornecedor.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomeFornecedor.TabIndex = 3;
            // 
            // textBoxCNPJ
            // 
            this.textBoxCNPJ.Location = new System.Drawing.Point(149, 43);
            this.textBoxCNPJ.Name = "textBoxCNPJ";
            this.textBoxCNPJ.Size = new System.Drawing.Size(100, 23);
            this.textBoxCNPJ.TabIndex = 4;
            // 
            // btnSalvarFornecedores
            // 
            this.btnSalvarFornecedores.Location = new System.Drawing.Point(12, 87);
            this.btnSalvarFornecedores.Name = "btnSalvarFornecedores";
            this.btnSalvarFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFornecedores.TabIndex = 5;
            this.btnSalvarFornecedores.Text = "Salvar";
            this.btnSalvarFornecedores.UseVisualStyleBackColor = true;
            this.btnSalvarFornecedores.Click += new System.EventHandler(this.btnSalvarFornecedores_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(93, 87);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnConsultaFornecedor
            // 
            this.btnConsultaFornecedor.Location = new System.Drawing.Point(174, 87);
            this.btnConsultaFornecedor.Name = "btnConsultaFornecedor";
            this.btnConsultaFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaFornecedor.TabIndex = 7;
            this.btnConsultaFornecedor.Text = "Consultar";
            this.btnConsultaFornecedor.UseVisualStyleBackColor = true;
            this.btnConsultaFornecedor.Click += new System.EventHandler(this.btnConsultaFornecedor_Click);
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.AllowUserToAddRows = false;
            this.dataGridViewFornecedor.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.RowTemplate.Height = 25;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(237, 292);
            this.dataGridViewFornecedor.TabIndex = 8;
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 440);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Controls.Add(this.btnConsultaFornecedor);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSalvarFornecedores);
            this.Controls.Add(this.textBoxCNPJ);
            this.Controls.Add(this.textBoxNomeFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormFornecedores";
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox textBoxNomeFornecedor;
        private TextBox textBoxCNPJ;
        private Button btnSalvarFornecedores;
        private Button btnMenu;
        private Button btnConsultaFornecedor;
        private DataGridView dataGridViewFornecedor;
    }
}