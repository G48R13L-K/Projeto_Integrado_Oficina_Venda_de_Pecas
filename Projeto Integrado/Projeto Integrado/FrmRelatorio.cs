using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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
                var venda = bd.Vendas.Include(v => v.Cliente) 
                              .AsQueryable();

                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    venda = venda.Where(v =>
                        v.Id.ToString().Contains(txtPesquisa.Text) ||
                        v.Cliente.NomeCliente.Contains(txtPesquisa.Text) ||   // busca pelo nome do cliente
                        v.Peca.NomePeca.Contains(txtPesquisa.Text) || // busca pelo nome da peça
                        v.DataVenda.ToString().Contains(txtPesquisa.Text));
                }

                // Aqui você projeta os campos que quer mostrar no DataGrid
                var resultado = venda.Select(v => new
                {
                    v.Id,
                    Cliente = v.Cliente.NomeCliente,   // mostra nome em vez do ID
                    Peca = v.Peca.NomePeca, // mostra nome da peça em vez do ID
                    v.Quantidade,
                    v.DataVenda
                }).ToList();

                dataGridView1.DataSource = resultado;
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
                var confirm = MessageBox.Show("Tem certeza que deseja actualizar esta venda.","Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
                    {
                    var frmVendas = new FrmVendas(VendaSelecionada);
                    frmVendas.ShowDialog();
                    BuscarVenda();
                    VendaSelecionada = null;
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
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir esta venda?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var bd = new VendasDbContest())
                    {
                        bd.Vendas.Remove(VendaSelecionada);
                        bd.SaveChanges();
                        MessageBox.Show("Venda excluir com sucesso.");
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
                MessageBox.Show("Selecione uma venda para excluir.");
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
                var idVendaSelecionada = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                using (var bd = new VendasDbContest())
                {
                    VendaSelecionada = bd.Vendas
                        .Include(v => v.Cliente)
                        .Include(v => v.Peca)
                        .FirstOrDefault(v => v.Id == idVendaSelecionada);
                }
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;

            }


        }
    }
}
