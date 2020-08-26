using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
