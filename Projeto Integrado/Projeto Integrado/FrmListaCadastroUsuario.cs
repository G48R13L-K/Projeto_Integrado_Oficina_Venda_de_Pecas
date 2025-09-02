using System.Data;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Projeto_Integrado
{
    public partial class FrmListaCadastroUsuario : Form
    {
        Usuario? UsuarioSelecionado;
        public FrmListaCadastroUsuario()
        {
            InitializeComponent();
            CarregarUsuarios();
            condicao();
        }

        void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CarregarUsuarios()
        {
            using (var db = new VendasDbContest())
            {
                var usuarios = db.Usuario.AsQueryable();
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                {
                    usuarios = usuarios.Where(u => u.NomeCliente.ToLower().Contains(txtPesquisa.Text.ToLower()) ||
                                                   u.CPF.Contains(txtPesquisa.Text) ||
                                                   u.Funcao.Contains(txtPesquisa.Text));
                }
                dataGridView1.DataSource = usuarios.ToList(); // Adicionado ToList() para materializar a consulta
                dataGridView1.Columns["Id"].Visible = false; // Oculta a coluna Id
                dataGridView1.Columns["Senha"].Visible = false; // Oculta a coluna Senha
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
        private void btnMaisCadastro_Click(object sender, EventArgs e)
        {
            var frmCadastro = new FrmCadastroUsuarios();
            frmCadastro.ShowDialog();
            CarregarUsuarios();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                UsuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                var confirmResult = MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var db = new VendasDbContest())
                    {
                        db.Usuario.Remove(UsuarioSelecionado);
                        db.SaveChanges();
                        CarregarUsuarios();
                        MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UsuarioSelecionado = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                var comfirmar = MessageBox.Show("Deseja realmente editar este usuário?", "Confirmação", MessageBoxButtons.YesNo);
                if (comfirmar == DialogResult.Yes)
                {
                    var frmCadastro = new FrmCadastroUsuarios(UsuarioSelecionado);
                    frmCadastro.ShowDialog();
                    CarregarUsuarios();
                    UsuarioSelecionado = null;
                }

            }
            else
            {
                MessageBox.Show("Nenhum usuário selecionado para edição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FrmListaCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btnEditar.Enabled = true;
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
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community; // Defina a licença antes de tudo

            SaveFileDialog salvarDialog = new SaveFileDialog();
            salvarDialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            salvarDialog.FileName = "RelatorioCliente.pdf";

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
            List<Usuario> usuario;
            using (var bd = new VendasDbContest())
            {
                usuario = bd.Usuario.ToList();
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
                        .Text("Lista de Cliente")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    // Conteúdo
                    page.Content().PaddingVertical(10).Table(table =>
                    {
                        // Define as colunas (5 colunas)
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(40);  // ID
                            columns.RelativeColumn();    // NomeCliente
                            columns.RelativeColumn();    // CPF
                            columns.RelativeColumn();  // PrecoPeca
                            columns.RelativeColumn(); // QuantidadePeca
                        });

                        // Cabeçalho da tabela
                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("ID");
                            header.Cell().Element(CellStyle).Text("NomeCliente");
                            header.Cell().Element(CellStyle).Text("CPF");
                            header.Cell().Element(CellStyle).Text("Email");
                            header.Cell().Element(CellStyle).Text("Telefone");




                        });

                        // Linhas de dados
                        foreach (var usuario in usuario)
                        {
                            table.Cell().Element(CellData).Text(usuario.Id.ToString());
                            table.Cell().Element(CellData).Text(usuario?.NomeCliente ?? "-");
                            table.Cell().Element(CellData).Text(usuario?.CPF ?? "-");
                            table.Cell().Element(CellData).Text(usuario?.Email ?? "-");
                            table.Cell().Element(CellData).Text(usuario?.Telefone ?? "-");
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
    

    
