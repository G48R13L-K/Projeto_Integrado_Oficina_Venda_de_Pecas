namespace Projeto_Integrado
{
    partial class FrmRelatorio
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
            txtPesquisa = new TextBox();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnMaisVendas = new Button();
            btnSalvar = new Button();
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(181, 23);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(564, 31);
            txtPesquisa.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnMaisVendas);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 413);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(705, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnMaisVendas
            // 
            btnMaisVendas.Location = new Point(6, 47);
            btnMaisVendas.Name = "btnMaisVendas";
            btnMaisVendas.Size = new Size(140, 34);
            btnMaisVendas.TabIndex = 1;
            btnMaisVendas.Text = "Nova Venda";
            btnMaisVendas.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(596, 373);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 34);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(811, 259);
            dataGridView1.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(790, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(55, 34);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(847, 512);
            Controls.Add(groupBox1);
            Controls.Add(btnFechar);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRelatorio";
            Text = "FrmRelatorio";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPesquisa;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnMaisVendas;
        private Button btnSalvar;
        private DataGridView dataGridView1;
        private Button btnFechar;
    }
}