namespace Projeto_Integrado
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = validarLogin(txtUsuario.Text, txtSenha.Text);
            if (loginValido)
            {
                this.Hide();
                var frmPrincipal = new FrmPrincipal(txtUsuario.Text, txtSenha.Text);
                frmPrincipal.Show();
            }
        }

        private bool validarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            using (var banco = new VendasDbContest())
            {
                var usuario = banco
                    .Usuario
                    .FirstOrDefault(u => u.Email.ToLower() == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)

                    usuarioValido = true;
            }
            if (usuarioValido)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Login ou Senha Invalidos");
            }
            return false;

        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
