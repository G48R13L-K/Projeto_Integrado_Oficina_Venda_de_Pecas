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

        public FrmEstoquePecas(Peca pecaSelecionada)
        {
            InitializeComponent();
            BuscarPecas();
            condicao();
        }

        public FrmEstoquePecas()
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
            BuscarPecas();
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
                pecaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Peca;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Enabled == true)
            { var confirmar= MessageBox.Show("Deseja editar esta peça?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.No)
                {
                    if (pecaSelecionada != null)
                    {
                        var frmCadastros = new FrmCadastrosPecas(pecaSelecionada);
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
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (btnExcluir.Enabled == true)
            {
                if (pecaSelecionada != null)
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir esta peça?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        using (var banco = new VendasDbContest())
                        {
                            var pecaParaExcluir = banco.Pecas.Find(pecaSelecionada.Id);
                            banco.Pecas.Remove(pecaParaExcluir);
                            banco.SaveChanges();
                            MessageBox.Show("Peça excluída com sucesso!");
                            BuscarPecas();
                            pecaSelecionada = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma peça para excluir.");
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

        private void FrmEstoquePecas_Load(object sender, EventArgs e)
        {
            BuscarPecas();
        }
    }
}
