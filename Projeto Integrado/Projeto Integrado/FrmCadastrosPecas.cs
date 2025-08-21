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
    public partial class FrmCadastrosPecas : Form
    {
        Peca? PecaSelecionada;
       
        public FrmCadastrosPecas()
        {
            InitializeComponent();
        }

        public FrmCadastrosPecas(Peca pecaSelecionada)
        {
            InitializeComponent();
            PecaSelecionada = pecaSelecionada;
            CarregarPecas();
        }

        private void CarregarPecas()
        {
            using (var bd = new VendasDbContest())
            {
                if (PecaSelecionada != null)
                {
                    var peca = bd.Pecas.FirstOrDefault(p => p.Id == PecaSelecionada.Id);
                    if (peca != null)
                    {
                        txtNomePeca.Text = peca.NomePeca;
                        txtDescricaoPeca.Text = peca.DescricaoPeca;
                        txtValorPeca.Text = peca.PrecoPeca.ToString();
                        txtQuantidadePeca.Text = peca.QuantidadePeca.ToString();
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (PecaSelecionada == null)
            {
                CadastrarUmaNovaPeca();
            }
            else
            {
                ActualizarPeca();
            }

        }

        private void ActualizarPeca()
        {
            using (var banco = new VendasDbContest())
            {
                string nomePeca = txtNomePeca.Text;
                string descricaoPeca = txtDescricaoPeca.Text;
                decimal precoPeca = decimal.Parse(txtValorPeca.Text);
                int quantidadePeca = int.Parse(txtQuantidadePeca.Text);
                var pecaNova = banco.Pecas.First(p => p.Id == PecaSelecionada.Id);

                pecaNova.NomePeca = txtNomePeca.Text;
                pecaNova.DescricaoPeca = txtDescricaoPeca.Text;
                pecaNova.PrecoPeca = decimal.Parse(txtValorPeca.Text);
                pecaNova.QuantidadePeca = int.Parse(txtQuantidadePeca.Text);

                banco.Pecas.Add(pecaNova);
                banco.SaveChanges();
                MessageBox.Show("Peça Actualizada com sucesso!");
                CarregarPecas();
                this.Close();
            }
        }





        private void CadastrarUmaNovaPeca()
        {
            using (var banco = new VendasDbContest())
            {
                string nomePeca = txtNomePeca.Text;
                string descricaoPeca = txtDescricaoPeca.Text;
                decimal precoPeca = decimal.Parse(txtValorPeca.Text);
                int quantidadePeca = int.Parse(txtQuantidadePeca.Text);
                var novaPeca = new Peca()
                {
                    NomePeca = nomePeca,
                    DescricaoPeca = descricaoPeca,
                    PrecoPeca = precoPeca,
                    QuantidadePeca = quantidadePeca
                };

                banco.Pecas.Add(novaPeca);
                banco.SaveChanges();
                MessageBox.Show("Peça Cadastrada com sucesso!");
                CarregarPecas();
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
        

