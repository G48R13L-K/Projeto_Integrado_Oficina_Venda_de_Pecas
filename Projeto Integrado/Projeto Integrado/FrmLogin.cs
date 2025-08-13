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
            var usuarioValidado = validarLogin(txtUsuario.Text, txtSenha.Text);
            if (usuarioValidado.isValid && usuarioValidado.usuario is not null)
            {
                UsuarioHelper.NomeUsuario = usuarioValidado.usuario.NomeCliente;
                UsuarioHelper.Funcao = usuarioValidado.usuario.Funcao;

                this.Hide();
                var frmPrincipal = new FrmPrincipal(txtUsuario.Text, txtSenha.Text);
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
                MessageBox.Show("Login ou Senha Invalidos");
                return new UsuarioData() { Usuario = null, isValid = false }; // Ensure proper handling of null values.
            }
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

internal class UsuarioData
{
    public Usuario? Usuario { get; set; }
    public bool isValid { get; set; }
}
