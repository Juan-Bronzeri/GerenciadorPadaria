namespace Padaria_UI
{
    partial class PedidoAberto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoAberto));
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorTaxa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidoDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidoDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidoDTOBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidoDTOBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidoDTOBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.listaPedidoDTOBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.taxaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridIdTaxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AutoGenerateColumns = false;
            this.dgvItem.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvItem.CausesValidation = false;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.precoProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.gridTotal});
            this.dgvItem.DataSource = this.itensDTOBindingSource;
            this.dgvItem.Location = new System.Drawing.Point(0, 0);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.Size = new System.Drawing.Size(544, 150);
            this.dgvItem.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFechar.Location = new System.Drawing.Point(741, 104);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 35);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar Conta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtId.Location = new System.Drawing.Point(741, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNome.Location = new System.Drawing.Point(741, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotal.Location = new System.Drawing.Point(602, 76);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(67, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor Total";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(582, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAtualizar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtValorTaxa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.dgvItem);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 151);
            this.panel2.TabIndex = 8;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(862, 35);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(92, 92);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número do Pedido";
            // 
            // txtValorTaxa
            // 
            this.txtValorTaxa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtValorTaxa.Location = new System.Drawing.Point(602, 35);
            this.txtValorTaxa.Name = "txtValorTaxa";
            this.txtValorTaxa.Size = new System.Drawing.Size(67, 20);
            this.txtValorTaxa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor Taxa";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditar.Location = new System.Drawing.Point(590, 104);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AutoGenerateColumns = false;
            this.dgvPedido.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvPedido.CausesValidation = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridIdPedido,
            this.gridIdTaxa,
            this.gridNome,
            this.telefoneDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroCasaDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.HorarioEntrega});
            this.dgvPedido.DataSource = this.pedidoDTOBindingSource;
            this.dgvPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedido.Location = new System.Drawing.Point(0, 0);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.Size = new System.Drawing.Size(966, 450);
            this.dgvPedido.TabIndex = 0;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_No_DgvPedido);
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoProdutoDataGridViewTextBoxColumn
            // 
            this.precoProdutoDataGridViewTextBoxColumn.DataPropertyName = "PrecoProduto";
            this.precoProdutoDataGridViewTextBoxColumn.HeaderText = "PrecoProduto";
            this.precoProdutoDataGridViewTextBoxColumn.Name = "precoProdutoDataGridViewTextBoxColumn";
            this.precoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridTotal
            // 
            this.gridTotal.DataPropertyName = "Total";
            this.gridTotal.HeaderText = "Total";
            this.gridTotal.Name = "gridTotal";
            this.gridTotal.ReadOnly = true;
            // 
            // itensDTOBindingSource
            // 
            this.itensDTOBindingSource.DataSource = typeof(Padaria_DTO.Itens_DTO);
            // 
            // pedidoDTOBindingSource
            // 
            this.pedidoDTOBindingSource.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // listaPedidoDTOBindingSource1
            // 
            this.listaPedidoDTOBindingSource1.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // listaPedidoDTOBindingSource
            // 
            this.listaPedidoDTOBindingSource.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // listaPedidoDTOBindingSource2
            // 
            this.listaPedidoDTOBindingSource2.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // listaPedidoDTOBindingSource6
            // 
            this.listaPedidoDTOBindingSource6.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // listaPedidoDTOBindingSource5
            // 
            this.listaPedidoDTOBindingSource5.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // listaPedidoDTOBindingSource3
            // 
            this.listaPedidoDTOBindingSource3.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // listaPedidoDTOBindingSource4
            // 
            this.listaPedidoDTOBindingSource4.DataSource = typeof(Padaria_DTO.Pedido_DTO);
            // 
            // taxaDTOBindingSource
            // 
            this.taxaDTOBindingSource.DataSource = typeof(Padaria_DTO.Taxa_DTO);
            // 
            // gridIdPedido
            // 
            this.gridIdPedido.DataPropertyName = "IdPedido";
            this.gridIdPedido.HeaderText = "IdPedido";
            this.gridIdPedido.Name = "gridIdPedido";
            this.gridIdPedido.ReadOnly = true;
            // 
            // gridIdTaxa
            // 
            this.gridIdTaxa.DataPropertyName = "IdTaxa";
            this.gridIdTaxa.HeaderText = "IdTaxa";
            this.gridIdTaxa.Name = "gridIdTaxa";
            this.gridIdTaxa.ReadOnly = true;
            // 
            // gridNome
            // 
            this.gridNome.DataPropertyName = "Nome";
            this.gridNome.HeaderText = "Nome";
            this.gridNome.Name = "gridNome";
            this.gridNome.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroCasaDataGridViewTextBoxColumn
            // 
            this.numeroCasaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCasa";
            this.numeroCasaDataGridViewTextBoxColumn.HeaderText = "NumeroCasa";
            this.numeroCasaDataGridViewTextBoxColumn.Name = "numeroCasaDataGridViewTextBoxColumn";
            this.numeroCasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HorarioEntrega
            // 
            this.HorarioEntrega.DataPropertyName = "HorarioEntrega";
            this.HorarioEntrega.HeaderText = "HorarioEntrega";
            this.HorarioEntrega.Name = "HorarioEntrega";
            this.HorarioEntrega.ReadOnly = true;
            // 
            // PedidoAberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidoAberto";
            this.Text = "PedidoAberto";
            this.Load += new System.EventHandler(this.PedidoAberto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidoDTOBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.BindingSource listaPedidoDTOBindingSource;
        private System.Windows.Forms.BindingSource itensDTOBindingSource;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource listaPedidoDTOBindingSource1;
        private System.Windows.Forms.BindingSource listaPedidoDTOBindingSource2;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.BindingSource listaPedidoDTOBindingSource3;
        private System.Windows.Forms.BindingSource listaPedidoDTOBindingSource5;
        private System.Windows.Forms.BindingSource listaPedidoDTOBindingSource4;
        private System.Windows.Forms.BindingSource taxaDTOBindingSource;
        private System.Windows.Forms.BindingSource listaPedidoDTOBindingSource6;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtValorTaxa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.BindingSource pedidoDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridIdTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioEntrega;
    }
}