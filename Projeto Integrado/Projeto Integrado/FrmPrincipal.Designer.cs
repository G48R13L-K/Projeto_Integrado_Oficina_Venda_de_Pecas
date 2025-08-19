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
            btnFechar = new Button();
            labelBemvindo = new Label();
            btnRelatorio = new Button();
            btnPecas = new Button();
            btnEstoqui = new Button();
            btnCadastros = new Button();
            btnClientes = new Button();
            btnVendas = new Button();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(810, 13);
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
            labelBemvindo.BackColor = Color.Transparent;
            labelBemvindo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBemvindo.ForeColor = SystemColors.AppWorkspace;
            labelBemvindo.Location = new Point(295, 13);
            labelBemvindo.Name = "labelBemvindo";
            labelBemvindo.Size = new Size(0, 37);
            labelBemvindo.TabIndex = 5;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.White;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnRelatorio.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Location = new Point(58, 379);
            btnRelatorio.Margin = new Padding(4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(218, 90);
            btnRelatorio.TabIndex = 11;
            btnRelatorio.TabStop = false;
            btnRelatorio.Text = "Relatório de Vendas";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnPecas
            // 
            btnPecas.BackColor = Color.White;
            btnPecas.FlatAppearance.BorderSize = 0;
            btnPecas.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnPecas.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnPecas.FlatStyle = FlatStyle.Flat;
            btnPecas.Location = new Point(631, 229);
            btnPecas.Margin = new Padding(4);
            btnPecas.Name = "btnPecas";
            btnPecas.Size = new Size(218, 90);
            btnPecas.TabIndex = 10;
            btnPecas.Text = "Peças";
            btnPecas.UseVisualStyleBackColor = false;
            btnPecas.Click += btnPecas_Click;
            // 
            // btnEstoqui
            // 
            btnEstoqui.BackColor = Color.White;
            btnEstoqui.FlatAppearance.BorderSize = 0;
            btnEstoqui.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnEstoqui.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnEstoqui.FlatStyle = FlatStyle.Flat;
            btnEstoqui.Location = new Point(631, 379);
            btnEstoqui.Margin = new Padding(4);
            btnEstoqui.Name = "btnEstoqui";
            btnEstoqui.Size = new Size(218, 90);
            btnEstoqui.TabIndex = 7;
            btnEstoqui.Text = "Estoque";
            btnEstoqui.UseVisualStyleBackColor = false;
            btnEstoqui.Click += btnEstoqui_Click;
            // 
            // btnCadastros
            // 
            btnCadastros.BackColor = Color.White;
            btnCadastros.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCadastros.FlatAppearance.BorderSize = 0;
            btnCadastros.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnCadastros.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnCadastros.FlatStyle = FlatStyle.Flat;
            btnCadastros.Location = new Point(343, 229);
            btnCadastros.Margin = new Padding(4);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(218, 90);
            btnCadastros.TabIndex = 8;
            btnCadastros.Text = "Cadastros";
            btnCadastros.UseVisualStyleBackColor = false;
            btnCadastros.Click += btnCadastros_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.White;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnClientes.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(343, 379);
            btnClientes.Margin = new Padding(4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(218, 90);
            btnClientes.TabIndex = 9;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.White;
            btnVendas.FlatAppearance.BorderColor = Color.DimGray;
            btnVendas.FlatAppearance.BorderSize = 2;
            btnVendas.FlatAppearance.MouseDownBackColor = SystemColors.ButtonShadow;
            btnVendas.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 14F);
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(58, 229);
            btnVendas.Margin = new Padding(4);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(218, 90);
            btnVendas.TabIndex = 6;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_08_18_at_21_39_02;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 503);
            Controls.Add(btnRelatorio);
            Controls.Add(btnPecas);
            Controls.Add(btnEstoqui);
            Controls.Add(btnCadastros);
            Controls.Add(btnClientes);
            Controls.Add(btnVendas);
            Controls.Add(labelBemvindo);
            Controls.Add(btnFechar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFechar;
        private int btnFechar_Click;
        private Label labelBemvindo;
        private Button btnRelatorio;
        private Button btnPecas;
        private Button btnEstoqui;
        private Button btnCadastros;
        private Button btnClientes;
        private Button btnVendas;
    }
}