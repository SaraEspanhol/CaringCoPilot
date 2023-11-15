namespace Prototipov1
{
    partial class MenuEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstoque));
            this.gBoxControleFinanceiro = new System.Windows.Forms.GroupBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.comboBoxNomeDoador = new System.Windows.Forms.ComboBox();
            this.lbNomeDoador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDataCadastroEntrada = new System.Windows.Forms.TextBox();
            this.lbDataCadastroEntrada = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbBazar = new System.Windows.Forms.RadioButton();
            this.rbDoacao = new System.Windows.Forms.RadioButton();
            this.gBoxControleFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxControleFinanceiro
            // 
            this.gBoxControleFinanceiro.Controls.Add(this.panel2);
            this.gBoxControleFinanceiro.Controls.Add(this.panel1);
            this.gBoxControleFinanceiro.Controls.Add(this.btFiltrar);
            this.gBoxControleFinanceiro.Controls.Add(this.comboBoxNomeDoador);
            this.gBoxControleFinanceiro.Controls.Add(this.lbNomeDoador);
            this.gBoxControleFinanceiro.Controls.Add(this.textBox1);
            this.gBoxControleFinanceiro.Controls.Add(this.lbNomeProduto);
            this.gBoxControleFinanceiro.Controls.Add(this.btRelatorio);
            this.gBoxControleFinanceiro.Controls.Add(this.lbDataFinal);
            this.gBoxControleFinanceiro.Controls.Add(this.txtDataFinal);
            this.gBoxControleFinanceiro.Controls.Add(this.dataGridView1);
            this.gBoxControleFinanceiro.Controls.Add(this.txtDataCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.lbDataCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.btMenuInicial);
            this.gBoxControleFinanceiro.Location = new System.Drawing.Point(12, 12);
            this.gBoxControleFinanceiro.Name = "gBoxControleFinanceiro";
            this.gBoxControleFinanceiro.Size = new System.Drawing.Size(515, 283);
            this.gBoxControleFinanceiro.TabIndex = 1;
            this.gBoxControleFinanceiro.TabStop = false;
            this.gBoxControleFinanceiro.Text = "Controle de Estoque";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(208, 251);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(95, 26);
            this.btFiltrar.TabIndex = 31;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            // 
            // comboBoxNomeDoador
            // 
            this.comboBoxNomeDoador.FormattingEnabled = true;
            this.comboBoxNomeDoador.Location = new System.Drawing.Point(312, 208);
            this.comboBoxNomeDoador.Name = "comboBoxNomeDoador";
            this.comboBoxNomeDoador.Size = new System.Drawing.Size(144, 21);
            this.comboBoxNomeDoador.TabIndex = 28;
            // 
            // lbNomeDoador
            // 
            this.lbNomeDoador.AutoSize = true;
            this.lbNomeDoador.Location = new System.Drawing.Point(230, 209);
            this.lbNomeDoador.Name = "lbNomeDoador";
            this.lbNomeDoador.Size = new System.Drawing.Size(73, 13);
            this.lbNomeDoador.TabIndex = 27;
            this.lbNomeDoador.Text = "Nome Doador";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 22;
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(228, 177);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(75, 13);
            this.lbNomeProduto.TabIndex = 21;
            this.lbNomeProduto.Text = "Nome Produto";
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(309, 251);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 26);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(37, 209);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lbDataFinal.TabIndex = 15;
            this.lbDataFinal.Text = "Data Final";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(124, 209);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(81, 20);
            this.txtDataFinal.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 111);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtDataCadastroEntrada
            // 
            this.txtDataCadastroEntrada.Location = new System.Drawing.Point(124, 177);
            this.txtDataCadastroEntrada.Name = "txtDataCadastroEntrada";
            this.txtDataCadastroEntrada.Size = new System.Drawing.Size(81, 20);
            this.txtDataCadastroEntrada.TabIndex = 7;
            // 
            // lbDataCadastroEntrada
            // 
            this.lbDataCadastroEntrada.AutoSize = true;
            this.lbDataCadastroEntrada.Location = new System.Drawing.Point(37, 177);
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
            this.btMenuInicial.Click += new System.EventHandler(this.btMenuInicial_Click);
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(9, 8);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 32;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(104, 8);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(54, 17);
            this.rbSaida.TabIndex = 33;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSaida);
            this.panel1.Controls.Add(this.rbEntrada);
            this.panel1.Location = new System.Drawing.Point(31, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 35);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbBazar);
            this.panel2.Controls.Add(this.rbDoacao);
            this.panel2.Location = new System.Drawing.Point(282, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 35);
            this.panel2.TabIndex = 35;
            // 
            // rbBazar
            // 
            this.rbBazar.AutoSize = true;
            this.rbBazar.Location = new System.Drawing.Point(104, 8);
            this.rbBazar.Name = "rbBazar";
            this.rbBazar.Size = new System.Drawing.Size(52, 17);
            this.rbBazar.TabIndex = 33;
            this.rbBazar.TabStop = true;
            this.rbBazar.Text = "Bazar";
            this.rbBazar.UseVisualStyleBackColor = true;
            // 
            // rbDoacao
            // 
            this.rbDoacao.AutoSize = true;
            this.rbDoacao.Location = new System.Drawing.Point(9, 8);
            this.rbDoacao.Name = "rbDoacao";
            this.rbDoacao.Size = new System.Drawing.Size(63, 17);
            this.rbDoacao.TabIndex = 32;
            this.rbDoacao.TabStop = true;
            this.rbDoacao.Text = "Doação";
            this.rbDoacao.UseVisualStyleBackColor = true;
            // 
            // MenuEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.gBoxControleFinanceiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuEstoque";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gBoxControleFinanceiro.ResumeLayout(false);
            this.gBoxControleFinanceiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxControleFinanceiro;
        private System.Windows.Forms.ComboBox comboBoxNomeDoador;
        private System.Windows.Forms.Label lbNomeDoador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDataCadastroEntrada;
        private System.Windows.Forms.Label lbDataCadastroEntrada;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbBazar;
        private System.Windows.Forms.RadioButton rbDoacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.RadioButton rbEntrada;
    }
}