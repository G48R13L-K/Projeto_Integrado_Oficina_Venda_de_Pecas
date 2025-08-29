namespace Projeto_Integrado
{
    partial class FrmCarrinho
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
            btncancelar = new Button();
            btnMaisCadastro = new Button();
            btnVendaTotal = new Button();
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btncancelar);
            groupBox1.Controls.Add(btnMaisCadastro);
            groupBox1.Controls.Add(btnVendaTotal);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(13, 55);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(802, 403);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastros";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.Red;
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.ForeColor = Color.Black;
            btncancelar.Location = new Point(648, 331);
            btncancelar.Margin = new Padding(4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(146, 44);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "Cancelar ";
            btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnMaisCadastro
            // 
            btnMaisCadastro.BackColor = Color.Yellow;
            btnMaisCadastro.FlatAppearance.BorderSize = 0;
            btnMaisCadastro.FlatStyle = FlatStyle.Flat;
            btnMaisCadastro.ForeColor = Color.Black;
            btnMaisCadastro.Location = new Point(28, 331);
            btnMaisCadastro.Margin = new Padding(4);
            btnMaisCadastro.Name = "btnMaisCadastro";
            btnMaisCadastro.Size = new Size(182, 44);
            btnMaisCadastro.TabIndex = 1;
            btnMaisCadastro.Text = "Adicional";
            btnMaisCadastro.UseVisualStyleBackColor = false;
            // 
            // btnVendaTotal
            // 
            btnVendaTotal.BackColor = Color.FromArgb(0, 192, 0);
            btnVendaTotal.FlatAppearance.BorderSize = 0;
            btnVendaTotal.FlatStyle = FlatStyle.Flat;
            btnVendaTotal.ForeColor = Color.Black;
            btnVendaTotal.Location = new Point(491, 331);
            btnVendaTotal.Margin = new Padding(4);
            btnVendaTotal.Name = "btnVendaTotal";
            btnVendaTotal.Size = new Size(146, 44);
            btnVendaTotal.TabIndex = 1;
            btnVendaTotal.Text = "Venta Total";
            btnVendaTotal.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 32);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(783, 279);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = SystemColors.AppWorkspace;
            btnFechar.Location = new Point(764, 14);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(51, 44);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // FrmCarrinho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 469);
            Controls.Add(groupBox1);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCarrinho";
            Text = "FrmCarrinho";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btncancelar;
        private Button btnMaisCadastro;
        private Button btnVendaTotal;
        private DataGridView dataGridView1;
        private Button btnFechar;
    }
}