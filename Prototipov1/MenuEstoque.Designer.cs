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
            this.checkBazar = new System.Windows.Forms.CheckBox();
            this.checkDoacao = new System.Windows.Forms.CheckBox();
            this.comboBoxNomeDoador = new System.Windows.Forms.ComboBox();
            this.lbNomeDoador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.checkSaida = new System.Windows.Forms.CheckBox();
            this.checkEntrada = new System.Windows.Forms.CheckBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDataCadastroEntrada = new System.Windows.Forms.TextBox();
            this.lbDataCadastroEntrada = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.gBoxControleFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxControleFinanceiro
            // 
            this.gBoxControleFinanceiro.Controls.Add(this.btFiltrar);
            this.gBoxControleFinanceiro.Controls.Add(this.checkBazar);
            this.gBoxControleFinanceiro.Controls.Add(this.checkDoacao);
            this.gBoxControleFinanceiro.Controls.Add(this.comboBoxNomeDoador);
            this.gBoxControleFinanceiro.Controls.Add(this.lbNomeDoador);
            this.gBoxControleFinanceiro.Controls.Add(this.textBox1);
            this.gBoxControleFinanceiro.Controls.Add(this.lbNomeProduto);
            this.gBoxControleFinanceiro.Controls.Add(this.checkSaida);
            this.gBoxControleFinanceiro.Controls.Add(this.checkEntrada);
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
            // checkBazar
            // 
            this.checkBazar.AutoSize = true;
            this.checkBazar.Location = new System.Drawing.Point(389, 136);
            this.checkBazar.Name = "checkBazar";
            this.checkBazar.Size = new System.Drawing.Size(53, 17);
            this.checkBazar.TabIndex = 30;
            this.checkBazar.Text = "Bazar";
            this.checkBazar.UseVisualStyleBackColor = true;
            // 
            // checkDoacao
            // 
            this.checkDoacao.AutoSize = true;
            this.checkDoacao.Location = new System.Drawing.Point(312, 136);
            this.checkDoacao.Name = "checkDoacao";
            this.checkDoacao.Size = new System.Drawing.Size(64, 17);
            this.checkDoacao.TabIndex = 29;
            this.checkDoacao.Text = "Doação";
            this.checkDoacao.UseVisualStyleBackColor = true;
            // 
            // comboBoxNomeDoador
            // 
            this.comboBoxNomeDoador.FormattingEnabled = true;
            this.comboBoxNomeDoador.Location = new System.Drawing.Point(309, 205);
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
            this.textBox1.Location = new System.Drawing.Point(309, 174);
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
            // checkSaida
            // 
            this.checkSaida.AutoSize = true;
            this.checkSaida.Location = new System.Drawing.Point(150, 136);
            this.checkSaida.Name = "checkSaida";
            this.checkSaida.Size = new System.Drawing.Size(55, 17);
            this.checkSaida.TabIndex = 20;
            this.checkSaida.Text = "Saída";
            this.checkSaida.UseVisualStyleBackColor = true;
            // 
            // checkEntrada
            // 
            this.checkEntrada.AutoSize = true;
            this.checkEntrada.Location = new System.Drawing.Point(73, 136);
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
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(58, 208);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lbDataFinal.TabIndex = 15;
            this.lbDataFinal.Text = "Data Final";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(124, 205);
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
            this.txtDataCadastroEntrada.Location = new System.Drawing.Point(124, 174);
            this.txtDataCadastroEntrada.Name = "txtDataCadastroEntrada";
            this.txtDataCadastroEntrada.Size = new System.Drawing.Size(81, 20);
            this.txtDataCadastroEntrada.TabIndex = 7;
            // 
            // lbDataCadastroEntrada
            // 
            this.lbDataCadastroEntrada.AutoSize = true;
            this.lbDataCadastroEntrada.Location = new System.Drawing.Point(58, 177);
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
            // MenuEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.gBoxControleFinanceiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuEstoque";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.gBoxControleFinanceiro.ResumeLayout(false);
            this.gBoxControleFinanceiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxControleFinanceiro;
        private System.Windows.Forms.CheckBox checkBazar;
        private System.Windows.Forms.CheckBox checkDoacao;
        private System.Windows.Forms.ComboBox comboBoxNomeDoador;
        private System.Windows.Forms.Label lbNomeDoador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.CheckBox checkSaida;
        private System.Windows.Forms.CheckBox checkEntrada;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDataCadastroEntrada;
        private System.Windows.Forms.Label lbDataCadastroEntrada;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button btFiltrar;
    }
}