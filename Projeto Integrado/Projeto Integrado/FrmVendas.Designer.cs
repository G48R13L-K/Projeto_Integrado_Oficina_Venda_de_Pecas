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
            txtPeca = new TextBox();
            txtQuantidadde = new TextBox();
            label2 = new Label();
            label4 = new Label();
            dataTime = new DateTimePicker();
            label5 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtCliente = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(157, 29);
            label1.TabIndex = 1;
            label1.Text = "Nome do Cliente";
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(606, 1);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 44);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtPeca
            // 
            txtPeca.Location = new Point(12, 155);
            txtPeca.Margin = new Padding(3, 4, 3, 4);
            txtPeca.Name = "txtPeca";
            txtPeca.Size = new Size(628, 35);
            txtPeca.TabIndex = 0;
            // 
            // txtQuantidadde
            // 
            txtQuantidadde.Location = new Point(12, 247);
            txtQuantidadde.Margin = new Padding(3, 4, 3, 4);
            txtQuantidadde.Name = "txtQuantidadde";
            txtQuantidadde.Size = new Size(628, 35);
            txtQuantidadde.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(58, 29);
            label2.TabIndex = 1;
            label2.Text = "Peça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(114, 29);
            label4.TabIndex = 1;
            label4.Text = "Quantidade";
            // 
            // dataTime
            // 
            dataTime.Location = new Point(12, 337);
            dataTime.Margin = new Padding(3, 4, 3, 4);
            dataTime.Name = "dataTime";
            dataTime.Size = new Size(436, 35);
            dataTime.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(54, 29);
            label5.TabIndex = 3;
            label5.Text = "Data";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(0, 192, 0);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(388, 391);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(124, 40);
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
            btnCancelar.Location = new Point(515, 391);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCliente
            // 
            txtCliente.FormattingEnabled = true;
            txtCliente.Location = new Point(19, 77);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(620, 37);
            txtCliente.TabIndex = 6;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(651, 453);
            Controls.Add(txtCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(dataTime);
            Controls.Add(btnFechar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantidadde);
            Controls.Add(txtPeca);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVendas";
            Text = "FrmVendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnFechar;
        private TextBox txtPeca;
        private TextBox txtQuantidadde;
        private Label label2;
        private Label label4;
        private DateTimePicker dataTime;
        private Label label5;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox txtCliente;
    }
}