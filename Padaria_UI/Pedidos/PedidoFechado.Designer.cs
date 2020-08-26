namespace Padaria_UI
{
    partial class PedidoFechado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoFechado));
            this.dgvPedidoFechados = new System.Windows.Forms.DataGridView();
            this.gridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvPedidoComFiltro = new System.Windows.Forms.DataGridView();
            this.gridIdPedidoFiltrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataFim = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorSolido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.itensDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MetodoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoFechados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoComFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidoFechados
            // 
            this.dgvPedidoFechados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvPedidoFechados.AutoGenerateColumns = false;
            this.dgvPedidoFechados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoFechados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridId,
            this.gridNome,
            this.gridTelefone,
            this.gridData,
            this.MetodoPagamento});
            this.dgvPedidoFechados.DataSource = this.pedidoDTOBindingSource1;
            this.dgvPedidoFechados.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidoFechados.Name = "dgvPedidoFechados";
            this.dgvPedidoFechados.Size = new System.Drawing.Size(516, 257);
            this.dgvPedidoFechados.TabIndex = 0;
            this.dgvPedidoFechados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_No_dgvPedido);
            // 
            // gridId
            // 
            this.gridId.DataPropertyName = "IdPedido";
            this.gridId.Frozen = true;
            this.gridId.HeaderText = "IdPedido";
            this.gridId.Name = "gridId";
            this.gridId.Width = 50;
            // 
            // gridNome
            // 
            this.gridNome.DataPropertyName = "NomeCliente";
            this.gridNome.HeaderText = "NomeCliente";
            this.gridNome.Name = "gridNome";
            // 
            // gridTelefone
            // 
            this.gridTelefone.DataPropertyName = "Telefone";
            this.gridTelefone.HeaderText = "Telefone";
            this.gridTelefone.Name = "gridTelefone";
            // 
            // gridData
            // 
            this.gridData.DataPropertyName = "DataAbertura";
            this.gridData.HeaderText = "DataAbertura";
            this.gridData.Name = "gridData";
            // 
            // pedidoDTOBindingSource
            // 
            this.pedidoDTOBindingSource.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.dgvPedidoComFiltro);
            this.panel1.Controls.Add(this.txtDataFim);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtValorSolido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(516, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 371);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Consultar vendas por nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(109, 20);
            this.txtNome.TabIndex = 1;
            // 
            // dgvPedidoComFiltro
            // 
            this.dgvPedidoComFiltro.AutoGenerateColumns = false;
            this.dgvPedidoComFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoComFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridIdPedidoFiltrado,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.dataAberturaDataGridViewTextBoxColumn});
            this.dgvPedidoComFiltro.DataSource = this.pedidoDTOBindingSource;
            this.dgvPedidoComFiltro.Location = new System.Drawing.Point(0, 101);
            this.dgvPedidoComFiltro.Name = "dgvPedidoComFiltro";
            this.dgvPedidoComFiltro.Size = new System.Drawing.Size(414, 219);
            this.dgvPedidoComFiltro.TabIndex = 9;
            this.dgvPedidoComFiltro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_No_dgvPedidoBuscado);
            // 
            // gridIdPedidoFiltrado
            // 
            this.gridIdPedidoFiltrado.DataPropertyName = "IdPedido";
            this.gridIdPedidoFiltrado.Frozen = true;
            this.gridIdPedidoFiltrado.HeaderText = "IdPedido";
            this.gridIdPedidoFiltrado.Name = "gridIdPedidoFiltrado";
            this.gridIdPedidoFiltrado.Width = 50;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // dataAberturaDataGridViewTextBoxColumn
            // 
            this.dataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.HeaderText = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.Name = "dataAberturaDataGridViewTextBoxColumn";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Location = new System.Drawing.Point(223, 73);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(87, 20);
            this.txtDataFim.TabIndex = 3;
            this.txtDataFim.Click += new System.EventHandler(this.Click_No_TextBox);
            this.txtDataFim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bloquear_Caracteres);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Até:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "De:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(223, 42);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(87, 20);
            this.txtData.TabIndex = 2;
            this.txtData.Click += new System.EventHandler(this.Click_No_TextBox);
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bloquear_Caracteres);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Bruto";
            // 
            // txtValorSolido
            // 
            this.txtValorSolido.Location = new System.Drawing.Point(18, 339);
            this.txtValorSolido.Name = "txtValorSolido";
            this.txtValorSolido.Size = new System.Drawing.Size(100, 20);
            this.txtValorSolido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar vendas por data";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(327, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 51);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn1,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.precoProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvItens.DataSource = this.itensDTOBindingSource;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItens.Location = new System.Drawing.Point(0, 252);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(516, 119);
            this.dgvItens.TabIndex = 2;
            // 
            // itensDTOBindingSource
            // 
            this.itensDTOBindingSource.DataSource = typeof(Padaria_DTO.Itens_DTO);
            // 
            // pedidoDTOBindingSource1
            // 
            this.pedidoDTOBindingSource1.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // MetodoPagamento
            // 
            this.MetodoPagamento.DataPropertyName = "MetodoPagamento";
            this.MetodoPagamento.HeaderText = "MetodoPagamento";
            this.MetodoPagamento.Name = "MetodoPagamento";
            // 
            // idPedidoDataGridViewTextBoxColumn1
            // 
            this.idPedidoDataGridViewTextBoxColumn1.DataPropertyName = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn1.Frozen = true;
            this.idPedidoDataGridViewTextBoxColumn1.HeaderText = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn1.Name = "idPedidoDataGridViewTextBoxColumn1";
            this.idPedidoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idPedidoDataGridViewTextBoxColumn1.Width = 55;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Frozen = true;
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 150;
            // 
            // precoProdutoDataGridViewTextBoxColumn
            // 
            this.precoProdutoDataGridViewTextBoxColumn.DataPropertyName = "PrecoProduto";
            this.precoProdutoDataGridViewTextBoxColumn.Frozen = true;
            this.precoProdutoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoProdutoDataGridViewTextBoxColumn.Name = "precoProdutoDataGridViewTextBoxColumn";
            this.precoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoProdutoDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Frozen = true;
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.Frozen = true;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 80;
            // 
            // PedidoFechado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 371);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPedidoFechados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidoFechado";
            this.Text = "PedidoFechado";
            this.Load += new System.EventHandler(this.PedidoFechado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoFechados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoComFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidoFechados;
        private System.Windows.Forms.BindingSource pedidoDTOBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorSolido;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataFim;
        private System.Windows.Forms.DataGridView dgvPedidoComFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridData;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.BindingSource itensDTOBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridIdPedidoFiltrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodoPagamento;
        private System.Windows.Forms.BindingSource pedidoDTOBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}