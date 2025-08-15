namespace Projeto_Integrado
{
    partial class FrmPrincipal
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
            btnRelatorio = new Button();
            btnPecas = new Button();
            btnEstoqui = new Button();
            btnCadastros = new Button();
            btnClientes = new Button();
            btnVendas = new Button();
            btnFechar = new Button();
            labelBemvindo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRelatorio);
            groupBox1.Controls.Add(btnPecas);
            groupBox1.Controls.Add(btnEstoqui);
            groupBox1.Controls.Add(btnCadastros);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnVendas);
            groupBox1.Location = new Point(16, 129);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(873, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.White;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Location = new Point(40, 246);
            btnRelatorio.Margin = new Padding(4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(218, 90);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.TabStop = false;
            btnRelatorio.Text = "Relatório de Vendas";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnPecas
            // 
            btnPecas.BackColor = Color.White;
            btnPecas.FlatAppearance.BorderSize = 0;
            btnPecas.FlatStyle = FlatStyle.Flat;
            btnPecas.Location = new Point(613, 96);
            btnPecas.Margin = new Padding(4);
            btnPecas.Name = "btnPecas";
            btnPecas.Size = new Size(218, 90);
            btnPecas.TabIndex = 2;
            btnPecas.Text = "Peças";
            btnPecas.UseVisualStyleBackColor = false;
            btnPecas.Click += btnPecas_Click;
            // 
            // btnEstoqui
            // 
            btnEstoqui.BackColor = Color.White;
            btnEstoqui.FlatAppearance.BorderSize = 0;
            btnEstoqui.FlatStyle = FlatStyle.Flat;
            btnEstoqui.Location = new Point(613, 246);
            btnEstoqui.Margin = new Padding(4);
            btnEstoqui.Name = "btnEstoqui";
            btnEstoqui.Size = new Size(218, 90);
            btnEstoqui.TabIndex = 1;
            btnEstoqui.Text = "Estoque";
            btnEstoqui.UseVisualStyleBackColor = false;
            btnEstoqui.Click += btnEstoqui_Click;
            // 
            // btnCadastros
            // 
            btnCadastros.BackColor = Color.White;
            btnCadastros.FlatAppearance.BorderSize = 0;
            btnCadastros.FlatStyle = FlatStyle.Flat;
            btnCadastros.Location = new Point(325, 96);
            btnCadastros.Margin = new Padding(4);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(218, 90);
            btnCadastros.TabIndex = 1;
            btnCadastros.Text = "Cadastros";
            btnCadastros.UseVisualStyleBackColor = false;
            btnCadastros.Click += btnCadastros_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(325, 246);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(218, 90);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.White;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 14F);
            btnVendas.Location = new Point(40, 96);
            btnVendas.Margin = new Padding(4);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(218, 90);
            btnVendas.TabIndex = 0;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(823, 0);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(66, 59);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // labelBemvindo
            // 
            labelBemvindo.AutoSize = true;
            labelBemvindo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBemvindo.Location = new Point(164, 14);
            labelBemvindo.Name = "labelBemvindo";
            labelBemvindo.Size = new Size(0, 37);
            labelBemvindo.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(902, 503);
            Controls.Add(labelBemvindo);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnClientes;
        private Button btnVendas;
        private Button btnRelatorio;
        private Button btnPecas;
        private Button btnFechar;
        private int btnFechar_Click;
        private Label labelBemvindo;
        private Button btnCadastros;
        private Button btnEstoqui;
    }
}