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
            btnClientes = new Button();
            btnVendas = new Button();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRelatorio);
            groupBox1.Controls.Add(btnPecas);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnVendas);
            groupBox1.Location = new Point(12, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.DarkSeaGreen;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Location = new Point(31, 192);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(168, 70);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.Text = "Relatório de Vendas";
            btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnPecas
            // 
            btnPecas.BackColor = Color.DarkSeaGreen;
            btnPecas.FlatAppearance.BorderSize = 0;
            btnPecas.FlatStyle = FlatStyle.Flat;
            btnPecas.Location = new Point(567, 192);
            btnPecas.Name = "btnPecas";
            btnPecas.Size = new Size(168, 70);
            btnPecas.TabIndex = 2;
            btnPecas.Text = "Peças";
            btnPecas.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.DarkSeaGreen;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(290, 192);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(168, 70);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.DarkSeaGreen;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 14F);
            btnVendas.Location = new Point(31, 70);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(704, 70);
            btnVendas.TabIndex = 0;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.DarkSeaGreen;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(737, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(51, 46);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnClientes;
        private Button btnVendas;
        private Button btnRelatorio;
        private Button btnPecas;
        private Button btnFechar;
        private int btnFechar_Click;
    }
}