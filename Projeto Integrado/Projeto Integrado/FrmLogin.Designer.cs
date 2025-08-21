namespace Projeto_Integrado
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtUsuario = new TextBox();
            btnEntrar = new Button();
            btnFechar = new Button();
            maskedSenha = new MaskedTextBox();
            lblSenha = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 529);
            panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(529, 137);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(367, 44);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuário";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(638, 363);
            btnEntrar.Margin = new Padding(4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(150, 57);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(918, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(56, 34);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // maskedSenha
            // 
            maskedSenha.Font = new Font("Arial Narrow", 16F);
            maskedSenha.Location = new Point(529, 257);
            maskedSenha.Name = "maskedSenha";
            maskedSenha.Size = new Size(368, 44);
            maskedSenha.TabIndex = 2;
            maskedSenha.UseSystemPasswordChar = true;
            maskedSenha.Enter += maskedSenha_Enter;
            maskedSenha.Leave += maskedSenha_Leave;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.White;
            lblSenha.Font = new Font("Arial Narrow", 16F);
            lblSenha.Location = new Point(529, 260);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(95, 37);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 404);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(975, 529);
            Controls.Add(lblSenha);
            Controls.Add(maskedSenha);
            Controls.Add(btnFechar);
            Controls.Add(btnEntrar);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmLogin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private Button btnEntrar;
        private Button btnFechar;
        private MaskedTextBox maskedSenha;
        private Label lblSenha;
        private PictureBox pictureBox1;
    }
}
