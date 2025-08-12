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
        }

        public FrmVendas(Venda venda)
        {
            InitializeComponent();

            VendaSelecionada = venda;

            PreencherCampos();
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
                        txtCliente.Text = cliente.NomeCliente;
                    }
                    var peca = bd.Pecas.Find(VendaSelecionada.PecaId);
                    txtPeca.Text = peca.NomePeca;
                }


            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cadastravenda();
            ActualizarVenda();

        }

        private void ActualizarVenda()
        {

            {
                using (var banco = new VendasDbContest())
                {
                    if (VendaSelecionada != null)
                    {
                        _Vendas = banco.Vendas.Find(VendaSelecionada.Id);
                        if (_Vendas != null)
                        {
                            _Vendas.ClienteId = banco.Usuario.FirstOrDefault(c => c.NomeCliente == txtCliente.Text)?.Id ?? 0;
                            _Vendas.PecaId = banco.Pecas.FirstOrDefault(p => p.NomePeca == txtPeca.Text)?.Id ?? 0;
                            _Vendas.Quantidade = int.Parse(txtQuantidadde.Text);
                            _Vendas.DataVenda = dataTime.Value;
                            banco.Vendas.Update(_Vendas);
                            banco.SaveChanges();
                            MessageBox.Show("Venda atualizada com sucesso!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }




            }
                ;
        }

        private void Cadastravenda()
        {
            using (var banco = new VendasDbContest())
            {
                string nomeCliente = txtCliente.Text;
                string nomePeca = txtPeca.Text;
                int quantidade = int.Parse(txtQuantidadde.Text);
                DateTime dataVenda = dataTime.Value;

                var venda = banco.Vendas.First(x => x.Id == _Vendas.Id);
                banco.Vendas.Update(venda);
                banco.SaveChanges();
                MessageBox.Show("Senha cadastrada com sucesso!", "Sucesso",
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
    }

}
