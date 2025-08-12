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
    public partial class FrmRelatorio : Form
    {
        Venda? VendaSelecionada;
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            BuscarVenda();
        }

        private void BuscarVenda()
        {
            using (var bd = new VendasDbContest())
            {
                var usuario = bd.Usuario.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    usuario = usuario.Where(u => u.NomeCliente.Contains(txtPesquisa.Text) ||
                                                    u.Email.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = usuario.ToList();

            }
        }

        private void btnMaisVendas_Click(object sender, EventArgs e)
        {
            new FrmVendas().ShowDialog();
            BuscarVenda();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarVenda();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // abrir tela de editar
            if (VendaSelecionada != null)
            {
                using (var bd = new VendasDbContest())
                {
                    var venda = bd.Vendas.Find(VendaSelecionada.Id);
                    if (venda != null)
                    {
                        new FrmVendas(venda).ShowDialog();
                        BuscarVenda();
                    }
                    else
                    {
                        MessageBox.Show("Venda não encontrada.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma venda para editar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VendaSelecionada != null)
            {
                using (var bd = new VendasDbContest())
                {
                    var venda = bd.Vendas.Find(VendaSelecionada.Id);
                    if (venda != null)
                    {
                        bd.Vendas.Remove(venda);
                        bd.SaveChanges();
                        MessageBox.Show("Venda cancelada com sucesso.");
                        BuscarVenda();
                    }
                    else
                    {
                        MessageBox.Show("Venda não encontrada.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma venda para cancelar.");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void condicao()
        { 
            var isAutorizedToUpdateData = (UsuarioHelper.Funcao == "Gerente" || UsuarioHelper.Funcao == "Administrativo");

            if (isAutorizedToUpdateData)
            {
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
            }

    }
    
}
