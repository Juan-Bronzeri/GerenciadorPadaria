using System;
using System.Windows.Forms;
using Padaria_DTO;
using Padaria_BLL;
using System.Collections.Generic;

namespace Padaria_UI
{
    public partial class TaxaEntrega : Form
    {
        int codTaxa = 0;
        public IList<Taxa_DTO> listDeTaxas = new List<Taxa_DTO>();
        public Taxa_DTO taxa = new Taxa_DTO();

        public TaxaEntrega()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void TaxaEntrega_Load(object sender, EventArgs e)
        {
            carregaGridDaTaxa();
        }

        private void carregaGridDaTaxa()
        {
            try
            {
                listDeTaxas = new ClienteBLL().ListarTaxa();
                /*Carregar os dados dos usuarios no DataGridView*/
                dgvTaxa.DataSource = listDeTaxas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Click_no_dgvTaxa(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvTaxa.CurrentRow.Index;

            /*Valor de cada datagrid será enviado ao seu respectivo texbox*/
            txtNomedoBairro.Text = Convert.ToString(dgvTaxa["gridNome", sel].Value);
            txtValorDaTaxa.Text = Convert.ToString(dgvTaxa["gridValor", sel].Value);
            codTaxa = Convert.ToInt32(dgvTaxa["gridId", sel].Value);
        }

        private void Click_btnAdicionar(object sender, EventArgs e)
        {
            try
            {
                bool achou = false;
                foreach (Taxa_DTO taxa in listDeTaxas)
                {
                    if (taxa.NomeBairro == Convert.ToString(txtNomedoBairro.Text))
                    {
                        achou = true;
                        MessageBox.Show("Bairro já cadastrado");
                        break;
                    }
                }
                if (!achou)
                {
                    taxa.NomeBairro = txtNomedoBairro.Text;
                    taxa.Valor = Convert.ToDecimal(txtValorDaTaxa.Text);

                    int x = new TaxaBLL().insereTaxa(taxa);
                    /*Verifica se houve alguma gravação*/
                    if (x > 0)
                    {
                        MessageBox.Show("Gravado com Sucesso!");
                    }
                }
                /*Recarrega o Grid após os dados serem gravados*/
                carregaGridDaTaxa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void Click_btnExcluir(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                int x = new TaxaBLL().excluirTaxa(codTaxa);

                if (x > 0)
                {
                    MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                /*Recarrega o Grid após os dados serem gravados*/
                carregaGridDaTaxa();
            }
        }

        private void Click_btnEdita(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    taxa.Id = codTaxa;
                    taxa.NomeBairro = txtNomedoBairro.Text;
                    taxa.Valor = Convert.ToDecimal(txtValorDaTaxa.Text);

                    int x = new TaxaBLL().editarTaxa(taxa);
                    /*Verifica se houve alguma gravação*/
                    if (x > 0)
                    {
                        MessageBox.Show("Editado com Sucesso!");
                    }

                    /*Recarrega o Grid após os dados serem gravados*/
                    carregaGridDaTaxa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }
    }
}
