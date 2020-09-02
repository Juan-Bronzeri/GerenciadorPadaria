using Padaria_BLL;
using Padaria_DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Padaria_UI
{
    public partial class Vender_Produto : Form
    {
        private IList<Itens_DTO> listaDeItens = new List<Itens_DTO>();
        private decimal preco;

        private int cont = 0;

        public Vender_Produto()
        {
            InitializeComponent();
        }

        private void Vender_Produto_Load(object sender, EventArgs e)
        {
            int x = retornaIdPedido.RetornarId();
            if (x > 0)
            {
                carregaGrid_ItensAbertos(x);
                carregaGridDeProdutos();
            }
            else
            {
                DiaEntregaDoPedido open = new DiaEntregaDoPedido();
                open.Show();
                carregaGridDeProdutos();
                cont = 0;
            }
        }

        private void carregaGridDeProdutos()
        {
            try
            {
                IList<Produto_DTO> listProduto_DTO = new List<Produto_DTO>();
                listProduto_DTO = new ProdutoBLL().Listar_Produto();
                /*Carregar os dados dos produtos no DataGridView*/
                dgvProdutos.DataSource = listProduto_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregaGridDeProdutoBuscado(string nome_produto)
        {
            try
            {
                IList<Produto_DTO> listProduto_DTO = new List<Produto_DTO>();
                listProduto_DTO = new ProdutoBLL().Listar_Produto(nome_produto);
                /*Carregar os dados dos produtos no DataGridView*/
                dgvProdutos.DataSource = listProduto_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregarGridItens()
        {
            try
            {
                decimal total = 0;
                for (int i = 0; i < listaDeItens.Count; i++)
                {
                    listaDeItens[i].Total = listaDeItens[i].PrecoProduto * listaDeItens[i].Quantidade;
                    total = listaDeItens[i].Total + total;
                }
                dgvItens.DataSource = null;
                dgvItens.DataSource = listaDeItens;
                txtTotal.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregaGrid_ItensAbertos(int id)
        {
            try
            {
                listaDeItens = new List<Itens_DTO>();
                listaDeItens = new ItensBLL().Listar_Itens_Abertos(id);
                /*Carregar os dados dos usuarios no DataGridView*/
                carregarGridItens();
                cont = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void limpar()
        {
            txtNome_Produto.Text = "";
            txtNome_Produto_Adicionar.Text = "";
            txtObservacao.Text = "";
            cmbQuantidade.Text = "";
            txtIdProduto.Text = "";
        }

        private void Click_btnBuscar(object sender, EventArgs e)
        {
            carregaGridDeProdutoBuscado(txtNome_Produto.Text);
            limpar();
        }

        private void Click_btnAdicionar(object sender, EventArgs e)
        {
            try
            {
                int sel = dgvProdutos.CurrentRow.Index;
                bool achou = false;
                foreach (Itens_DTO itemxpto in listaDeItens)
                {
                    if (itemxpto.IdProduto == Convert.ToInt32(txtIdProduto.Text))
                    {
                        itemxpto.Quantidade += Convert.ToInt32(cmbQuantidade.Text);
                        achou = true;
                        break;
                    }
                }
                if (!achou)
                {
                    Itens_DTO item = new Itens_DTO();

                    item.NomeProduto = txtNome_Produto_Adicionar.Text;
                    item.IdProduto = Convert.ToInt32(txtIdProduto.Text);
                    item.PrecoProduto = preco;
                    item.Observacao = txtObservacao.Text;
                    item.Quantidade = Convert.ToInt32(cmbQuantidade.Text);
                    listaDeItens.Add(item);
                }

                /*Recarrega o Grid após os dados serem gravados*/
                carregarGridItens();
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void Click_btnConcluir(object sender, EventArgs e)
        {
            try
            {
                if (cont != 1)
                {
                    int x = 0, Qnt = 0, id = 0;
                    if (listaDeItens.Count > 0)
                    {
                        Pedido_DTO PED = new Pedido_DTO();
                        DateTime data = Convert.ToDateTime(DiaDaEntrega.RetornaDiaEntrega());
                        PED.DataAbertura = data;
                        PED.Estado = 1;
                        PED.IdCliente = realizarPedido.RealizouPedido();

                        int Pedido = new PedidoBLL().inserePedido(PED);

                        int sel = dgvProdutos.CurrentRow.Index;

                        x = new PedidoBLL().IDPedido();

                        Itens_DTO item = new Itens_DTO();

                        for (var i = 0; i < listaDeItens.Count; i++)
                        {
                            item.IdProduto = listaDeItens[i].IdProduto;
                            id = listaDeItens[i].IdProduto;
                            item.IdPedido = x;
                            item.NomeProduto = listaDeItens[i].NomeProduto;
                            item.Observacao = listaDeItens[i].Observacao;
                            item.PrecoProduto = listaDeItens[i].PrecoProduto;
                            item.Quantidade = listaDeItens[i].Quantidade;
                            Qnt = Convert.ToInt32(item.Quantidade);
                            new ProdutoBLL().ControleEstoque(id, Qnt);
                            new ItensBLL().insereItens(item);
                        }
                    }
                    Close();
                    retornaIdPedido.Id(0);
                }
                else
                {
                    int Qnt = 0, id = 0;
                    int x = retornaIdPedido.RetornarId();
                    int cont = new ItensBLL().excluiItem(x);
                    while (cont >= 0)
                    {
                        new ItensBLL().adicionaEstoque(cont);
                        cont--;
                    }

                    if (listaDeItens.Count > 0)
                    {
                        Itens_DTO item = new Itens_DTO();

                        for (var i = 0; i < listaDeItens.Count; i++)
                        {
                            item.IdProduto = listaDeItens[i].IdProduto;
                            id = listaDeItens[i].IdProduto;
                            item.IdPedido = x;
                            item.NomeProduto = listaDeItens[i].NomeProduto;
                            item.Observacao = listaDeItens[i].Observacao;
                            item.PrecoProduto = listaDeItens[i].PrecoProduto;
                            item.Quantidade = listaDeItens[i].Quantidade;
                            Qnt = Convert.ToInt32(item.Quantidade);
                            new ProdutoBLL().ControleEstoque(id, Qnt);
                            new ItensBLL().insereItens(item);
                        }
                    }
                    Close();
                    retornaIdPedido.Id(0);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void cmbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void Click_btnExcluir(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                int id = Convert.ToInt32(txtIdProduto.Text);
                int qnt = Convert.ToInt32(cmbQuantidade.Text);

                if (listaDeItens.Count > 0)
                {
                    Itens_DTO item = new Itens_DTO();

                    for (var i = 0; i < listaDeItens.Count; i++)
                    {
                        if (listaDeItens[i].IdProduto == id)
                        {
                            listaDeItens[i].Quantidade = listaDeItens[i].Quantidade - qnt;
                        }
                        if (listaDeItens[i].Quantidade <= 0)
                        {
                            listaDeItens.RemoveAt(i);
                        }
                    }
                    carregarGridItens();
                }



                /*Recarrega o Grid após os dados serem gravados*/

            }
        }
        private void Click_No_DgvItem(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvItens.CurrentRow.Index;

            txtIdProduto.Text = Convert.ToString(dgvItens["gridIdProduto", sel].Value);
            txtNome_Produto_Adicionar.Text = Convert.ToString(dgvItens["gridProduto", sel].Value);
            txtObservacao.Text = Convert.ToString(dgvItens["gridObservacao", sel].Value);
            preco = Convert.ToDecimal(dgvItens["PrecoProduto", sel].Value);
        }

        private void Click_No_DgvProduto(object sender, DataGridViewCellEventArgs e)
        {
            {
                int sel = dgvProdutos.CurrentRow.Index;

                /*Valor de cada datagrid será enviado ao seu respectivo texbox*/
                txtNome_Produto_Adicionar.Text = Convert.ToString(dgvProdutos["gridNomeProduto", sel].Value);
                txtIdProduto.Text = Convert.ToString(dgvProdutos["gridId", sel].Value);
                preco = Convert.ToDecimal(dgvProdutos["gridPrecoProduto", sel].Value);
            }
        }
    }
}
