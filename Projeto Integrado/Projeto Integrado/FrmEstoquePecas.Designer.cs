namespace Projeto_Integrado
{
    partial class FrmEstoquePecas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoquePecas));
            groupBox1 = new GroupBox();
            btnPdf = new Button();
            btnExcluir = new Button();
            btnIncuirPecas = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            txtPesquisa = new TextBox();
            label1 = new Label();
            pecaBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomePecaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoPecaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoPecaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadePecaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pecaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnPdf);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnIncuirPecas);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(9, 45);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(882, 447);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estoque de Peças";
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.MediumAquamarine;
            btnPdf.ForeColor = SystemColors.ActiveCaptionText;
            btnPdf.Location = new Point(216, 386);
            btnPdf.Margin = new Padding(2);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(121, 47);
            btnPdf.TabIndex = 7;
            btnPdf.Text = "Salvar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Enabled = false;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 14F);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(712, 385);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(146, 44);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncuirPecas
            // 
            btnIncuirPecas.BackColor = Color.Yellow;
            btnIncuirPecas.FlatAppearance.BorderSize = 0;
            btnIncuirPecas.FlatStyle = FlatStyle.Flat;
            btnIncuirPecas.Font = new Font("Segoe UI", 12F);
            btnIncuirPecas.ForeColor = Color.Black;
            btnIncuirPecas.Location = new Point(23, 385);
            btnIncuirPecas.Margin = new Padding(2);
            btnIncuirPecas.Name = "btnIncuirPecas";
            btnIncuirPecas.Size = new Size(182, 44);
            btnIncuirPecas.TabIndex = 1;
            btnIncuirPecas.Text = "Incluir Pecas";
            btnIncuirPecas.UseVisualStyleBackColor = false;
            btnIncuirPecas.Click += btnIncuirPecas_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 192, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(547, 385);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(146, 44);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomePecaDataGridViewTextBoxColumn, descricaoPecaDataGridViewTextBoxColumn, precoPecaDataGridViewTextBoxColumn, quantidadePecaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pecaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(8, 35);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(860, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 12F);
            btnFechar.Location = new Point(838, 13);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(51, 44);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI", 12F);
            txtPesquisa.Location = new Point(115, 15);
            txtPesquisa.Margin = new Padding(2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(623, 34);
            txtPesquisa.TabIndex = 5;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 3;
            label1.Text = "Pesquisa";
            // 
            // pecaBindingSource
            // 
            pecaBindingSource.DataSource = typeof(Peca);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomePecaDataGridViewTextBoxColumn
            // 
            nomePecaDataGridViewTextBoxColumn.DataPropertyName = "NomePeca";
            nomePecaDataGridViewTextBoxColumn.HeaderText = "NomePeca";
            nomePecaDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomePecaDataGridViewTextBoxColumn.Name = "nomePecaDataGridViewTextBoxColumn";
            nomePecaDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoPecaDataGridViewTextBoxColumn
            // 
            descricaoPecaDataGridViewTextBoxColumn.DataPropertyName = "DescricaoPeca";
            descricaoPecaDataGridViewTextBoxColumn.HeaderText = "DescricaoPeca";
            descricaoPecaDataGridViewTextBoxColumn.MinimumWidth = 6;
            descricaoPecaDataGridViewTextBoxColumn.Name = "descricaoPecaDataGridViewTextBoxColumn";
            descricaoPecaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoPecaDataGridViewTextBoxColumn
            // 
            precoPecaDataGridViewTextBoxColumn.DataPropertyName = "PrecoPeca";
            precoPecaDataGridViewTextBoxColumn.HeaderText = "PrecoPeca";
            precoPecaDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoPecaDataGridViewTextBoxColumn.Name = "precoPecaDataGridViewTextBoxColumn";
            precoPecaDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadePecaDataGridViewTextBoxColumn
            // 
            quantidadePecaDataGridViewTextBoxColumn.DataPropertyName = "QuantidadePeca";
            quantidadePecaDataGridViewTextBoxColumn.HeaderText = "QuantidadePeca";
            quantidadePecaDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadePecaDataGridViewTextBoxColumn.Name = "quantidadePecaDataGridViewTextBoxColumn";
            quantidadePecaDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmEstoquePecas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_08_18_at_21_17_26;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 503);
            Controls.Add(groupBox1);
            Controls.Add(btnFechar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEstoquePecas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstoquePecas";
            Load += FrmEstoquePecas_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pecaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExcluir;
        private Button btnIncuirPecas;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private Button btnFechar;
        private TextBox txtPesquisa;
        private Label label1;
        private Button btnPdf;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomePecaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoPecaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoPecaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadePecaDataGridViewTextBoxColumn;
        private BindingSource pecaBindingSource;
    }
}