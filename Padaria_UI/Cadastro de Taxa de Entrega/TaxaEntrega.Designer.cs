namespace Padaria_UI
{
    partial class TaxaEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxaEntrega));
            this.dgvTaxa = new System.Windows.Forms.DataGridView();
            this.gridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomedoBairro = new System.Windows.Forms.TextBox();
            this.txtValorDaTaxa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaxa
            // 
            this.dgvTaxa.AutoGenerateColumns = false;
            this.dgvTaxa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridId,
            this.gridNome,
            this.gridValor});
            this.dgvTaxa.DataSource = this.taxaDTOBindingSource;
            this.dgvTaxa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTaxa.Location = new System.Drawing.Point(0, 264);
            this.dgvTaxa.Name = "dgvTaxa";
            this.dgvTaxa.Size = new System.Drawing.Size(343, 150);
            this.dgvTaxa.TabIndex = 0;
            this.dgvTaxa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_no_dgvTaxa);
            // 
            // gridId
            // 
            this.gridId.DataPropertyName = "Id";
            this.gridId.HeaderText = "Id";
            this.gridId.Name = "gridId";
            // 
            // gridNome
            // 
            this.gridNome.DataPropertyName = "NomeBairro";
            this.gridNome.HeaderText = "NomeBairro";
            this.gridNome.Name = "gridNome";
            // 
            // gridValor
            // 
            this.gridValor.DataPropertyName = "Valor";
            this.gridValor.HeaderText = "Valor";
            this.gridValor.Name = "gridValor";
            // 
            // taxaDTOBindingSource
            // 
            this.taxaDTOBindingSource.DataSource = typeof(Padaria_DTO.Taxa_DTO);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(33, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Click_btnAdicionar);
            // 
            // txtNomedoBairro
            // 
            this.txtNomedoBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomedoBairro.Location = new System.Drawing.Point(48, 170);
            this.txtNomedoBairro.Name = "txtNomedoBairro";
            this.txtNomedoBairro.Size = new System.Drawing.Size(100, 20);
            this.txtNomedoBairro.TabIndex = 4;
            // 
            // txtValorDaTaxa
            // 
            this.txtValorDaTaxa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDaTaxa.Location = new System.Drawing.Point(192, 170);
            this.txtValorDaTaxa.Name = "txtValorDaTaxa";
            this.txtValorDaTaxa.Size = new System.Drawing.Size(100, 20);
            this.txtValorDaTaxa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Bairro";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor da Taxa";
            // 
            // btnExclui
            // 
            this.btnExclui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExclui.Location = new System.Drawing.Point(233, 62);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 9;
            this.btnExclui.Text = "Excluir";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.Click_btnExcluir);
            // 
            // btnEdita
            // 
            this.btnEdita.Location = new System.Drawing.Point(133, 62);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(75, 23);
            this.btnEdita.TabIndex = 10;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            this.btnEdita.Click += new System.EventHandler(this.Click_btnEdita);
            // 
            // TaxaEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 414);
            this.Controls.Add(this.btnEdita);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorDaTaxa);
            this.Controls.Add(this.txtNomedoBairro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTaxa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaxaEntrega";
            this.Text = "TaxaEntrega";
            this.Load += new System.EventHandler(this.TaxaEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxaDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaxa;
        private System.Windows.Forms.BindingSource taxaDTOBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomedoBairro;
        private System.Windows.Forms.TextBox txtValorDaTaxa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridValor;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnEdita;
    }
}