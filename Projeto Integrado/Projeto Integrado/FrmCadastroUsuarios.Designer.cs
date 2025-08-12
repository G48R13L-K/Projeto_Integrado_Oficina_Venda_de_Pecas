namespace Projeto_Integrado
{
    partial class FrmCadastroUsuarios
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
            cmbUsuarios = new ComboBox();
            comboFuncao = new ComboBox();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnFechar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtSenha = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Items.AddRange(new object[] { "Cliente", "Funcionario" });
            cmbUsuarios.Location = new Point(31, 115);
            cmbUsuarios.Margin = new Padding(3, 4, 3, 4);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(838, 36);
            cmbUsuarios.TabIndex = 0;
            // 
            // comboFuncao
            // 
            comboFuncao.Enabled = false;
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "Gerente", "Adiministrativo", "Funcionario" });
            comboFuncao.Location = new Point(29, 636);
            comboFuncao.Margin = new Padding(3, 4, 3, 4);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(366, 36);
            comboFuncao.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(31, 201);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(838, 34);
            txtNome.TabIndex = 1;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(34, 311);
            txtCPF.Margin = new Padding(3, 4, 3, 4);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(834, 34);
            txtCPF.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 421);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(838, 34);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(31, 540);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(838, 34);
            txtTelefone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 79);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 2;
            label1.Text = "Perfil usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 162);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 275);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 386);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 504);
            label5.Name = "label5";
            label5.Size = new Size(84, 28);
            label5.TabIndex = 6;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 600);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 6;
            label6.Text = "Função";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(332, 22);
            label7.Name = "label7";
            label7.Size = new Size(136, 41);
            label7.TabIndex = 6;
            label7.Text = "Cadastro";
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(843, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(55, 34);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += this.btnFechar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(659, 701);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 44);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(773, 701);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 44);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(496, 637);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(357, 34);
            txtSenha.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(496, 600);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 6;
            label8.Text = "Senha";
            // 
            // FrmCadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(919, 757);
            Controls.Add(txtSenha);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnFechar);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(comboFuncao);
            Controls.Add(cmbUsuarios);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCadastroUsuarios";
            Text = "FrmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsuarios;
        private ComboBox comboFuncao;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnFechar;
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox txtSenha;
        private Label label8;
    }
}