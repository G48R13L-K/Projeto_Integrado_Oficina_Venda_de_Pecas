namespace Projeto_Integrado
{
    partial class FrmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            label1 = new Label();
            txtPesquisa = new TextBox();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnMaisVendas = new Button();
            btnEditar = new Button();
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(24, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(114, 18);
            txtPesquisa.Margin = new Padding(2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(640, 27);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnMaisVendas);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(10, 49);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(881, 443);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Relatório de Vendas";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Enabled = false;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(716, 385);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 44);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Excluir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMaisVendas
            // 
            btnMaisVendas.BackColor = Color.Yellow;
            btnMaisVendas.FlatAppearance.BorderSize = 0;
            btnMaisVendas.FlatStyle = FlatStyle.Flat;
            btnMaisVendas.ForeColor = Color.Black;
            btnMaisVendas.Location = new Point(14, 385);
            btnMaisVendas.Margin = new Padding(2);
            btnMaisVendas.Name = "btnMaisVendas";
            btnMaisVendas.Size = new Size(182, 44);
            btnMaisVendas.TabIndex = 1;
            btnMaisVendas.Text = "Nova Venda";
            btnMaisVendas.UseVisualStyleBackColor = false;
            btnMaisVendas.Click += btnMaisVendas_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 192, 0);
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(539, 385);
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
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(5, 31);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(872, 350);
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
            btnFechar.ForeColor = SystemColors.AppWorkspace;
            btnFechar.Location = new Point(773, 1);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(44, 55);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmRelatorio
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
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRelatorio";
            Load += FrmRelatorio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPesquisa;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnMaisVendas;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private Button btnFechar;
    }
}