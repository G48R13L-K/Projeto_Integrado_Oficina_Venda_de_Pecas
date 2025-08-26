using Projeto_Integrado;

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
            var usuarioValidado = validarLogin(txtUsuario.Text, maskedSenha.Text);
            if (usuarioValidado.isValid && usuarioValidado.Usuario is not null)
            {
                UsuarioHelper.NomeUsuario = usuarioValidado.Usuario.NomeCliente;
                UsuarioHelper.Funcao = usuarioValidado.Usuario.Funcao;

                this.Hide();
                var frmPrincipal = new FrmPrincipal(txtUsuario.Text, maskedSenha.Text);
                frmPrincipal.Show();
            }
        }

        private UsuarioData validarLogin(string nome, string senha)
        {
            Usuario? usuario = null; // Initialize the variable to avoid null reference issues.
            bool usuarioValido = false;

            using (var banco = new VendasDbContest())
            {
                usuario = banco
                    .Usuario
                    .FirstOrDefault(u => u.Email.ToLower() == nome.ToLower() && u.Senha == senha);

                if (usuario is not null)
                {
                    usuarioValido = true;
                }
            }

            if (usuarioValido)
            {
                return new UsuarioData() { Usuario = usuario, isValid = true };
            }
            else
            {
                MessageBox.Show("Email ou Senha Invalidos");
                return new UsuarioData() { Usuario = null, isValid = false }; // Ensure proper handling of null values.
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuário";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void maskedSenha_Enter(object sender, EventArgs e)
        {
            if (lblSenha.Text == "Senha")
            {
                lblSenha.Text = string.Empty;
                lblSenha.ForeColor = Color.Black;
            }
        }
        private void maskedSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedSenha.Text))
            {
                lblSenha.Text = "Senha";
                lblSenha.ForeColor = Color.Black;
            }

        }
    }
}

internal class UsuarioData
{
    public Usuario? Usuario { get; set; }
    public bool isValid { get; set; }
}
