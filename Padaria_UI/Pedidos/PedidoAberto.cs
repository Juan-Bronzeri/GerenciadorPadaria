using Padaria_BLL;
using Padaria_DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Padaria_UI
{
    public partial class PedidoAberto : Form
    {
        private int idPedido, idTaxa;
        private IList<Pedido_DTO> listPedido_DTO = new List<Pedido_DTO>();
        private IList<Itens_DTO> listItem_DTO = new List<Itens_DTO>();

        public PedidoAberto()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(816, 489);
        }

        private void Click_No_DgvPedido(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvPedido.CurrentCell.RowIndex;

            idTaxa = Convert.ToInt32(dgvPedido["gridIdTaxa", sel].Value);
            idPedido = Convert.ToInt32(dgvPedido["gridIdPedido", sel].Value);
            txtId.Text = Convert.ToString(idPedido);
            txtNome.Text = Convert.ToString(dgvPedido["gridNome", sel].Value);

            decimal taxa = new PedidoBLL().valorTaxa(idTaxa);

            retornaIdPedido.Id(0);
            retornaIdPedido.Id(idPedido);

            txtValorTaxa.Text = Convert.ToString(taxa);

            CarregaGridDeItem(idPedido, taxa);
        }

        private void PedidoAberto_Load(object sender, EventArgs e)
        {
            CarregaGridDePedido();
        }

        private void CarregaGridDePedido()
        {
            try
            {
                listPedido_DTO = new PedidoBLL().Listar_Pedido();
                /*Carregar os dados dos usuarios no DataGridView*/
                dgvPedido.DataSource = listPedido_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaGridDeItem(int idPedido, decimal taxa)
        {
            try
            {
                listItem_DTO = new PedidoBLL().Listar_Item_Pedido(idPedido, taxa);
                dgvItem.DataSource = listItem_DTO;

                decimal x = new PedidoBLL().somaTotal();

                txtTotal.Text = Convert.ToString(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnFechar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            retornaIdPedido.Id(id);
            MetodoPagamento open = new MetodoPagamento();
            open.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGridDePedido();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int sel = dgvPedido.CurrentRow.Index;
            int idPedido = Convert.ToInt32(dgvPedido["gridIdPedido", sel].Value);

            retornaIdPedido.Id(idPedido);

            Vender_Produto open = new Vender_Produto();
            open.Show();
        }
    }
}
