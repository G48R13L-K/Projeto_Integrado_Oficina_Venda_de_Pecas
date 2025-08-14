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
        VendaSelecionada? VendaSelecionada;
        public FrmRelatorio()
        {
            InitializeComponent();
            BuscarVenda();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            BuscarVenda();
           
        }

        private void BuscarVenda()
        {
            using (var bd = new VendasDbContest())
            {
                var Venda = bd.Vendas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    Venda = Venda.Where(u => u.Id.Equals(txtPesquisa.Text) ||
                                                    u.ClienteId.Equals(txtPesquisa.Text)||
                                                    u.DataVenda.Equals(txtPesquisa.Text));

                }
                dataGridView1.DataSource = Venda.ToList();

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
                var frmVendas = new FrmVendas(VendaSelecionada);
                frmVendas.ShowDialog();
                BuscarVenda();
                VendaSelecionada = null;

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
                var confirmResult = MessageBox.Show("Tem certeza que deseja cancelar esta venda?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var bd = new VendasDbContest())
                    {
                        bd.Vendas.Remove(VendaSelecionada);
                        bd.SaveChanges();
                        MessageBox.Show("Venda cancelada com sucesso.");
                        BuscarVenda();
                        VendaSelecionada = null;
                    }

                }
                else
                {
                    
                    return;
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

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {   
                VendaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as VendaSelecionada;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;

            }


        }
    }
}
