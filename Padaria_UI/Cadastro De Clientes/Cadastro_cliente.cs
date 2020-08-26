using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Padaria_DTO;
using Padaria_BLL;
using System.Text.RegularExpressions;
using System.Data;

namespace Padaria_UI
{
    public partial class Cadastro_cliente : Form
    {
        int codUsuSelecionado = -1;
        string modo = "";
        private Pedido_DTO PED = new Pedido_DTO();
        private Cliente_DTO CLI = new Cliente_DTO();
        private IList<Taxa_DTO> listTaxa_DTO = new List<Taxa_DTO>();
        private IList<Cliente_DTO> listCliente_DTO = new List<Cliente_DTO>();

        public Cadastro_cliente()
        {
            InitializeComponent();
            //tamanho minimo do form
            this.MinimumSize = new System.Drawing.Size(514, 437);
            //mascara para text box
            txtTelefone.Mask = "(00)0-0000-0000";
            txtCEP.Mask = "00.000-000";
            txtHorario.Mask = "00:00/00:00";
        }

        private void Cadastro_cliente_Load(object sender, EventArgs e)
        {
            carregaGridDeClientes();
            CarregaComboDaTaxa();
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void CarregaComboDaTaxa()
        {
            try
            {
                listTaxa_DTO = new ClienteBLL().ListarTaxa();
                /*Carregar os dados dos clientes no DataGridView*/
                cmbTaxa.DataSource = listTaxa_DTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void carregaGridDeClientes()
        {
            try
            {
                listCliente_DTO = new ClienteBLL().Listar();
                /*Carregar os dados dos clientes no DataGridView*/
                dgvCliente.DataSource = listCliente_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregaGridDoClienteBuscado(string telefone)
        {
            try
            {
                listCliente_DTO = new ClienteBLL().Listar(telefone);
                /*Carregar os dados dos clientes no DataGridView*/
                dgvCliente.DataSource = listCliente_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Criando Método Limpar Campos*/
        private void limpar_campos()
        {
            txtNomeCliente.Text = "";
            txtRua.Text = "";
            txtTelefone.Text = "";
            txtCEP.Text = "";
            txtComplemento.Text = "";
            txtNumeroCasa.Text = "";
            txtDataCadastro.Text = "";
            carregaGridDeClientes();
        }

        private void Click_No_DgvCliente(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dgvCliente.CurrentRow.Index;

            /*Valor de cada datagrid será enviado ao seu respectivo texbox*/
            txtNomeCliente.Text = Convert.ToString(dgvCliente["gridNome", sel].Value);
            txtTelefone.Text = Convert.ToString(dgvCliente["gridTelefone", sel].Value);
            txtRua.Text = Convert.ToString(dgvCliente["gridRua", sel].Value);
            txtDataCadastro.Text = Convert.ToString(dgvCliente["gridDataCadastro", sel].Value);
            txtCEP.Text = Convert.ToString(dgvCliente["gridCEP", sel].Value);
            txtComplemento.Text = Convert.ToString(dgvCliente["gridComplemento", sel].Value);
            txtNumeroCasa.Text = Convert.ToString(dgvCliente["gridNumeroCasa", sel].Value);
            codUsuSelecionado = Convert.ToInt32(dgvCliente["gridId", sel].Value);

        }

        private new void KeyPress(object sender, KeyPressEventArgs e)
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
            txtTelefone.Select(0, 0);
            txtCEP.Select(0, 0);
            txtHorario.Select(0, 0);
        }

        private void BntNovo_Click(object sender, EventArgs e)
        {
            /*Chamando Método Limpar Campos que foi criado*/
            limpar_campos();
            /*inserindo data atual automaticamente no txtDataCadastro, ao clicar no botão Novo*/
            txtDataCadastro.Text = Convert.ToString(System.DateTime.Now);

            /*após clicar no botão NOVO, modo passa a ser novo*/
            modo = "novo";
        }

        private void Click_btnEditar(object sender, EventArgs e)
        {
            try
            {
                if (codUsuSelecionado < 0)
                {
                    MessageBox.Show("Atenção, Selecione um Cliente antes de prosseguir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja editar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    string nomeBairro = Convert.ToString(cmbTaxa.Text);
                    string tel = Regex.Replace(txtTelefone.Text, "[^0-9,]", "");
                    CLI.Id = codUsuSelecionado;
                    CLI.Nome = txtNomeCliente.Text;
                    CLI.Telefone = tel;
                    CLI.Rua = txtRua.Text;
                    CLI.CEP = txtCEP.Text;
                    CLI.NumeroCasa = Convert.ToInt16(txtNumeroCasa.Text);
                    CLI.Complemento = txtComplemento.Text;
                    CLI.IdTaxa = new ClienteBLL().idTaxa(nomeBairro);

                    int x = new ClienteBLL().alteraCliente(CLI);

                    /*Verifica se houve alguma gravação*/
                    if (x > 0)
                    {
                        MessageBox.Show("Registro editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    /*Recarrega o Grid após os dados serem gravados*/
                    carregaGridDeClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void Click_btnDeletar(object sender, EventArgs e)
        {
            if (codUsuSelecionado < 0)
            {
                MessageBox.Show("Atenção, Selecione um Cliente antes de prosseguir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    CLI.Id = codUsuSelecionado;

                    int x = new ClienteBLL().excluiCliente(CLI);

                    if (x > 0)
                    {
                        MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    /*Recarrega o Grid após os dados serem gravados*/
                    carregaGridDeClientes();
                    limpar_campos();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar_campos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tel = Regex.Replace(txtTelefone.Text, "[^0-9,]", "");
            carregaGridDoClienteBuscado(tel);
        }

        private void Click_btnConfirmar(object sender, EventArgs e)
        {
            if (modo == "novo")
            {
                try
                {
                    string horarioEntrega = Regex.Replace(txtHorario.Text, "[^0-9,]", "");
                    string tel = Regex.Replace(txtTelefone.Text, "[^0-9,]", "");
                    string nomeBairro = Convert.ToString(cmbTaxa.Text);
                    if (new ClienteBLL().buscaIdTaxa(nomeBairro))
                    {
                        CLI.Nome = txtNomeCliente.Text;
                        CLI.Telefone = tel;
                        CLI.Rua = txtRua.Text;
                        CLI.CEP = txtCEP.Text;
                        CLI.NumeroCasa = Convert.ToInt16(txtNumeroCasa.Text);
                        CLI.Complemento = txtComplemento.Text;
                        CLI.DataCadastro = System.DateTime.Now;
                        CLI.HorarioEntrega = horarioEntrega;
                        CLI.IdTaxa = new ClienteBLL().idTaxa(nomeBairro);

                        /*Método insere cliente na classe ClienteBLL*/
                        int x = new ClienteBLL().insereCliente(CLI);
                        /*Verifica se houve alguma gravação*/
                        if (x > 0)
                        {
                            MessageBox.Show("Gravado com Sucesso!");
                        }
                    }
                    else
                    {
                        string nomebairro = Convert.ToString(cmbTaxa.Text);
                        retornaNomeBairro.NomeBairro(nomebairro);
                        MessageBox.Show("Cadastre o bairro primeiro");
                        TaxaEntrega open = new TaxaEntrega();
                        open.Show();
                    }
                    /*Recarrega o Grid após os dados serem gravados*/
                    carregaGridDeClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado" + ex.Message);
                }
            }
        }

        private void Click_btnVender(object sender, EventArgs e)
        {
            try
            {
                int id = new PedidoBLL().IDCliente(txtNomeCliente.Text);
                realizarPedido.Realizar(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }

            Vender_Produto open = new Vender_Produto();

            open.Show();
            this.Close();
        }

        private void LocalizarCEP()
        {
            string cep = Regex.Replace(txtCEP.Text, "[^0-9,]", "");
            string _resultado = "0";
            //Cria um DataSet  baseado no retorno do XML  
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml");
            if (ds != null)
            {
                _resultado = ds.Tables[0].Rows[0]["resultado"].ToString();
                switch (_resultado)
                {
                    case "1":
                        txtRua.Text = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                        cmbTaxa.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                        break;
                    case "2":
                        txtRua.Text = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                        cmbTaxa.Text = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                        break;
                    default:
                        MessageBox.Show("Cep não encontrado");
                        break;
                }
            }
            ds.Clear();
        }
    }
}
