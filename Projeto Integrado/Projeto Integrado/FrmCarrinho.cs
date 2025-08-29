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
    public partial class FrmCarrinho : Form
    {
        public FrmCarrinho()
        {
            InitializeComponent();
            CargarCarrinho();
        }

        private void CargarCarrinho()
        {

            using (var db = new VendasDbContest())
            {
                var usuarios = db.Usuario.AsQueryable();
              
                dataGridView1.DataSource = CarrinhoTemporal.ToList(); // Adicionado ToList() para materializar a consulta
                dataGridView1.Columns["Id"].Visible = false; // Oculta a coluna Id
                dataGridView1.Columns["Senha"].Visible = false; // Oculta a coluna Senha
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var caerrinho = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
               
            }
        }
    }
}
