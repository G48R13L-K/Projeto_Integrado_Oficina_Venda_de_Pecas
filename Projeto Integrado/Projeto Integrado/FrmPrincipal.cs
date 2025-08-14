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
        }


        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            var fromLogin = new FrmLogin();
            this.Close();
            fromLogin.Show();
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
            var formPecas = new FrmEstoquePecas();
            formPecas.ShowDialog();
        }
    }
}
