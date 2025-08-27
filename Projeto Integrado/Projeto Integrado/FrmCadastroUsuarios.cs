using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.IdentityModel.Tokens;

namespace Projeto_Integrado
{

    public partial class FrmCadastroUsuarios : Form
    {

        private Usuario _usuario;
        public FrmCadastroUsuarios()
        {
            InitializeComponent();
        }

        public FrmCadastroUsuarios(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();

            CarregarDadosTela();

        }

        private void CarregarDadosTela()
        {
            if (_usuario != null)
            {
                txtNome.Text = _usuario.NomeCliente;
                txtEmail.Text = _usuario.Email;
                txtTelefone.Text = _usuario.Telefone;
                txtCPF.Text = _usuario.CPF.ToString();
                comboFuncao.Text = _usuario.Funcao;
                cmbUsuarios.Text = _usuario.PerfilUsuario;
                txtSenha.Text = _usuario.Senha;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                InserirUsuario();
            }
            else
            {
                AtualizarUsuario();
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarUsuario()
        {
            using (var banco = new VendasDbContest())
            {
                //capta os dados do formulário
                string PerfilUsuario = cmbUsuarios.Text;
                string Nome = txtNome.Text;
                string Email = txtEmail.Text;
                string Telefone = txtTelefone.Text;
                string CpfUsuario = txtCPF.Text; // entra como string
                string Funcao = comboFuncao.Text;
                string Senha = txtSenha.Text;


                var usuario = banco.Usuario.First(x => x.Id == _usuario.Id);

                usuario.PerfilUsuario = PerfilUsuario;
                usuario.NomeCliente = Nome;
                usuario.CPF = CpfUsuario; // Convertido para inteiro
                usuario.Email = Email;
                usuario.Telefone = Telefone;
                usuario.Funcao = Funcao;
                usuario.Senha = Senha;

                if (usuario.PerfilUsuario == "Cliente")
                {
                    var validaCliente = ValidarCampoCliente();

                    if (!validaCliente)
                    {
                        return;
                    }
                }
                else
                {
                    var validaUsuario = ValidarCampoParaUsuario();

                    if (!validaUsuario)
                    {
                        return;
                    }
                }

                banco.Update(usuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();



            }
        }





        private void InserirUsuario()
        {
            using (var banco = new VendasDbContest())
            {

                //capta os dados do formulário
                string PerfilUsuario = cmbUsuarios.Text;
                string Nome = txtNome.Text;
                string Email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string CpfUsuario = txtCPF.Text;




                var usuario = new Usuario
                {
                    PerfilUsuario = PerfilUsuario,
                    NomeCliente = Nome,
                    Email = Email,
                    Telefone = telefone,
                    CPF = CpfUsuario, // Mantém como string para validação
                    Funcao = comboFuncao.Text,
                    Senha = txtSenha.Text
                };
               
                if (usuario.PerfilUsuario == "Cliente")
                {
                var validaCliente = ValidarCampoCliente();
                    
                    if (!validaCliente)
                    {
                        return;
                    }
                }
                else
                { var validaUsuario = ValidarCampoParaUsuario();
                   
                    if (!validaUsuario)
                    {
                        return;
                    }
                }
                banco.Usuario.Add(usuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void condicaoFuncao()
        {
            var CondicaoFuncao = comboFuncao.Text;

            if (CondicaoFuncao == "Cliente")
            {
                comboFuncao.Enabled = false;
                txtSenha.Enabled = false;
            }
            else
            {
                comboFuncao.Enabled = true;
                txtSenha.Enabled = true;
            }

        }



        private void comboFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //crear uma condição onde avilite o campo senha apenas se o a função da pessoa for diferente de Funcionário 
            if (comboFuncao.Text == "Funcionário")
            {
                txtSenha.Enabled = false;
            }
            else
            {
                txtSenha.Enabled = true;
            }

        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text == "Cliente")
            {
                comboFuncao.Enabled = false;
                txtSenha.Enabled = false;
            }
            else
            {
                comboFuncao.Enabled = true;
                txtSenha.Enabled = false;
            }
        }
        private bool ValidarCampoParaUsuario()

        {errorProvider1.Clear();
            if(cmbUsuarios.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(cmbUsuarios, "O campo PERFIL é obrigatório.");
            }
            
            if (txtEmail.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtEmail, "O campo EMAIL é obrigatório.");
            }
            if (txtSenha.Text.Length < 6)
            {
                errorProvider1.SetError(txtSenha, "A senha tem que ter mais que 6 dígitos.");

            }
            if (txtCPF.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtCPF, "O campo CPF é obrigatório.");
            }

            if (txtNome.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtNome, "O campo NAME é obrigatório.");
            }
            if (txtSenha.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtSenha, "O campo SENHA é obrigatório.");
            }
            if (comboFuncao.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(comboFuncao, "Éste campo é obrigatório.");
            }

            if (!errorProvider1.HasErrors) return true;

            return false;


        }
        private bool ValidarCampoCliente()
        {
            errorProvider1.Clear();

            if (cmbUsuarios.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(cmbUsuarios, "O campo PERFIL é obrigatório.");
            }


            if (txtCPF.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtCPF, "O campo CPF é obrigatório.");
            }

            if (txtNome.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(txtNome, "O campo NAME é obrigatório.");
            }
           
          

            if (!errorProvider1.HasErrors) return true;

            return false;
        }
    }
}
