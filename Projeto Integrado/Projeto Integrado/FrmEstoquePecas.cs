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
    public partial class FrmEstoquePecas : Form
    {
        Peca? pecaSelecionada;

        public FrmEstoquePecas()
        {
            InitializeComponent();
            BuscarPecas();
            condicao();
        }

        public FrmEstoquePecas(Peca pecaSelecionada)
        {
            InitializeComponent();
            BuscarPecas();
            condicao();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncuirPecas_Click(object sender, EventArgs e)
        {
            new FrmCadastrosPecas().ShowDialog();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            BuscarPecas();
        }

        private void BuscarPecas()
        {
            using (var bd = new VendasDbContest())
            {
                var pecas = bd.Pecas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    pecas = pecas.Where(u => u.NomePeca.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = pecas.ToList();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var pecaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Peca;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled == true)
            {
                if (pecaSelecionada != null)
                {
                    var frmCadastros = new FrmEstoquePecas();
                    frmCadastros.ShowDialog();

                    BuscarPecas();
                    pecaSelecionada = null;

                }
                else
                {
                    MessageBox.Show("Selecione uma peça para editar.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnExcluir.Enabled==true)
            {
              
                    using (var banco = new VendasDbContest())
                    {
                        var pecaParaExcluir = banco.Pecas.FirstOrDefault(p => p.Id == pecaSelecionada.Id);
                        if (pecaParaExcluir != null)
                        {
                            banco.Pecas.Remove(pecaParaExcluir);
                            banco.SaveChanges();
                            MessageBox.Show("Peça excluída com sucesso!");
                            BuscarPecas();
                            pecaSelecionada = null;
                        }
                        else
                        {
                            MessageBox.Show("Selecione uma peça para excluir.");
                        }
                
                }
                
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
            else
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
               
            }

        }
    }
}
