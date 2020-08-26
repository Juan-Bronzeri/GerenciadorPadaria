using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Padaria_DTO;
using Padaria_BLL;

namespace Padaria_UI
{
    public partial class MetodoPagamento : Form
    {
        private int d, c, check;
        public MetodoPagamento()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            string metodo = "";
            if (checkDinheiro.Checked)
            {
                metodo = "Dinheiro";
            }
            else if (checkCartao.Checked)
            {
                metodo = "Cartão";
            }
            else if (checkCheque.Checked)
            {
                metodo = "Cheque";
            }
            int id = retornaIdPedido.RetornarId();
            new PedidoBLL().inserePagamento(metodo, id);
            new PedidoBLL().fecharPedido(id);
            retornaIdPedido.Id(0);
            this.Close();
        }

        private void checkDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if((checkCartao.Checked || checkCheque.Checked) && c == 0 && check == 0)
            {
                d++;
                MessageBox.Show("Atenção, Não pode ter duas formas de pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkCartao.Checked = false;
                checkCheque.Checked = false;
            }
            else
            {
                d = 0;
                c = 0;
                check = 0;
            }
        }

        private void checkCartao_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkDinheiro.Checked || checkCheque.Checked) && d ==0 && check == 0)
            {
                c++;
                MessageBox.Show("Atenção, Não pode ter duas formas de pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkDinheiro.Checked = false;
                checkCheque.Checked = false;  
            }
            else
            {
                d = 0;
                c = 0;
                check = 0;
            }
        }

        private void checkCheque_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkCartao.Checked || checkDinheiro.Checked) && d == 0 && c == 0)
            {
                check++;
                MessageBox.Show("Atenção, Não pode ter duas formas de pagamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkCartao.Checked = false;
                checkDinheiro.Checked = false;
            }
            else
            {
                d = 0;
                c = 0;
                check = 0;
            }
        }


    }
}
