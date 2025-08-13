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
        public FrmEstoquePecas()
        {
            InitializeComponent();
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
    }
}
