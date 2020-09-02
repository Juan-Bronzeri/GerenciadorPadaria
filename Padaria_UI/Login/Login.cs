using Padaria_BLL;
using System;
using System.Windows.Forms;

namespace Padaria_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Click_btnLogin(object sender, EventArgs e)
        {
            Verificar(txtUsuario.Text, txtSenha.Text);
        }

        //verifica validade dos dados de login
        private void Verificar(string user, string password)
        {
            try
            {
                bool result = new LoginBLL().Buscar(user, password);
                if (result)
                {
                    MessageBox.Show("Seja bem vindo!");
                    Altenticar.Autenticar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Click_btnLogin();
        }

        private void Click_btnLogin()
        {
            Verificar(txtUsuario.Text, txtSenha.Text);
        }
    }
}
