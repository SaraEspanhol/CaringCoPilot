namespace Prototipov1
{
    partial class TelaRelatorioControleFinanceiro
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
            this.gBoxRelatorio = new System.Windows.Forms.GroupBox();
            this.checkSaida = new System.Windows.Forms.CheckBox();
            this.checkEntrada = new System.Windows.Forms.CheckBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDataCadastroEntrada = new System.Windows.Forms.TextBox();
            this.lbDataCadastroEntrada = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.lbIncluir = new System.Windows.Forms.Label();
            this.gBoxRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxRelatorio
            // 
            this.gBoxRelatorio.Controls.Add(this.lbIncluir);
            this.gBoxRelatorio.Controls.Add(this.checkSaida);
            this.gBoxRelatorio.Controls.Add(this.checkEntrada);
            this.gBoxRelatorio.Controls.Add(this.btRelatorio);
            this.gBoxRelatorio.Controls.Add(this.lbDataFinal);
            this.gBoxRelatorio.Controls.Add(this.txtDataFinal);
            this.gBoxRelatorio.Controls.Add(this.dataGridView1);
            this.gBoxRelatorio.Controls.Add(this.txtDataCadastroEntrada);
            this.gBoxRelatorio.Controls.Add(this.lbDataCadastroEntrada);
            this.gBoxRelatorio.Controls.Add(this.btMenuInicial);
            this.gBoxRelatorio.Location = new System.Drawing.Point(12, 12);
            this.gBoxRelatorio.Name = "gBoxRelatorio";
            this.gBoxRelatorio.Size = new System.Drawing.Size(515, 283);
            this.gBoxRelatorio.TabIndex = 1;
            this.gBoxRelatorio.TabStop = false;
            this.gBoxRelatorio.Text = "Relatório";
            // 
            // checkSaida
            // 
            this.checkSaida.AutoSize = true;
            this.checkSaida.Location = new System.Drawing.Point(399, 65);
            this.checkSaida.Name = "checkSaida";
            this.checkSaida.Size = new System.Drawing.Size(55, 17);
            this.checkSaida.TabIndex = 20;
            this.checkSaida.Text = "Saída";
            this.checkSaida.UseVisualStyleBackColor = true;
            // 
            // checkEntrada
            // 
            this.checkEntrada.AutoSize = true;
            this.checkEntrada.Location = new System.Drawing.Point(313, 65);
            this.checkEntrada.Name = "checkEntrada";
            this.checkEntrada.Size = new System.Drawing.Size(63, 17);
            this.checkEntrada.TabIndex = 19;
            this.checkEntrada.Text = "Entrada";
            this.checkEntrada.UseVisualStyleBackColor = true;
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(309, 251);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 26);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Extrair";
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(310, 158);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lbDataFinal.TabIndex = 15;
            this.lbDataFinal.Text = "Data Final";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(376, 155);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(129, 20);
            this.txtDataFinal.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 258);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtDataCadastroEntrada
            // 
            this.txtDataCadastroEntrada.Location = new System.Drawing.Point(376, 123);
            this.txtDataCadastroEntrada.Name = "txtDataCadastroEntrada";
            this.txtDataCadastroEntrada.Size = new System.Drawing.Size(129, 20);
            this.txtDataCadastroEntrada.TabIndex = 7;
            // 
            // lbDataCadastroEntrada
            // 
            this.lbDataCadastroEntrada.AutoSize = true;
            this.lbDataCadastroEntrada.Location = new System.Drawing.Point(310, 126);
            this.lbDataCadastroEntrada.Name = "lbDataCadastroEntrada";
            this.lbDataCadastroEntrada.Size = new System.Drawing.Size(60, 13);
            this.lbDataCadastroEntrada.TabIndex = 2;
            this.lbDataCadastroEntrada.Text = "Data Inicial";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.Location = new System.Drawing.Point(410, 251);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(95, 26);
            this.btMenuInicial.TabIndex = 1;
            this.btMenuInicial.Text = "Menu Inicial";
            this.btMenuInicial.UseVisualStyleBackColor = true;
            // 
            // lbIncluir
            // 
            this.lbIncluir.AutoSize = true;
            this.lbIncluir.Location = new System.Drawing.Point(310, 32);
            this.lbIncluir.Name = "lbIncluir";
            this.lbIncluir.Size = new System.Drawing.Size(98, 13);
            this.lbIncluir.TabIndex = 21;
            this.lbIncluir.Text = "Incluir no Relatório:";
            // 
            // TelaRelatorioControleFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.gBoxRelatorio);
            this.Name = "TelaRelatorioControleFinanceiro";
            this.Text = "CaringCoPilot";
            this.gBoxRelatorio.ResumeLayout(false);
            this.gBoxRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRelatorio;
        private System.Windows.Forms.CheckBox checkSaida;
        private System.Windows.Forms.CheckBox checkEntrada;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDataCadastroEntrada;
        private System.Windows.Forms.Label lbDataCadastroEntrada;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Label lbIncluir;
    }
}