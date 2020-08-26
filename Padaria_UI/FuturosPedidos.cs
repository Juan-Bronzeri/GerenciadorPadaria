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
    public partial class FuturosPedidos : Form
    {
        private IList<Pedido_DTO> listPedido_DTO = new List<Pedido_DTO>();
        public FuturosPedidos()
        {
            InitializeComponent();
        }

        private void TodosPedidos_Load(object sender, EventArgs e)
        {
            carregaGridDeClientes();
        }

        private void carregaGridDeClientes()
        {
            try
            {
                listPedido_DTO = new PedidoBLL().Listar_Pedido_Dias_Seguintes();
                dgvPedido.DataSource = listPedido_DTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
