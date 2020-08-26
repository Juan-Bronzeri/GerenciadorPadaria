namespace Padaria_UI
{
    partial class MDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.pedidosAbertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosFechadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTaxaDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxaDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbPedidoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todosOsPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPedidoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosAbertosToolStripMenuItem,
            this.Cadastrar,
            this.Estoque,
            this.cadastroTaxaDeEntregaToolStripMenuItem,
            this.Sobre});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(721, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // pedidosAbertosToolStripMenuItem
            // 
            this.pedidosAbertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.pedidosFechadosToolStripMenuItem,
            this.todosOsPedidosToolStripMenuItem});
            this.pedidosAbertosToolStripMenuItem.Name = "pedidosAbertosToolStripMenuItem";
            this.pedidosAbertosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosAbertosToolStripMenuItem.Text = "Pedidos";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // pedidosFechadosToolStripMenuItem
            // 
            this.pedidosFechadosToolStripMenuItem.Name = "pedidosFechadosToolStripMenuItem";
            this.pedidosFechadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidosFechadosToolStripMenuItem.Text = "Pedidos Fechados";
            this.pedidosFechadosToolStripMenuItem.Click += new System.EventHandler(this.pedidosFechadosToolStripMenuItem_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.Cadastrar.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(106, 20);
            this.Cadastrar.Text = "&Cadastro Cliente";
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // Estoque
            // 
            this.Estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem});
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(112, 20);
            this.Estoque.Text = "&Cadastro Produto";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.entradaToolStripMenuItem.Text = "Produto";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // cadastroTaxaDeEntregaToolStripMenuItem
            // 
            this.cadastroTaxaDeEntregaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taxaDeEntregaToolStripMenuItem});
            this.cadastroTaxaDeEntregaToolStripMenuItem.Name = "cadastroTaxaDeEntregaToolStripMenuItem";
            this.cadastroTaxaDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.cadastroTaxaDeEntregaToolStripMenuItem.Text = "Cadastro Taxa de Entrega";
            // 
            // taxaDeEntregaToolStripMenuItem
            // 
            this.taxaDeEntregaToolStripMenuItem.Name = "taxaDeEntregaToolStripMenuItem";
            this.taxaDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.taxaDeEntregaToolStripMenuItem.Text = "Taxa de Entrega";
            this.taxaDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.taxaDeEntregaToolStripMenuItem_Click);
            // 
            // Sobre
            // 
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(49, 20);
            this.Sobre.Text = "&Sobre";
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 461);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(721, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // todosOsPedidosToolStripMenuItem
            // 
            this.todosOsPedidosToolStripMenuItem.Name = "todosOsPedidosToolStripMenuItem";
            this.todosOsPedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosOsPedidosToolStripMenuItem.Text = "Todos os Pedidos";
            this.todosOsPedidosToolStripMenuItem.Click += new System.EventHandler(this.todosOsPedidosToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 483);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPedidoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem Cadastrar;
        private System.Windows.Forms.ToolStripMenuItem Estoque;
        private System.Windows.Forms.ToolStripMenuItem Sobre;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.BindingSource tbPedidoProdutoBindingSource;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem pedidosAbertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTaxaDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxaDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosFechadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsPedidosToolStripMenuItem;
    }
}



