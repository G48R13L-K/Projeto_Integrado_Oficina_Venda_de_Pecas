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

        private VendaSelecionada _vendaSelecionada;
        public FrmVendas()
        {
            InitializeComponent();
            CarregarCombobox();

        }
        public FrmVendas(VendaSelecionada vendaSelecionada)
        {

            _vendaSelecionada = vendaSelecionada;

            InitializeComponent();
            PreencherCampos();
            CarregarPecas();
            CarregarCombobox();


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

            // preencher campos
            if (_vendaSelecionada != null)
            {
                // carregar combodo cliente consultado pelo id do cliente da venda selecionada
                using (var bd = new VendasDbContest())
                {
                    var cliente = bd.Usuario.Find(_vendaSelecionada.ClienteId);
                    if (cliente != null)
                    {
                        CBXCliente.Text = cliente.NomeCliente;
                    }
                    var peca = bd.Pecas.Find(_vendaSelecionada.PecaId);
                    cbxPeca.Text = peca.NomePeca;
                    txtQuantidadde.Text = _vendaSelecionada.Quantidade.ToString();
                }


            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_vendaSelecionada == null)
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

                    var novavendas = banco.Vendas.First(x => x.Id == _vendaSelecionada.Id);

                    novavendas.ClienteId = Convert.ToInt32(CBXCliente.SelectedValue);
                    novavendas.PecaId = Convert.ToInt32(cbxPeca.SelectedValue);
                    novavendas.Quantidade = quantidade;
                    novavendas.DataVenda = dataVenda;


                    banco.Vendas.Update(novavendas);
                    banco.SaveChanges();
                    MessageBox.Show("Senha cadastrada com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _vendaSelecionada = null;
                    this.Close();



                }




            }
                ;
        }

        private void Cadastravenda()
        {
            using (var banco = new VendasDbContest())
            {
                if (!ValidarCampos())
                {
                    return;
                }
                string nomeCliente = CBXCliente.Text;
                string nomePeca = cbxPeca.Text;
                int quantidade = int.Parse(txtQuantidadde.Text);
                DateTime dataVenda = dataTime.Value;

              

                var clienteSelecionado = (Usuario)CBXCliente.SelectedItem;

                var pecaSelecionada = (Peca)cbxPeca.SelectedItem;
                
                var novavendas = new VendaSelecionada()
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

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            if (txtQuantidadde.Text == "")
            {
                errorProvider1.SetError(txtQuantidadde, "O campo QUANTIDADDE é obrigatório.");

            }
            var clienteSelecionado = (Usuario)CBXCliente.SelectedItem;

            if (clienteSelecionado == null || clienteSelecionado.Id == 0)
            {
                errorProvider1.SetError(CBXCliente, "Selecione um cliente válido.");
                
            }
            var pecaSelecionada = (Peca)cbxPeca.SelectedItem;
            if (pecaSelecionada == null || pecaSelecionada.Id == 0)
            {
                errorProvider1.SetError(cbxPeca, "Selecione uma peça válida.o.");               
            }
            int.TryParse(txtQuantidadde.Text, out int quantidade);
            if (quantidade <= 0)
            {
                errorProvider1.SetError(txtQuantidadde, "A quantidade deve ser maior que zero.");
            }
            if (!errorProvider1.HasErrors) return true;
            return false;

        }
    }
}
