using System.Data;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


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
                    v.PrecoTotal,
                    v.DataVenda
                    
                }).OrderBy(s => s.DataVenda).ToList();

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
                var confirm = MessageBox.Show("Tem certeza que deseja actualizar esta venda.", "Confirmação", MessageBoxButtons.YesNo);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community; // Defina a licença antes de tudo

            SaveFileDialog salvarDialog = new SaveFileDialog();
            salvarDialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            salvarDialog.FileName = "RelatorioDeVendas.pdf";

            if (salvarDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] pdf = GerarRelatorioDeVendas(); // método acima
                    File.WriteAllBytes(salvarDialog.FileName, pdf);
                    MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar o relatório:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        static IContainer CellStyle(IContainer container) =>
                                container.DefaultTextStyle(x => x.SemiBold()).Background(Colors.Grey.Lighten2);

        static IContainer CellData(IContainer container) =>
                                container;

        public byte[] GerarRelatorioDeVendas()
        {
            // 1. Obter os dados fora do layout
            List<VendaSelecionada> vendas;
            using (var bd = new VendasDbContest())
            {
                vendas = bd.Vendas
                           .Include(v => v.Cliente)
                           .Include(v => v.Peca)
                           .ToList();
            }

            // 2. Gerar o PDF com QuestPDF
            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    // Cabeçalho
                    page.Header()
                        .Text("Relatório de Vendas")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    // Conteúdo
                    page.Content().PaddingVertical(10).Table(table =>
                    {
                        // Define as colunas (5 colunas)
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(40);  // ID
                            columns.RelativeColumn();    // Cliente
                            columns.RelativeColumn();    // Peça
                            columns.ConstantColumn(80);  // Quantidade
                            columns.ConstantColumn(100); // Data
                            columns.ConstantColumn(100);
                        });

                        // Cabeçalho da tabela
                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("ID");
                            header.Cell().Element(CellStyle).Text("Cliente");
                            header.Cell().Element(CellStyle).Text("Peça");
                            header.Cell().Element(CellStyle).AlignRight().Text("Qtd");
                            header.Cell().Element(CellStyle).AlignRight().Text("Data");
                            header.Cell().Element(CellStyle).AlignRight().Text("Preço Total");



                        });

                        // Linhas de dados
                        foreach (var venda in vendas)
                        {
                            table.Cell().Element(CellData).Text(venda.Id.ToString());
                            table.Cell().Element(CellData).Text(venda.Cliente?.NomeCliente ?? "-");
                            table.Cell().Element(CellData).Text(venda.Peca?.NomePeca ?? "-");
                            table.Cell().Element(CellData).AlignRight().Text(venda.Quantidade.ToString());
                            table.Cell().Element(CellData).AlignRight().Text(venda.DataVenda.ToString("dd/MM/yyyy"));
                            table.Cell().Element(CellData).AlignRight().Text($"R$ {venda.PrecoTotal:F2}");
                        }
                    });

                    // Rodapé
                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                            x.Span(" de ");
                            x.TotalPages();
                        });
                });
            });

            using var stream = new MemoryStream();
            documento.GeneratePdf(stream);
            return stream.ToArray();
        }
    }
}           

