namespace Prototipov1
{
    partial class MenuGestaoRecursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGestaoRecursos));
            this.gBoxControleFinanceiro = new System.Windows.Forms.GroupBox();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.checkDoacao = new System.Windows.Forms.CheckBox();
            this.comboBoxNomeDoador = new System.Windows.Forms.ComboBox();
            this.lbNomeDoador = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbValor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBoxLocalCadastroEntrada = new System.Windows.Forms.ComboBox();
            this.cBoxContaCadastroEntrada = new System.Windows.Forms.ComboBox();
            this.txtDataCadastroEntrada = new System.Windows.Forms.TextBox();
            this.lbContaCadastroEntrada = new System.Windows.Forms.Label();
            this.lbOnde = new System.Windows.Forms.Label();
            this.lbDataCadastroEntrada = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_doador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbAte = new System.Windows.Forms.Label();
            this.gBoxControleFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxControleFinanceiro
            // 
            this.gBoxControleFinanceiro.Controls.Add(this.lbAte);
            this.gBoxControleFinanceiro.Controls.Add(this.rbSaida);
            this.gBoxControleFinanceiro.Controls.Add(this.rbEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.checkDoacao);
            this.gBoxControleFinanceiro.Controls.Add(this.comboBoxNomeDoador);
            this.gBoxControleFinanceiro.Controls.Add(this.lbNomeDoador);
            this.gBoxControleFinanceiro.Controls.Add(this.btExcluir);
            this.gBoxControleFinanceiro.Controls.Add(this.btCadastrar);
            this.gBoxControleFinanceiro.Controls.Add(this.lbValor);
            this.gBoxControleFinanceiro.Controls.Add(this.textBox2);
            this.gBoxControleFinanceiro.Controls.Add(this.textBox1);
            this.gBoxControleFinanceiro.Controls.Add(this.lbDescricao);
            this.gBoxControleFinanceiro.Controls.Add(this.btRelatorio);
            this.gBoxControleFinanceiro.Controls.Add(this.btAtualizar);
            this.gBoxControleFinanceiro.Controls.Add(this.txtDataFinal);
            this.gBoxControleFinanceiro.Controls.Add(this.dataGridView1);
            this.gBoxControleFinanceiro.Controls.Add(this.cBoxLocalCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.cBoxContaCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.txtDataCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.lbContaCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.lbOnde);
            this.gBoxControleFinanceiro.Controls.Add(this.lbDataCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.btMenuInicial);
            this.gBoxControleFinanceiro.Location = new System.Drawing.Point(12, 12);
            this.gBoxControleFinanceiro.Name = "gBoxControleFinanceiro";
            this.gBoxControleFinanceiro.Size = new System.Drawing.Size(717, 283);
            this.gBoxControleFinanceiro.TabIndex = 0;
            this.gBoxControleFinanceiro.TabStop = false;
            this.gBoxControleFinanceiro.Text = "Controle Financeiro";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(377, 145);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(54, 17);
            this.rbSaida.TabIndex = 31;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(309, 144);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 30;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // checkDoacao
            // 
            this.checkDoacao.AutoSize = true;
            this.checkDoacao.Location = new System.Drawing.Point(447, 148);
            this.checkDoacao.Name = "checkDoacao";
            this.checkDoacao.Size = new System.Drawing.Size(101, 17);
            this.checkDoacao.TabIndex = 29;
            this.checkDoacao.Text = "É uma doação?";
            this.checkDoacao.UseVisualStyleBackColor = true;
            // 
            // comboBoxNomeDoador
            // 
            this.comboBoxNomeDoador.FormattingEnabled = true;
            this.comboBoxNomeDoador.Location = new System.Drawing.Point(545, 174);
            this.comboBoxNomeDoador.Name = "comboBoxNomeDoador";
            this.comboBoxNomeDoador.Size = new System.Drawing.Size(162, 21);
            this.comboBoxNomeDoador.TabIndex = 28;
            // 
            // lbNomeDoador
            // 
            this.lbNomeDoador.AutoSize = true;
            this.lbNomeDoador.Location = new System.Drawing.Point(444, 177);
            this.lbNomeDoador.Name = "lbNomeDoador";
            this.lbNomeDoador.Size = new System.Drawing.Size(73, 13);
            this.lbNomeDoador.TabIndex = 27;
            this.lbNomeDoador.Text = "Nome Doador";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(208, 251);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(95, 26);
            this.btExcluir.TabIndex = 26;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(6, 251);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 26);
            this.btCadastrar.TabIndex = 25;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(9, 210);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(48, 13);
            this.lbValor.TabIndex = 24;
            this.lbValor.Text = "Valor R$";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 22;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(9, 179);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 21;
            this.lbDescricao.Text = "Descrição";
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(309, 251);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 26);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(107, 251);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(95, 26);
            this.btAtualizar.TabIndex = 16;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(185, 144);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(81, 20);
            this.txtDataFinal.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data_mov,
            this.descricao,
            this.nome_conta,
            this.nome_ativo,
            this.valor,
            this.nome_doador});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 111);
            this.dataGridView1.TabIndex = 13;
            // 
            // cBoxLocalCadastroEntrada
            // 
            this.cBoxLocalCadastroEntrada.FormattingEnabled = true;
            this.cBoxLocalCadastroEntrada.Location = new System.Drawing.Point(208, 205);
            this.cBoxLocalCadastroEntrada.Name = "cBoxLocalCadastroEntrada";
            this.cBoxLocalCadastroEntrada.Size = new System.Drawing.Size(144, 21);
            this.cBoxLocalCadastroEntrada.TabIndex = 11;
            // 
            // cBoxContaCadastroEntrada
            // 
            this.cBoxContaCadastroEntrada.FormattingEnabled = true;
            this.cBoxContaCadastroEntrada.Location = new System.Drawing.Point(427, 205);
            this.cBoxContaCadastroEntrada.Name = "cBoxContaCadastroEntrada";
            this.cBoxContaCadastroEntrada.Size = new System.Drawing.Size(144, 21);
            this.cBoxContaCadastroEntrada.TabIndex = 10;
            // 
            // txtDataCadastroEntrada
            // 
            this.txtDataCadastroEntrada.Location = new System.Drawing.Point(70, 143);
            this.txtDataCadastroEntrada.Name = "txtDataCadastroEntrada";
            this.txtDataCadastroEntrada.Size = new System.Drawing.Size(81, 20);
            this.txtDataCadastroEntrada.TabIndex = 7;
            // 
            // lbContaCadastroEntrada
            // 
            this.lbContaCadastroEntrada.AutoSize = true;
            this.lbContaCadastroEntrada.Location = new System.Drawing.Point(369, 208);
            this.lbContaCadastroEntrada.Name = "lbContaCadastroEntrada";
            this.lbContaCadastroEntrada.Size = new System.Drawing.Size(35, 13);
            this.lbContaCadastroEntrada.TabIndex = 5;
            this.lbContaCadastroEntrada.Text = "Conta";
            // 
            // lbOnde
            // 
            this.lbOnde.AutoSize = true;
            this.lbOnde.Location = new System.Drawing.Point(169, 210);
            this.lbOnde.Name = "lbOnde";
            this.lbOnde.Size = new System.Drawing.Size(33, 13);
            this.lbOnde.TabIndex = 4;
            this.lbOnde.Text = "Onde";
            // 
            // lbDataCadastroEntrada
            // 
            this.lbDataCadastroEntrada.AutoSize = true;
            this.lbDataCadastroEntrada.Location = new System.Drawing.Point(9, 146);
            this.lbDataCadastroEntrada.Name = "lbDataCadastroEntrada";
            this.lbDataCadastroEntrada.Size = new System.Drawing.Size(30, 13);
            this.lbDataCadastroEntrada.TabIndex = 2;
            this.lbDataCadastroEntrada.Text = "Data";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.Location = new System.Drawing.Point(616, 251);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(95, 26);
            this.btMenuInicial.TabIndex = 1;
            this.btMenuInicial.Text = "Menu Inicial";
            this.btMenuInicial.UseVisualStyleBackColor = true;
            this.btMenuInicial.Click += new System.EventHandler(this.btMenuInicial_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Item No";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // data_mov
            // 
            this.data_mov.HeaderText = "Data";
            this.data_mov.Name = "data_mov";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // nome_conta
            // 
            this.nome_conta.HeaderText = "Conta";
            this.nome_conta.Name = "nome_conta";
            // 
            // nome_ativo
            // 
            this.nome_ativo.HeaderText = "Ativo";
            this.nome_ativo.Name = "nome_ativo";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // nome_doador
            // 
            this.nome_doador.HeaderText = "Doador";
            this.nome_doador.Name = "nome_doador";
            // 
            // lbAte
            // 
            this.lbAte.AutoSize = true;
            this.lbAte.Location = new System.Drawing.Point(157, 147);
            this.lbAte.Name = "lbAte";
            this.lbAte.Size = new System.Drawing.Size(22, 13);
            this.lbAte.TabIndex = 32;
            this.lbAte.Text = "até";
            // 
            // MenuGestaoRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 307);
            this.Controls.Add(this.gBoxControleFinanceiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuGestaoRecursos";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gBoxControleFinanceiro.ResumeLayout(false);
            this.gBoxControleFinanceiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxControleFinanceiro;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.TextBox txtDataCadastroEntrada;
        private System.Windows.Forms.Label lbContaCadastroEntrada;
        private System.Windows.Forms.Label lbOnde;
        private System.Windows.Forms.Label lbDataCadastroEntrada;
        private System.Windows.Forms.ComboBox cBoxLocalCadastroEntrada;
        private System.Windows.Forms.ComboBox cBoxContaCadastroEntrada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.CheckBox checkDoacao;
        private System.Windows.Forms.ComboBox comboBoxNomeDoador;
        private System.Windows.Forms.Label lbNomeDoador;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.Label lbAte;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_doador;
    }
}