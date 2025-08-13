using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrado
{
    public partial class FrmListaCadastroUsuario : Form
    {
        Usuario? UsuarioSelecionado;
        public FrmListaCadastroUsuario()
        {
            InitializeComponent();
            CarregarUsuarios();
            condicao();
        }

        void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void CarregarUsuarios()
        {
            using (var db = new VendasDbContest())
            {
                var usuarios = db.Usuario.AsQueryable();
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    usuarios = usuarios.Where(u => u.NomeCliente.ToLower().Contains(txtPesquisa.Text.ToLower()) ||
                                                   u.CPF.ToString().Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = usuarios.ToList(); // Adicionado ToList() para materializar a consulta
                dataGridView1.Columns["Id"].Visible = false; // Oculta a coluna Id
                dataGridView1.Columns["Senha"].Visible = false; // Oculta a coluna Senha
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
        private void btnMaisCadastro_Click(object sender, EventArgs e)
        {
            var frmCadastro = new FrmCadastroUsuarios();
            frmCadastro.ShowDialog();
            CarregarUsuarios();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void condicao()
        {
            var isAutorizedToUpdateData = (UsuarioHelper.Funcao == "Gerente" || UsuarioHelper.Funcao == "Administrativo");

            if (isAutorizedToUpdateData)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnMaisCadastro.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnMaisCadastro.Enabled = false;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                var frmCadastro = new FrmCadastroUsuarios(UsuarioSelecionado);
                frmCadastro.ShowDialog();
                CarregarUsuarios();
                
                CarregarUsuarios();
                UsuarioSelecionado = null;
            }

        }
    }
}
