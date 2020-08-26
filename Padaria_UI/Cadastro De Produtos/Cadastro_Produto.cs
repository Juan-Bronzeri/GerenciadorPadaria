using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Padaria_DTO;
using Padaria_BLL;

namespace Padaria_UI
{
    public partial class Cadastro_Produto : Form
    {
        int codProdutoSelecionado;
        private Produto_DTO PRO = new Produto_DTO();
        private IList<Produto_DTO> listProduto = new List<Produto_DTO>();

        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void Estoque_Entrada_Load(object sender, EventArgs e)
        {
            carregaGridDeProdutos();
        }

        private void carregaGridDeProdutos()
        {
            try
            {
                listProduto = new ProdutoBLL().Listar_Produto();
                /*Carregar os dados dos usuarios no DataGridView*/
                dataGridView1.DataSource = listProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregaGridDoProdutoBuscado(string nome_produto)
        {
            try
            {
                listProduto = new ProdutoBLL().Listar_Produto(nome_produto);
                /*Carregar os dados dos usuarios no DataGridView*/
                dataGridView1.DataSource = listProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpar_campos()
        {
            txtNomeProduto.Text = "";
            txtPrecoProduto.Text = "";
            carregaGridDeProdutos();
        }

        private void Click_No_DgvProduto(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridView1.CurrentRow.Index;

            /*Valor de cada datagrid será enviado ao seu respectivo texbox*/
            codProdutoSelecionado = Convert.ToInt32(dataGridView1["gridId", sel].Value);
            txtNomeProduto.Text = Convert.ToString(dataGridView1["gridNomeProduto", sel].Value);
            txtPrecoProduto.Text = Convert.ToString(dataGridView1["gridPrecoo", sel].Value);
        }

        private void Click_btnAdicionar(object sender, EventArgs e)
        {
            try
            {      
                bool achou = false;
                foreach (Produto_DTO PRO in listProduto)
                {
                    if (PRO.NomeProduto == Convert.ToString(txtNomeProduto.Text))
                    {
                        PRO.Quantidade += Convert.ToInt32(txtQnt.Text);
                        achou = true;
                        MessageBox.Show("Produto já cadastrado");
                        break;
                    }
                }
                if (!achou)
                {
                    PRO.NomeProduto = txtNomeProduto.Text;
                    PRO.Preco = Convert.ToDecimal(txtPrecoProduto.Text);
                    PRO.Quantidade = Convert.ToInt32(txtQnt.Text);
                    int x = new ProdutoBLL().insereProduto(PRO);

                    /*Verifica se houve alguma gravação*/
                    if (x > 0)
                    {
                        MessageBox.Show("Gravado com Sucesso!");
                    }
                }

                /*Recarrega o Grid após os dados serem gravados*/
                carregaGridDeProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void Click_btnEditar(object sender, EventArgs e)
        {
            try
            {
                if (codProdutoSelecionado < 0)
                {
                    MessageBox.Show("Atenção, Selecione um Produto antes de prosseguir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PRO.Id = codProdutoSelecionado;
                PRO.NomeProduto = txtNomeProduto.Text;
                PRO.Preco = Convert.ToDecimal(txtPrecoProduto.Text);
                PRO.Quantidade = Convert.ToInt32(txtQnt.Text);

                int x = new ProdutoBLL().alteraProduto(PRO);

                /*Verifica se houve alguma gravação*/
                if (x > 0)
                {
                    MessageBox.Show("Alterado com Sucesso!");
                }

                /*Recarrega o Grid após os dados serem gravados*/
                carregaGridDeProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void Click_btnExcluir(object sender, EventArgs e)
        {
            try
            {
                if (codProdutoSelecionado < 0)
                {
                    MessageBox.Show("Atenção, Selecione um Produto antes de prosseguir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PRO.Id = codProdutoSelecionado;

                int x = new ProdutoBLL().excluiProduto(PRO);

                if (x > 0)
                {
                    MessageBox.Show("Excluido com Sucesso!");
                }

                /*Recarrega o Grid após os dados serem gravados*/
                carregaGridDeProdutos();
                limpar_campos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void Click_btnBuscar(object sender, EventArgs e)
        {
            carregaGridDoProdutoBuscado(txtNomeProduto.Text);
        }

        private void Click_btnLimpar(object sender, EventArgs e)
        {
            limpar_campos();
        }
    }
}
