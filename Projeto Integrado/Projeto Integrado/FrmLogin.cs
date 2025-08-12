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
            if (usuarioValidado.isValid)
            {
                UsuarioHelper.NomeUsuario = usuarioValidado.cliente.NomeCliente;
                UsuarioHelper.Funcao = usuarioValidado.cliente.Funcao;

                this.Hide();
                var frmPrincipal = new FrmPrincipal(txtUsuario.Text, txtSenha.Text);
                frmPrincipal.Show();
            }
        }

        private UsuarioData validarLogin(string nome, string senha)
        {
            bool usuarioValido = false;

            Cliente? usuario;
            using (var banco = new VendasDbContest())
            {
                usuario = banco
                    .Clientes
                var usuario = banco
                    .Usuario
                    .FirstOrDefault(u => u.Email.ToLower() == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)

                    usuarioValido = true;
            }
            if (usuarioValido)
            {
                return new UsuarioData(){ cliente = usuario, isValid = true};
            }
            else
            {
                MessageBox.Show("Login ou Senha Invalidos");
            }
            return new UsuarioData() { cliente = usuario, isValid = true };
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
    public Cliente? cliente { get; set; }
    public bool isValid { get; set; }
}
