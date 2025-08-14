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
    public partial class FrmVendas : Form

    {
        Venda? VendaSelecionada;
        private Venda _Vendas;
        public FrmVendas()
        {
            InitializeComponent();
            CarregarCombobox();

        }
        public FrmVendas(Venda venda)
        {
            VendaSelecionada = venda;
            if (venda != null)
            {
                // Preencher os campos com os dados da venda selecionada
                PreencherCampos();
                CarregarPecas();
            }
        }

        private void CarregarPecas()
        {
            var pecas = new List<Peca>()
            {

            };
            using (var bd = new VendasDbContest())
            {
                // Carregar peças do banco de dados
                pecas = bd.Pecas.ToList();
            }
            cbxPeca.DataSource = pecas;
            cbxPeca.DisplayMember = "NomePeca"; // Nome da peça a ser exibido no combobox
            cbxPeca.ValueMember = "Id"; // Id da peça a ser usado como valor do combobox
            cbxPeca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPeca.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void CarregarCombobox()
        {
            List<Usuario> clientes = new List<Usuario>()
            {

            };
            using (var bd = new VendasDbContest())
            {
                // Carregar clientes do banco de dados
                clientes = bd.Usuario.ToList();
            }
            CBXCliente.DataSource = clientes;
            CBXCliente.DisplayMember = "NomeCliente"; // Nome do cliente a ser exibido no combobox
            CBXCliente.ValueMember = "Id"; // Id do cliente a ser usado como valor do combobox
            CBXCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBXCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            List<Peca> pecas = new List<Peca>()
            {

            };
            using (var bd = new VendasDbContest())
            {
                // Carregar peças do banco de dados
                pecas = bd.Pecas.ToList();
            }
            cbxPeca.DataSource = pecas;
            cbxPeca.DisplayMember = "NomePeca"; // Nome da peça a ser exibido no combobox
            cbxPeca.ValueMember = "Id"; // Id da peça a ser usado como valor do combobox
            cbxPeca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPeca.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void PreencherCampos()
        {
            // Verifica se a venda selecionada é nula
            // preencher campos
            if (VendaSelecionada != null)
            {
                // carregar combodo cliente consultado pelo id do cliente da venda selecionada
                using (var bd = new VendasDbContest())
                {
                    var cliente = bd.Usuario.Find(VendaSelecionada.ClienteId);
                    if (cliente != null)
                    {
                        CBXCliente.Text = cliente.NomeCliente;
                    }
                    var peca = bd.Pecas.Find(VendaSelecionada.PecaId);
                    cbxPeca.Text = peca.NomePeca;
                }


            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_Vendas == null)
            {
                // Se a venda não existe, cria uma nova
                Cadastravenda();
            }
            else
            {

                // Se a venda já existe, atualiza
                ActualizarVenda();
            }

        }

        private void ActualizarVenda()
        {

            {
                using (var banco = new VendasDbContest())
                {

                    string nomeCliente = CBXCliente.Text;
                    string nomePeca = cbxPeca.Text;
                    int quantidade = int.Parse(txtQuantidadde.Text);
                    DateTime dataVenda = dataTime.Value;

                    var novavendas = banco.Vendas.First(x => x.Id == _Vendas.Id);

                    novavendas.ClienteId = 0;
                    novavendas.PecaId = 0;
                    novavendas.Quantidade = quantidade;
                    novavendas.DataVenda = dataVenda;

                    banco.Vendas.Update(novavendas);
                    banco.SaveChanges();
                    MessageBox.Show("Senha cadastrada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();



                }




            }
                ;
        }

        private void Cadastravenda()
        {
            using (var banco = new VendasDbContest())
            {
                string nomeCliente = CBXCliente.Text;
                string nomePeca = cbxPeca.Text;
                int quantidade = int.Parse(txtQuantidadde.Text);
                DateTime dataVenda = dataTime.Value;

                var clienteSelecionado = (Usuario)CBXCliente.SelectedItem;

                if (clienteSelecionado == null || clienteSelecionado.Id == 0)
                {
                    MessageBox.Show("Selecione um cliente válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var pecaSelecionada = (Peca)cbxPeca.SelectedItem;
                if (pecaSelecionada == null || pecaSelecionada.Id == 0)
                {
                    MessageBox.Show("Selecione uma peça válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var novavendas = new Venda()
                {
                    // obter id do cbx

                    ClienteId = clienteSelecionado.Id,
                    PecaId = pecaSelecionada.Id,
                    Quantidade = quantidade,
                    DataVenda = dataVenda
                };
                banco.Vendas.Update(novavendas);
                banco.SaveChanges();
                MessageBox.Show("Venda realizada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            PreencherCampos();
        }
    }

}
