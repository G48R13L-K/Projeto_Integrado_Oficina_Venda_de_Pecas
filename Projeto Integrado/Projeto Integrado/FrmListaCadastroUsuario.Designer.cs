namespace Projeto_Integrado
{
    partial class FrmListaCadastroUsuario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCadastroUsuario));
            groupBox1 = new GroupBox();
            btnPdf = new Button();
            btnExcluir = new Button();
            btnMaisCadastro = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            txtPesquisa = new TextBox();
            label1 = new Label();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnPdf);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnMaisCadastro);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(13, 53);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(876, 437);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastros";
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.Yellow;
            btnPdf.ForeColor = SystemColors.ActiveCaptionText;
            btnPdf.Location = new Point(221, 383);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(139, 44);
            btnPdf.TabIndex = 7;
            btnPdf.Text = "Salvar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(712, 385);
            btnExcluir.Margin = new Padding(4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(146, 44);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnMaisCadastro
            // 
            btnMaisCadastro.BackColor = Color.Yellow;
            btnMaisCadastro.FlatAppearance.BorderSize = 0;
            btnMaisCadastro.FlatStyle = FlatStyle.Flat;
            btnMaisCadastro.ForeColor = Color.Black;
            btnMaisCadastro.Location = new Point(23, 385);
            btnMaisCadastro.Margin = new Padding(4);
            btnMaisCadastro.Name = "btnMaisCadastro";
            btnMaisCadastro.Size = new Size(182, 44);
            btnMaisCadastro.TabIndex = 1;
            btnMaisCadastro.Text = "Novo Cadastro";
            btnMaisCadastro.UseVisualStyleBackColor = false;
            btnMaisCadastro.Click += btnMaisCadastro_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 192, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(547, 385);
            btnEditar.Margin = new Padding(4);
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
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(8, 35);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(860, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(115, 15);
            txtPesquisa.Margin = new Padding(4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(623, 39);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(21, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 3;
            label1.Text = "Pesquisa";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = SystemColors.AppWorkspace;
            btnFechar.Location = new Point(838, 15);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(51, 44);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmListaCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_08_18_at_21_17_26;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 503);
            Controls.Add(groupBox1);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(btnFechar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmListaCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaCadastro";
            Load += FrmListaCadastroUsuario_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExcluir;
        private Button btnMaisCadastro;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private TextBox txtPesquisa;
        private Label label1;
        private Button btnFechar;
        private Button btnPdf;
    }
}