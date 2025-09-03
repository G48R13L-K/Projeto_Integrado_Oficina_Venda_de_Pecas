using System.Data;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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
                dataGridView1.DataSource = pecas.OrderBy(s => s.NomePeca).ToList();

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
                if (confirmar == DialogResult.Yes)
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community; // Defina a licença antes de tudo

            SaveFileDialog salvarDialog = new SaveFileDialog();
            salvarDialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            salvarDialog.FileName = "RelatorioDeEstoqui.pdf";

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
        private byte[] GerarRelatorioDeVendas()
        {
            // 1. Obter os dados fora do layout
            List<Peca> pecas;
            using (var bd = new VendasDbContest())
            {
                pecas = bd.Pecas.ToList();
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
                        .Text("Relatório de Estoque")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    // Conteúdo
                    page.Content().PaddingVertical(10).Table(table =>
                    {
                        // Define as colunas (5 colunas)
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(40);  // ID
                            columns.RelativeColumn();    // NomePeca
                            columns.RelativeColumn();    // DescricaoPeca
                            columns.ConstantColumn(80);  // PrecoPeca
                            columns.ConstantColumn(100); // QuantidadePeca
                        });

                        // Cabeçalho da tabela
                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("ID");
                            header.Cell().Element(CellStyle).Text("NomePeca");
                            header.Cell().Element(CellStyle).Text("DescricaoPeca");
                            header.Cell().Element(CellStyle).AlignRight().Text("QuantidadePeca");
                            header.Cell().Element(CellStyle).AlignRight().Text("PrecoPeca");
                       



                        });

                        // Linhas de dados
                        foreach (var pescas in pecas)
                        {
                            table.Cell().Element(CellData).Text(pescas.Id.ToString());
                            table.Cell().Element(CellData).Text(pescas?.NomePeca ?? "-");
                            table.Cell().Element(CellData).Text(pescas?.DescricaoPeca?? "-");
                            table.Cell().Element(CellData).AlignRight().Text(pescas.QuantidadePeca.ToString());
                            table.Cell().Element(CellData).AlignRight().Text($"R$ {pescas.PrecoPeca:F2}");
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
        
    

