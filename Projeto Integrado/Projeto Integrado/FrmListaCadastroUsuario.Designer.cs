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
            groupBox1 = new GroupBox();
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
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnMaisCadastro);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(16, 97);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1086, 529);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Location = new Point(916, 477);
            btnExcluir.Margin = new Padding(4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(146, 44);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnCancelar_Click;
            // 
            // btnMaisCadastro
            // 
            btnMaisCadastro.BackColor = Color.Yellow;
            btnMaisCadastro.FlatAppearance.BorderSize = 0;
            btnMaisCadastro.FlatStyle = FlatStyle.Flat;
            btnMaisCadastro.Location = new Point(8, 60);
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
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(775, 477);
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
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 111);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1054, 358);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(185, 15);
            txtPesquisa.Margin = new Padding(4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(778, 39);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 3;
            label1.Text = "Pesquisa";
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1061, 7);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(51, 44);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmListaCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1113, 643);
            Controls.Add(groupBox1);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(btnFechar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmListaCadastroUsuario";
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
    }
}