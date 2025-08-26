namespace Projeto_Integrado
{
    partial class FrmCadastrosPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrosPecas));
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnFechar = new Button();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtValorPeca = new TextBox();
            txtQuantidadePeca = new TextBox();
            label5 = new Label();
            txtDescricaoPeca = new TextBox();
            txtNomePeca = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(970, 515);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 44);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(805, 515);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(146, 44);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1082, -2);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(72, 44);
            btnFechar.TabIndex = 24;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 26);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(262, 41);
            label7.TabIndex = 22;
            label7.Text = "Cadastro de peças";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(26, 312);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 19;
            label4.Text = "Valor  unitário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(29, 205);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 18;
            label3.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(29, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 16;
            label1.Text = "Nome da peça";
            // 
            // txtValorPeca
            // 
            txtValorPeca.Location = new Point(26, 345);
            txtValorPeca.Margin = new Padding(4, 5, 4, 5);
            txtValorPeca.Name = "txtValorPeca";
            txtValorPeca.Size = new Size(1088, 34);
            txtValorPeca.TabIndex = 14;
            // 
            // txtQuantidadePeca
            // 
            txtQuantidadePeca.Location = new Point(26, 238);
            txtQuantidadePeca.Margin = new Padding(4, 5, 4, 5);
            txtQuantidadePeca.Name = "txtQuantidadePeca";
            txtQuantidadePeca.Size = new Size(1083, 34);
            txtQuantidadePeca.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(29, 412);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 19;
            label5.Text = "Descrição";
            // 
            // txtDescricaoPeca
            // 
            txtDescricaoPeca.Location = new Point(29, 445);
            txtDescricaoPeca.Margin = new Padding(4, 5, 4, 5);
            txtDescricaoPeca.Name = "txtDescricaoPeca";
            txtDescricaoPeca.Size = new Size(1088, 34);
            txtDescricaoPeca.TabIndex = 14;
            // 
            // txtNomePeca
            // 
            txtNomePeca.Location = new Point(29, 133);
            txtNomePeca.Margin = new Padding(4, 5, 4, 5);
            txtNomePeca.Name = "txtNomePeca";
            txtNomePeca.Size = new Size(1083, 34);
            txtNomePeca.TabIndex = 13;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCadastrosPecas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_08_18_at_21_17_26;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1140, 591);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnFechar);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtDescricaoPeca);
            Controls.Add(txtValorPeca);
            Controls.Add(txtNomePeca);
            Controls.Add(txtQuantidadePeca);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmCadastrosPecas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrosPecas";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnFechar;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtValorPeca;
        private TextBox txtQuantidadePeca;
        private Label label5;
        private TextBox txtDescricaoPeca;
        private TextBox txtNomePeca;
        private ErrorProvider errorProvider1;
    }
}