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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGestaoRecursos));
            this.gBoxControleFinanceiro = new System.Windows.Forms.GroupBox();
            this.lbOngId = new System.Windows.Forms.Label();
            this.txtOngId = new System.Windows.Forms.TextBox();
            this.lbConta = new System.Windows.Forms.Label();
            this.txtIdConta = new System.Windows.Forms.TextBox();
            this.txtIdAtivo = new System.Windows.Forms.TextBox();
            this.lbAtivo = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBoxLocalCadastroEntrada = new System.Windows.Forms.ComboBox();
            this.cBoxContaCadastroEntrada = new System.Windows.Forms.ComboBox();
            this.txtDataCadastroEntrada = new System.Windows.Forms.TextBox();
            this.lbContaCadastroEntrada = new System.Windows.Forms.Label();
            this.lbOnde = new System.Windows.Forms.Label();
            this.lbDataCadastroEntrada = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ong_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxControleFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxControleFinanceiro
            // 
            this.gBoxControleFinanceiro.Controls.Add(this.lbOngId);
            this.gBoxControleFinanceiro.Controls.Add(this.txtOngId);
            this.gBoxControleFinanceiro.Controls.Add(this.lbConta);
            this.gBoxControleFinanceiro.Controls.Add(this.txtIdConta);
            this.gBoxControleFinanceiro.Controls.Add(this.txtIdAtivo);
            this.gBoxControleFinanceiro.Controls.Add(this.lbAtivo);
            this.gBoxControleFinanceiro.Controls.Add(this.lbID);
            this.gBoxControleFinanceiro.Controls.Add(this.txtId);
            this.gBoxControleFinanceiro.Controls.Add(this.btRefresh);
            this.gBoxControleFinanceiro.Controls.Add(this.btExcluir);
            this.gBoxControleFinanceiro.Controls.Add(this.btCadastrar);
            this.gBoxControleFinanceiro.Controls.Add(this.lbValor);
            this.gBoxControleFinanceiro.Controls.Add(this.txtValor);
            this.gBoxControleFinanceiro.Controls.Add(this.txtDescricao);
            this.gBoxControleFinanceiro.Controls.Add(this.lbDescricao);
            this.gBoxControleFinanceiro.Controls.Add(this.btRelatorio);
            this.gBoxControleFinanceiro.Controls.Add(this.btAtualizar);
            this.gBoxControleFinanceiro.Controls.Add(this.dataGridView1);
            this.gBoxControleFinanceiro.Controls.Add(this.cBoxLocalCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.cBoxContaCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.txtDataCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.lbContaCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.lbOnde);
            this.gBoxControleFinanceiro.Controls.Add(this.lbDataCadastroEntrada);
            this.gBoxControleFinanceiro.Controls.Add(this.btMenuInicial);
            this.gBoxControleFinanceiro.Location = new System.Drawing.Point(12, 2);
            this.gBoxControleFinanceiro.Name = "gBoxControleFinanceiro";
            this.gBoxControleFinanceiro.Size = new System.Drawing.Size(804, 465);
            this.gBoxControleFinanceiro.TabIndex = 0;
            this.gBoxControleFinanceiro.TabStop = false;
            this.gBoxControleFinanceiro.Text = "Controle Financeiro";
            // 
            // lbOngId
            // 
            this.lbOngId.AutoSize = true;
            this.lbOngId.Location = new System.Drawing.Point(262, 344);
            this.lbOngId.Name = "lbOngId";
            this.lbOngId.Size = new System.Drawing.Size(41, 14);
            this.lbOngId.TabIndex = 43;
            this.lbOngId.Text = "Ong ID";
            // 
            // txtOngId
            // 
            this.txtOngId.Enabled = false;
            this.txtOngId.Location = new System.Drawing.Point(309, 341);
            this.txtOngId.Name = "txtOngId";
            this.txtOngId.Size = new System.Drawing.Size(42, 25);
            this.txtOngId.TabIndex = 42;
            // 
            // lbConta
            // 
            this.lbConta.AutoSize = true;
            this.lbConta.Location = new System.Drawing.Point(466, 383);
            this.lbConta.Name = "lbConta";
            this.lbConta.Size = new System.Drawing.Size(51, 14);
            this.lbConta.TabIndex = 39;
            this.lbConta.Text = "ID Conta";
            // 
            // txtIdConta
            // 
            this.txtIdConta.Enabled = false;
            this.txtIdConta.Location = new System.Drawing.Point(521, 380);
            this.txtIdConta.Name = "txtIdConta";
            this.txtIdConta.Size = new System.Drawing.Size(36, 25);
            this.txtIdConta.TabIndex = 38;
            // 
            // txtIdAtivo
            // 
            this.txtIdAtivo.Enabled = false;
            this.txtIdAtivo.Location = new System.Drawing.Point(208, 380);
            this.txtIdAtivo.Name = "txtIdAtivo";
            this.txtIdAtivo.Size = new System.Drawing.Size(38, 25);
            this.txtIdAtivo.TabIndex = 37;
            // 
            // lbAtivo
            // 
            this.lbAtivo.AutoSize = true;
            this.lbAtivo.Location = new System.Drawing.Point(157, 383);
            this.lbAtivo.Name = "lbAtivo";
            this.lbAtivo.Size = new System.Drawing.Size(46, 14);
            this.lbAtivo.TabIndex = 36;
            this.lbAtivo.Text = "ID Ativo";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(150, 344);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(56, 14);
            this.lbID.TabIndex = 35;
            this.lbID.Text = "Código ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(208, 341);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 25);
            this.txtId.TabIndex = 34;
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Location = new System.Drawing.Point(309, 431);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 28);
            this.btRefresh.TabIndex = 33;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(208, 431);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(95, 28);
            this.btExcluir.TabIndex = 26;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Location = new System.Drawing.Point(6, 431);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 28);
            this.btCadastrar.TabIndex = 25;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(9, 383);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(49, 14);
            this.lbValor.TabIndex = 24;
            this.lbValor.Text = "Valor R$";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(63, 380);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(81, 25);
            this.txtValor.TabIndex = 23;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(427, 341);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(371, 25);
            this.txtDescricao.TabIndex = 22;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(366, 344);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 14);
            this.lbDescricao.TabIndex = 21;
            this.lbDescricao.Text = "Descrição";
            // 
            // btRelatorio
            // 
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Location = new System.Drawing.Point(602, 431);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 28);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Location = new System.Drawing.Point(107, 431);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(95, 28);
            this.btAtualizar.TabIndex = 16;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ong_id,
            this.data_mov,
            this.descricao,
            this.conta_id,
            this.descr_conta,
            this.ativo_id,
            this.descr_ativo,
            this.valor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 309);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cBoxLocalCadastroEntrada
            // 
            this.cBoxLocalCadastroEntrada.FormattingEnabled = true;
            this.cBoxLocalCadastroEntrada.Location = new System.Drawing.Point(309, 380);
            this.cBoxLocalCadastroEntrada.Name = "cBoxLocalCadastroEntrada";
            this.cBoxLocalCadastroEntrada.Size = new System.Drawing.Size(144, 22);
            this.cBoxLocalCadastroEntrada.TabIndex = 11;
            // 
            // cBoxContaCadastroEntrada
            // 
            this.cBoxContaCadastroEntrada.FormattingEnabled = true;
            this.cBoxContaCadastroEntrada.Location = new System.Drawing.Point(613, 380);
            this.cBoxContaCadastroEntrada.Name = "cBoxContaCadastroEntrada";
            this.cBoxContaCadastroEntrada.Size = new System.Drawing.Size(185, 22);
            this.cBoxContaCadastroEntrada.TabIndex = 10;
            // 
            // txtDataCadastroEntrada
            // 
            this.txtDataCadastroEntrada.Location = new System.Drawing.Point(63, 341);
            this.txtDataCadastroEntrada.Name = "txtDataCadastroEntrada";
            this.txtDataCadastroEntrada.Size = new System.Drawing.Size(81, 25);
            this.txtDataCadastroEntrada.TabIndex = 7;
            // 
            // lbContaCadastroEntrada
            // 
            this.lbContaCadastroEntrada.AutoSize = true;
            this.lbContaCadastroEntrada.Location = new System.Drawing.Point(572, 383);
            this.lbContaCadastroEntrada.Name = "lbContaCadastroEntrada";
            this.lbContaCadastroEntrada.Size = new System.Drawing.Size(37, 14);
            this.lbContaCadastroEntrada.TabIndex = 5;
            this.lbContaCadastroEntrada.Text = "Conta";
            // 
            // lbOnde
            // 
            this.lbOnde.AutoSize = true;
            this.lbOnde.Location = new System.Drawing.Point(270, 383);
            this.lbOnde.Name = "lbOnde";
            this.lbOnde.Size = new System.Drawing.Size(32, 14);
            this.lbOnde.TabIndex = 4;
            this.lbOnde.Text = "Ativo";
            // 
            // lbDataCadastroEntrada
            // 
            this.lbDataCadastroEntrada.AutoSize = true;
            this.lbDataCadastroEntrada.Location = new System.Drawing.Point(18, 344);
            this.lbDataCadastroEntrada.Name = "lbDataCadastroEntrada";
            this.lbDataCadastroEntrada.Size = new System.Drawing.Size(31, 14);
            this.lbDataCadastroEntrada.TabIndex = 2;
            this.lbDataCadastroEntrada.Text = "Data";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuInicial.Location = new System.Drawing.Point(703, 431);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(95, 28);
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
            // ong_id
            // 
            this.ong_id.HeaderText = "ID Ong";
            this.ong_id.Name = "ong_id";
            this.ong_id.Visible = false;
            // 
            // data_mov
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.data_mov.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_mov.HeaderText = "Data";
            this.data_mov.Name = "data_mov";
            this.data_mov.Width = 80;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 217;
            // 
            // conta_id
            // 
            this.conta_id.HeaderText = "ID Conta";
            this.conta_id.Name = "conta_id";
            this.conta_id.Width = 50;
            // 
            // descr_conta
            // 
            this.descr_conta.HeaderText = "Conta";
            this.descr_conta.Name = "descr_conta";
            // 
            // ativo_id
            // 
            this.ativo_id.HeaderText = "ID Ativo";
            this.ativo_id.Name = "ativo_id";
            this.ativo_id.Width = 50;
            // 
            // descr_ativo
            // 
            this.descr_ativo.HeaderText = "Ativo";
            this.descr_ativo.Name = "descr_ativo";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // MenuGestaoRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 471);
            this.Controls.Add(this.gBoxControleFinanceiro);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuGestaoRecursos";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.MenuGestaoRecursos_Load);
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
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbConta;
        private System.Windows.Forms.TextBox txtIdConta;
        private System.Windows.Forms.TextBox txtIdAtivo;
        private System.Windows.Forms.Label lbAtivo;
        private System.Windows.Forms.Label lbOngId;
        private System.Windows.Forms.TextBox txtOngId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ong_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn conta_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}