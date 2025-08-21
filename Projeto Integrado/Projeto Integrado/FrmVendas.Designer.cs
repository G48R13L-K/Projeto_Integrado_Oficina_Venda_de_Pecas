namespace Projeto_Integrado
{
    partial class FrmVendas
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
            label1 = new Label();
            btnFechar = new Button();
            txtQuantidadde = new TextBox();
            label2 = new Label();
            label4 = new Label();
            dataTime = new DateTimePicker();
            label5 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            CBXCliente = new ComboBox();
            cbxPeca = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(45, 42);
            label1.Name = "label1";
            label1.Size = new Size(133, 24);
            label1.TabIndex = 1;
            label1.Text = "Nome do Cliente";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(769, 13);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 44);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtQuantidadde
            // 
            txtQuantidadde.Location = new Point(592, 304);
            txtQuantidadde.Margin = new Padding(3, 4, 3, 4);
            txtQuantidadde.Name = "txtQuantidadde";
            txtQuantidadde.Size = new Size(183, 30);
            txtQuantidadde.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(45, 141);
            label2.Name = "label2";
            label2.Size = new Size(47, 24);
            label2.TabIndex = 1;
            label2.Text = "Peça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(592, 276);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 1;
            label4.Text = "Quantidade";
            // 
            // dataTime
            // 
            dataTime.Location = new Point(45, 304);
            dataTime.Margin = new Padding(3, 4, 3, 4);
            dataTime.Name = "dataTime";
            dataTime.Size = new Size(345, 30);
            dataTime.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(45, 276);
            label5.Name = "label5";
            label5.Size = new Size(45, 24);
            label5.TabIndex = 3;
            label5.Text = "Data";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 192, 0);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(440, 426);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(146, 44);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(629, 426);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 44);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CBXCliente
            // 
            CBXCliente.FormattingEnabled = true;
            CBXCliente.Location = new Point(45, 79);
            CBXCliente.Name = "CBXCliente";
            CBXCliente.Size = new Size(730, 32);
            CBXCliente.TabIndex = 6;
            // 
            // cbxPeca
            // 
            cbxPeca.FormattingEnabled = true;
            cbxPeca.Location = new Point(45, 168);
            cbxPeca.Name = "cbxPeca";
            cbxPeca.Size = new Size(730, 32);
            cbxPeca.TabIndex = 7;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_08_18_at_21_17_26;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 493);
            Controls.Add(cbxPeca);
            Controls.Add(CBXCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(dataTime);
            Controls.Add(btnFechar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantidadde);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVendas";
            Load += FrmVendas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnFechar;
        private TextBox txtQuantidadde;
        private Label label2;
        private Label label4;
        private DateTimePicker dataTime;
        private Label label5;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox CBXCliente;
        private ComboBox cbxPeca;
    }
}