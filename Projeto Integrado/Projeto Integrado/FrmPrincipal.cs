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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            labelBemvindo.Text = " Bem-vindo " + nome;
            Dicas();
        }

        

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair da conta conectada?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var fromLogin = new FrmLogin();
                this.Close();
                fromLogin.Show();

            }
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            var formVendas = new FrmVendas();
            formVendas.ShowDialog();

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var FrmRelatorio = new FrmRelatorio();
            FrmRelatorio.ShowDialog();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var formListaCadastro = new FrmListaCadastroUsuario();
            formListaCadastro.ShowDialog();

        }

        private void btnPecas_Click(object sender, EventArgs e)
        {
            var formPecas = new FrmCadastrosPecas();
            formPecas.ShowDialog();

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            var formCadastroUsuarios = new FrmCadastroUsuarios();
            formCadastroUsuarios.ShowDialog();

        }

        private void btnEstoqui_Click(object sender, EventArgs e)
        {
            var formEstoque = new FrmEstoquePecas();
            formEstoque.ShowDialog();

        }
        
        private void Dicas()
        { 
            ToolTip TipVendas = new ToolTip();
            TipVendas.SetToolTip(btnVendas, "Clique aqui para realizar uma venda");

            ToolTip TipRelatorioVendas = new ToolTip();
            TipRelatorioVendas.SetToolTip(btnRelatorio, "Clique aqui para ver o relatório de vendas");

            ToolTip TipCadastroUsuarios = new ToolTip();
            TipCadastroUsuarios.SetToolTip(btnCadastros, "Clique aqui para ver a lista de clientes e usuários cadastrados");

            ToolTip TipCadastroPecas = new ToolTip();
            TipCadastroPecas.SetToolTip(btnPecas, "Clique aqui para cadastrar novas peças");

            ToolTip Clientes = new ToolTip();
            Clientes.SetToolTip(btnClientes, "Clique aqui para cadastrar novos clientes e usuários");

            ToolTip Estoque = new ToolTip();
            Estoque.SetToolTip(btnEstoqui, "Clique aqui para ver o estoque de peças");
        }

        
    }
}
