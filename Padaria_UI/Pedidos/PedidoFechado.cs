using Padaria_BLL;
using Padaria_DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Padaria_UI
{
    public partial class PedidoFechado : Form
    {
        private IList<Pedido_DTO> listPedidoFechado_DTO = new List<Pedido_DTO>();
        private IList<Itens_DTO> listItens_DTO = new List<Itens_DTO>();

        public PedidoFechado()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void PedidoFechado_Load(object sender, EventArgs e)
        {
            CarregaGridDePedidosFechados();
            txtData.Mask = "00/00/0000";
            txtDataFim.Mask = "00/00/0000";
        }


        private void CarregaGridDePedidosFechados()
        {
            try
            {
                listPedidoFechado_DTO = new PedidoBLL().Listar_Pedido_Fechado();
                dgvPedidoFechados.DataSource = listPedidoFechado_DTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void carregaGridDoPedidoBuscado()
        {
            try
            {
                string nome = txtNome.Text;
                listPedidoFechado_DTO = new PedidoBLL().Listar_Pedido_Fechado(nome);
                dgvPedidoComFiltro.DataSource = listPedidoFechado_DTO;
                if (listPedidoFechado_DTO.Count <= 0)
                {
                    MessageBox.Show("Não foram encontrados nenhum pedido com esse nome");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtData.Text != "  /  /" & txtDataFim.Text != "  /  /" & txtNome.Text != "")
                {
                    DateTime inicio = Convert.ToDateTime(txtData.Text);
                    DateTime final = Convert.ToDateTime(txtDataFim.Text);
                    string nome = txtNome.Text;

                    listPedidoFechado_DTO = new PedidoBLL().Listar_Pedido_Filtro(inicio, final, nome);
                    if (listPedidoFechado_DTO.Count != 0)
                    {
                        /*Recarrega o Grid*/
                        dgvPedidoComFiltro.DataSource = listPedidoFechado_DTO;

                        decimal x = new PedidoBLL().valorBrutoData(inicio, final);

                        txtValorSolido.Text = Convert.ToString(x);
                    }
                    else
                    {
                        string i = inicio.ToString("dd/MM/yyyy");
                        string f = final.ToString("dd/MM/yyyy");
                        MessageBox.Show("Não foram encontrados nenhum pedido entre as datas:         " +
                            " " + i + " e " + f + "");
                        dgvPedidoComFiltro.DataSource = null;
                    }
                }
                else if (txtData.Text != "  /  /" & txtDataFim.Text != "  /  /")
                {
                    DateTime inicio = Convert.ToDateTime(txtData.Text);
                    DateTime final = Convert.ToDateTime(txtDataFim.Text);

                    listPedidoFechado_DTO = new PedidoBLL().Listar_Pedido_Filtro(inicio, final);
                    if (listPedidoFechado_DTO.Count != 0)
                    {
                        /*Recarrega o Grid*/
                        dgvPedidoComFiltro.DataSource = listPedidoFechado_DTO;

                        decimal x = new PedidoBLL().valorBrutoData(inicio, final);

                        txtValorSolido.Text = Convert.ToString(x);
                    }
                    else
                    {
                        string i = inicio.ToString("dd/MM/yyyy");
                        string f = final.ToString("dd/MM/yyyy");
                        MessageBox.Show("Não foram encontrados nenhum pedido entre as datas:         " +
                            " " + i + " e " + f + "");
                    }

                }
                else if (txtNome.Text != "")
                {
                    string nome = txtNome.Text;
                    decimal x = new PedidoBLL().valorBrutoNome(nome);
                    txtValorSolido.Text = Convert.ToString(x);
                    carregaGridDoPedidoBuscado();
                }
                else
                {
                    MessageBox.Show("Informe o filtro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void Click_No_dgvPedido(object sender, DataGridViewCellEventArgs e)
        {

            int sel = dgvPedidoFechados.CurrentRow.Index;

            int id = Convert.ToInt32(dgvPedidoFechados["gridId", sel].Value);

            carregaGridDePedidosSelecionados(id);
        }

        private void carregaGridDePedidosSelecionados(int id)
        {
            try
            {
                listItens_DTO = new PedidoBLL().Listar_Item_Pedido(id, 0);
                dgvItens.DataSource = listItens_DTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Bloquear_Caracteres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void Click_No_TextBox(object sender, EventArgs e)
        {
            //inicia o cursor no começo do TextBox
            txtData.Select(0, 0);
            txtDataFim.Select(0, 0);
        }

        private void Click_No_dgvPedidoBuscado(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvPedidoComFiltro.CurrentRow.Index;

            int id = Convert.ToInt32(dgvPedidoComFiltro["gridIdPedidoFiltrado", sel].Value);

            carregaGridDePedidosSelecionados(id);
        }
    }
}
