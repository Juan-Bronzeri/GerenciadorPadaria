namespace Padaria_UI
{
    partial class Vender_Produto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender_Produto));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome_Produto = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.gridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbprodutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNome_Produto_Adicionar = new System.Windows.Forms.TextBox();
            this.cmbQuantidade = new System.Windows.Forms.ComboBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.itensDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbpedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(283, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.Click_btnBuscar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Produto";
            // 
            // txtNome_Produto
            // 
            this.txtNome_Produto.Location = new System.Drawing.Point(122, 82);
            this.txtNome_Produto.Name = "txtNome_Produto";
            this.txtNome_Produto.Size = new System.Drawing.Size(154, 20);
            this.txtNome_Produto.TabIndex = 3;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridId,
            this.gridNomeProduto,
            this.gridPrecoProduto});
            this.dgvProdutos.DataSource = this.produtoDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Location = new System.Drawing.Point(15, 111);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.Size = new System.Drawing.Size(363, 327);
            this.dgvProdutos.TabIndex = 4;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_No_DgvProduto);
            // 
            // gridId
            // 
            this.gridId.DataPropertyName = "Id";
            this.gridId.HeaderText = "Id";
            this.gridId.Name = "gridId";
            this.gridId.ReadOnly = true;
            // 
            // gridNomeProduto
            // 
            this.gridNomeProduto.DataPropertyName = "NomeProduto";
            this.gridNomeProduto.HeaderText = "NomeProduto";
            this.gridNomeProduto.Name = "gridNomeProduto";
            this.gridNomeProduto.ReadOnly = true;
            // 
            // gridPrecoProduto
            // 
            this.gridPrecoProduto.DataPropertyName = "Preco";
            this.gridPrecoProduto.HeaderText = "Preco";
            this.gridPrecoProduto.Name = "gridPrecoProduto";
            this.gridPrecoProduto.ReadOnly = true;
            // 
            // produtoDTOBindingSource
            // 
            this.produtoDTOBindingSource.DataSource = typeof(Padaria_DTO.Produto_DTO);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(675, 82);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.Click_btnAdicionar);
            // 
            // txtNome_Produto_Adicionar
            // 
            this.txtNome_Produto_Adicionar.Location = new System.Drawing.Point(508, 85);
            this.txtNome_Produto_Adicionar.Name = "txtNome_Produto_Adicionar";
            this.txtNome_Produto_Adicionar.Size = new System.Drawing.Size(114, 20);
            this.txtNome_Produto_Adicionar.TabIndex = 6;
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbQuantidade.Location = new System.Drawing.Point(628, 84);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(41, 21);
            this.cmbQuantidade.TabIndex = 7;
            this.cmbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbQuantidade_KeyPress);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridIdProduto,
            this.gridProduto,
            this.PrecoProduto,
            this.gridQuantidade,
            this.gridObservacao,
            this.Total});
            this.dgvItens.DataSource = this.itensDTOBindingSource;
            this.dgvItens.Location = new System.Drawing.Point(403, 167);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(505, 271);
            this.dgvItens.TabIndex = 8;
            this.dgvItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_No_DgvItem);
            // 
            // itensDTOBindingSource
            // 
            this.itensDTOBindingSource.DataSource = typeof(Padaria_DTO.Itens_DTO);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(471, 114);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(278, 49);
            this.txtObservacao.TabIndex = 9;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(755, 113);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(70, 50);
            this.btnConcluir.TabIndex = 10;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.Click_btnConcluir);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(756, 82);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(69, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.Click_btnExcluir);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(471, 85);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(31, 20);
            this.txtIdProduto.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id do Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Observação";
            // 
            // gridIdProduto
            // 
            this.gridIdProduto.DataPropertyName = "IdProduto";
            this.gridIdProduto.Frozen = true;
            this.gridIdProduto.HeaderText = "Id";
            this.gridIdProduto.Name = "gridIdProduto";
            this.gridIdProduto.ReadOnly = true;
            this.gridIdProduto.Width = 40;
            // 
            // gridProduto
            // 
            this.gridProduto.DataPropertyName = "NomeProduto";
            this.gridProduto.HeaderText = "Nome";
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.ReadOnly = true;
            this.gridProduto.Width = 75;
            // 
            // PrecoProduto
            // 
            this.PrecoProduto.DataPropertyName = "PrecoProduto";
            this.PrecoProduto.HeaderText = "Preco";
            this.PrecoProduto.Name = "PrecoProduto";
            this.PrecoProduto.ReadOnly = true;
            this.PrecoProduto.Width = 65;
            // 
            // gridQuantidade
            // 
            this.gridQuantidade.DataPropertyName = "Quantidade";
            this.gridQuantidade.HeaderText = "Qnt";
            this.gridQuantidade.Name = "gridQuantidade";
            this.gridQuantidade.ReadOnly = true;
            this.gridQuantidade.Width = 40;
            // 
            // gridObservacao
            // 
            this.gridObservacao.DataPropertyName = "Observacao";
            this.gridObservacao.HeaderText = "Observacao";
            this.gridObservacao.Name = "gridObservacao";
            this.gridObservacao.ReadOnly = true;
            this.gridObservacao.Width = 120;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(843, 130);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(65, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(850, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            // 
            // Vender_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.cmbQuantidade);
            this.Controls.Add(this.txtNome_Produto_Adicionar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtNome_Produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vender_Produto";
            this.Text = "Vender_Cliente";
            this.Load += new System.EventHandler(this.Vender_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome_Produto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.BindingSource tbprodutoBindingSource;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNome_Produto_Adicionar;
        private System.Windows.Forms.ComboBox cmbQuantidade;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.BindingSource tbprodutoBindingSource1;
        private System.Windows.Forms.BindingSource tbpedidoBindingSource;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.BindingSource tbpedidoBindingSource1;
        private System.Windows.Forms.BindingSource itensDTOBindingSource;
        private System.Windows.Forms.BindingSource produtoDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPrecoProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
    }
}