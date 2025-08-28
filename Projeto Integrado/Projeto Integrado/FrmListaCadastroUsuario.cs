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
            this.Close();

        }

        private void CarregarUsuarios()
        {
            using (var db = new VendasDbContest())
            {
                var usuarios = db.Usuario.AsQueryable();
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    usuarios = usuarios.Where(u => u.NomeCliente.ToLower().Contains(txtPesquisa.Text.ToLower()) ||
                                                   u.CPF.Contains(txtPesquisa.Text) ||
                                                   u.Funcao.Contains(txtPesquisa.Text));
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
                UsuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                var confirmResult = MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var db = new VendasDbContest())
                    {
                        db.Usuario.Remove(UsuarioSelecionado);
                        db.SaveChanges();
                        CarregarUsuarios();
                        MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                        UsuarioSelecionado = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                var comfirmar = MessageBox.Show("Deseja realmente editar este usuário?", "Confirmação", MessageBoxButtons.YesNo);
                if (comfirmar == DialogResult.Yes)
                {
                    var frmCadastro = new FrmCadastroUsuarios(UsuarioSelecionado);
                    frmCadastro.ShowDialog();
                    CarregarUsuarios();
                    UsuarioSelecionado = null;
                }
                
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado para edição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FrmListaCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;
            }
        }
        private void condicao()
        {
            var isAutorizedToUpdateData = (UsuarioHelper.Funcao == "Gerente" || UsuarioHelper.Funcao == "Administrativo");
            if (isAutorizedToUpdateData)
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
    }
}
    
