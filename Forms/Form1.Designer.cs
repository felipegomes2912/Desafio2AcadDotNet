namespace DesafioMiniERP
{
    partial class FormSelecionarDados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirProduto = new System.Windows.Forms.Button();
            this.btnAbrirFornecedores = new System.Windows.Forms.Button();
            this.btnAbrirClientes = new System.Windows.Forms.Button();
            this.btnAbrirNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o campo a ser preenchido:";
            // 
            // btnAbrirProduto
            // 
            this.btnAbrirProduto.Location = new System.Drawing.Point(91, 45);
            this.btnAbrirProduto.Name = "btnAbrirProduto";
            this.btnAbrirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirProduto.TabIndex = 1;
            this.btnAbrirProduto.Text = "Produto";
            this.btnAbrirProduto.UseVisualStyleBackColor = true;
            this.btnAbrirProduto.Click += new System.EventHandler(this.btnAbrirProduto_Click);
            // 
            // btnAbrirFornecedores
            // 
            this.btnAbrirFornecedores.Location = new System.Drawing.Point(91, 74);
            this.btnAbrirFornecedores.Name = "btnAbrirFornecedores";
            this.btnAbrirFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirFornecedores.TabIndex = 2;
            this.btnAbrirFornecedores.Text = "Fornecedores";
            this.btnAbrirFornecedores.UseVisualStyleBackColor = true;
            this.btnAbrirFornecedores.Click += new System.EventHandler(this.btnAbrirFornecedores_Click);
            // 
            // btnAbrirClientes
            // 
            this.btnAbrirClientes.Location = new System.Drawing.Point(91, 103);
            this.btnAbrirClientes.Name = "btnAbrirClientes";
            this.btnAbrirClientes.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirClientes.TabIndex = 3;
            this.btnAbrirClientes.Text = "Clientes";
            this.btnAbrirClientes.UseVisualStyleBackColor = true;
            this.btnAbrirClientes.Click += new System.EventHandler(this.btnAbrirClientes_Click);
            // 
            // btnAbrirNotas
            // 
            this.btnAbrirNotas.Location = new System.Drawing.Point(91, 132);
            this.btnAbrirNotas.Name = "btnAbrirNotas";
            this.btnAbrirNotas.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirNotas.TabIndex = 4;
            this.btnAbrirNotas.Text = "Notas";
            this.btnAbrirNotas.UseVisualStyleBackColor = true;
            this.btnAbrirNotas.Click += new System.EventHandler(this.btnAbrirNotas_Click);
            // 
            // FormSelecionarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 175);
            this.Controls.Add(this.btnAbrirNotas);
            this.Controls.Add(this.btnAbrirClientes);
            this.Controls.Add(this.btnAbrirFornecedores);
            this.Controls.Add(this.btnAbrirProduto);
            this.Controls.Add(this.label1);
            this.Name = "FormSelecionarDados";
            this.Text = "Selecionar dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAbrirProduto;
        private Button btnAbrirFornecedores;
        private Button btnAbrirClientes;
        private Button btnAbrirNotas;
    }
}