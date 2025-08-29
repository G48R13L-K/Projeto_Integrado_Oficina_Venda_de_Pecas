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
            //conexão com o banco de dados
            using (var db = new VendasDbContest())
            {
                var carrinhoTemporal = db.CarrinhoTemporal.AsQueryable();
                var carrinho = db.CarrinhoTemporal.AsQueryable();
                dataGridView1.DataSource = carrinhoTemporal.ToList(); // Adicionado ToList() para materializar a consulta
                dataGridView1.Columns["Id"].Visible = false; // Oculta a coluna Id
            }
        }
    }
}
