using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if(_usuario != null)
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
                condicaoFuncao();
                string Funcao = comboFuncao.Text;
                string Senha = txtSenha.Text;

                if (string.IsNullOrEmpty(Nome))
                {
                    MessageBox.Show("Preencha o campo Nome.");
                    return;
                }
                if (string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Preencha o campo Email.");
                    return;
                }
                if (string.IsNullOrEmpty(Senha))
                {
                    MessageBox.Show("Preencha o campo Senha.");
                    return;
                }
                if (string.IsNullOrEmpty(Telefone))
                {
                    MessageBox.Show("Preencha o campo Telefone.");
                    return;
                }
                if (string.IsNullOrEmpty(CpfUsuario))
                {
                    MessageBox.Show("Preencha o campo CPF.");
                    return;
                }
                if (string.IsNullOrEmpty(PerfilUsuario))
                {
                    MessageBox.Show("Selecione o Perfil do Usuário.");
                    return;
                }
                if (PerfilUsuario != "Cliente")
                {
                    comboFuncao.Enabled = true;
                }
                if (comboFuncao.Enabled == true)
                {
                    if (string.IsNullOrEmpty(Funcao))
                    {
                        MessageBox.Show("Selecione a Função.");
                        return;
                    }
                }

                // Converte CPF de string em inteiro
                if (!int.TryParse(CpfUsuario, out int cpfInt))
                {
                    MessageBox.Show("CPF deve ser um número válido.");
                    return;
                }

               
                var usuario = banco.Usuario.First(x => x.Id == _usuario.Id);
                usuario.PerfilUsuario = PerfilUsuario;
                usuario.NomeCliente = Nome;
                usuario.CPF = cpfInt; // Convertido para inteiro
                usuario.Email = Email;
                usuario.Telefone = Telefone;
                usuario.Funcao = Funcao;
                usuario.Senha = Senha;
                banco.Update(usuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário atualizado com sucesso!","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string Telefone = txtTelefone.Text;
                string CpfUsuario = txtCPF.Text; // entra como string

                condicaoFuncao();
                string Funcao = comboFuncao.Text;
                string Senha = txtSenha.Text;

                if (string.IsNullOrEmpty(Nome))
                {
                    MessageBox.Show("Preencha o campo Nome.");
                    return;
                }
                if (string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Preencha o campo Email.");
                    return;
                }
                if (string.IsNullOrEmpty(Senha))
                {
                    MessageBox.Show("Preencha o campo Senha.");
                    return;
                }
                if (string.IsNullOrEmpty(Telefone))
                {
                    MessageBox.Show("Preencha o campo Telefone.");
                    return;
                }
                if (string.IsNullOrEmpty(CpfUsuario))
                {
                    MessageBox.Show("Preencha o campo CPF.");
                    return;
                }

                if (string.IsNullOrEmpty(PerfilUsuario))
                {
                    MessageBox.Show("Selecione o Perfil do Usuário.");
                    return;
                }
                if (PerfilUsuario != "Cliente")
                {
                    comboFuncao.Enabled = true;
                }

                if (comboFuncao.Enabled == true)
                {
                    if (string.IsNullOrEmpty(Funcao))
                    {
                        MessageBox.Show("Selecione a Função.");
                        return;
                    }
                }

                // Converte CPF de string em inteiro
                if (!int.TryParse(CpfUsuario, out int cpfInt))
                {
                    MessageBox.Show("CPF deve ser um número válido.");
                    return;
                }

                var usuario = new Usuario
                {
                    PerfilUsuario = PerfilUsuario,
                    NomeCliente = Nome,
                    CPF = cpfInt, // Convertido para inteiro
                    Email = Email,
                    Telefone = Telefone,
                    Funcao = Funcao,
                    Senha = Senha,
                    
    };

                banco.Usuario.Add(usuario);
                banco.SaveChanges();
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void condicaoFuncao()
        {
            var CondicaoFuncao = comboFuncao.Text;

            if (CondicaoFuncao=="Cliente")
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
    }
}
