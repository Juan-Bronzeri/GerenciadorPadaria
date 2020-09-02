using System;
using System.Windows.Forms;

namespace Padaria_UI
{
    public partial class DiaEntregaDoPedido : Form
    {
        public DiaEntregaDoPedido()
        {
            InitializeComponent();
            txtDiaEntrega.Mask = "00/00/0000";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string data = Convert.ToString(txtDiaEntrega.Text);
            DiaDaEntrega.DiaEntraga(data);
        }
    }
}
