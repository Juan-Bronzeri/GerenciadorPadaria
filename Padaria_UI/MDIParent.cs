using System;
using System.Windows.Forms;

namespace Padaria_UI
{
    public partial class MDIParent : Form
    {

        public MDIParent()
        {
            InitializeComponent();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Cadastro_cliente();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Cadastro_Produto();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            Login open = new Login();
            open.Show();
            open.Close();

            this.Visible = true;
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new PedidoAberto();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void taxaDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new TaxaEntrega();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void pedidosFechadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new PedidoFechado();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void todosOsPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new FuturosPedidos();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
