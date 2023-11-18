namespace Prototipov1
{
    partial class MenuPlanoDeContasCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPlanoDeContasCadastrar));
            this.gBoxGestaoRecursos = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeCadastroEntrada = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRefreshAtivos = new System.Windows.Forms.Button();
            this.txtIdAtivos = new System.Windows.Forms.TextBox();
            this.lbIdAtivos = new System.Windows.Forms.Label();
            this.btExcluirAtivos = new System.Windows.Forms.Button();
            this.btAtualizarAtivos = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtNomeAtivos = new System.Windows.Forms.TextBox();
            this.lbNomeAtivo = new System.Windows.Forms.Label();
            this.btMenu = new System.Windows.Forms.Button();
            this.btCadastrarAtivos = new System.Windows.Forms.Button();
            this.idAtivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxGestaoRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxGestaoRecursos
            // 
            this.gBoxGestaoRecursos.Controls.Add(this.btRefresh);
            this.gBoxGestaoRecursos.Controls.Add(this.txtId);
            this.gBoxGestaoRecursos.Controls.Add(this.lbId);
            this.gBoxGestaoRecursos.Controls.Add(this.comboBoxTipo);
            this.gBoxGestaoRecursos.Controls.Add(this.lbTipo);
            this.gBoxGestaoRecursos.Controls.Add(this.btExcluir);
            this.gBoxGestaoRecursos.Controls.Add(this.btAtualizar);
            this.gBoxGestaoRecursos.Controls.Add(this.dataGridView1);
            this.gBoxGestaoRecursos.Controls.Add(this.txtNome);
            this.gBoxGestaoRecursos.Controls.Add(this.lbNomeCadastroEntrada);
            this.gBoxGestaoRecursos.Controls.Add(this.btCadastrar);
            this.gBoxGestaoRecursos.Location = new System.Drawing.Point(12, 12);
            this.gBoxGestaoRecursos.Name = "gBoxGestaoRecursos";
            this.gBoxGestaoRecursos.Size = new System.Drawing.Size(515, 192);
            this.gBoxGestaoRecursos.TabIndex = 1;
            this.gBoxGestaoRecursos.TabStop = false;
            this.gBoxGestaoRecursos.Text = "Contas";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(310, 156);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 26);
            this.btRefresh.TabIndex = 26;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(28, 130);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(73, 20);
            this.txtId.TabIndex = 25;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(6, 133);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 24;
            this.lbId.Text = "Id";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.comboBoxTipo.Location = new System.Drawing.Point(158, 130);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(124, 21);
            this.comboBoxTipo.TabIndex = 23;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(124, 133);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(28, 13);
            this.lbTipo.TabIndex = 22;
            this.lbTipo.Text = "Tipo";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(209, 156);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(95, 26);
            this.btExcluir.TabIndex = 17;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(108, 156);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(95, 26);
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
            this.tipo_conta,
            this.descr_conta});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 107);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Item No";
            this.id.Name = "id";
            // 
            // tipo_conta
            // 
            this.tipo_conta.HeaderText = "Tipo";
            this.tipo_conta.Name = "tipo_conta";
            // 
            // descr_conta
            // 
            this.descr_conta.HeaderText = "Nome";
            this.descr_conta.Name = "descr_conta";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(329, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lbNomeCadastroEntrada
            // 
            this.lbNomeCadastroEntrada.AutoSize = true;
            this.lbNomeCadastroEntrada.Location = new System.Drawing.Point(288, 133);
            this.lbNomeCadastroEntrada.Name = "lbNomeCadastroEntrada";
            this.lbNomeCadastroEntrada.Size = new System.Drawing.Size(35, 13);
            this.lbNomeCadastroEntrada.TabIndex = 3;
            this.lbNomeCadastroEntrada.Text = "Nome";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(7, 156);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 26);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRefreshAtivos);
            this.groupBox1.Controls.Add(this.txtIdAtivos);
            this.groupBox1.Controls.Add(this.lbIdAtivos);
            this.groupBox1.Controls.Add(this.btExcluirAtivos);
            this.groupBox1.Controls.Add(this.btAtualizarAtivos);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.txtNomeAtivos);
            this.groupBox1.Controls.Add(this.lbNomeAtivo);
            this.groupBox1.Controls.Add(this.btMenu);
            this.groupBox1.Controls.Add(this.btCadastrarAtivos);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 192);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ativos";
            // 
            // btRefreshAtivos
            // 
            this.btRefreshAtivos.Location = new System.Drawing.Point(310, 156);
            this.btRefreshAtivos.Name = "btRefreshAtivos";
            this.btRefreshAtivos.Size = new System.Drawing.Size(95, 26);
            this.btRefreshAtivos.TabIndex = 26;
            this.btRefreshAtivos.Text = "Refresh";
            this.btRefreshAtivos.UseVisualStyleBackColor = true;
            this.btRefreshAtivos.Click += new System.EventHandler(this.btRefreshAtivos_Click_1);
            // 
            // txtIdAtivos
            // 
            this.txtIdAtivos.Enabled = false;
            this.txtIdAtivos.Location = new System.Drawing.Point(28, 130);
            this.txtIdAtivos.Name = "txtIdAtivos";
            this.txtIdAtivos.Size = new System.Drawing.Size(73, 20);
            this.txtIdAtivos.TabIndex = 25;
            // 
            // lbIdAtivos
            // 
            this.lbIdAtivos.AutoSize = true;
            this.lbIdAtivos.Location = new System.Drawing.Point(6, 133);
            this.lbIdAtivos.Name = "lbIdAtivos";
            this.lbIdAtivos.Size = new System.Drawing.Size(16, 13);
            this.lbIdAtivos.TabIndex = 24;
            this.lbIdAtivos.Text = "Id";
            // 
            // btExcluirAtivos
            // 
            this.btExcluirAtivos.Location = new System.Drawing.Point(209, 156);
            this.btExcluirAtivos.Name = "btExcluirAtivos";
            this.btExcluirAtivos.Size = new System.Drawing.Size(95, 26);
            this.btExcluirAtivos.TabIndex = 17;
            this.btExcluirAtivos.Text = "Excluir";
            this.btExcluirAtivos.UseVisualStyleBackColor = true;
            this.btExcluirAtivos.Click += new System.EventHandler(this.btExcluirAtivos_Click_1);
            // 
            // btAtualizarAtivos
            // 
            this.btAtualizarAtivos.Location = new System.Drawing.Point(108, 156);
            this.btAtualizarAtivos.Name = "btAtualizarAtivos";
            this.btAtualizarAtivos.Size = new System.Drawing.Size(95, 26);
            this.btAtualizarAtivos.TabIndex = 16;
            this.btAtualizarAtivos.Text = "Atualizar";
            this.btAtualizarAtivos.UseVisualStyleBackColor = true;
            this.btAtualizarAtivos.Click += new System.EventHandler(this.btAtualizarAtivos_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAtivos,
            this.descr_ativo});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(499, 107);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // txtNomeAtivos
            // 
            this.txtNomeAtivos.Location = new System.Drawing.Point(329, 130);
            this.txtNomeAtivos.Name = "txtNomeAtivos";
            this.txtNomeAtivos.Size = new System.Drawing.Size(176, 20);
            this.txtNomeAtivos.TabIndex = 8;
            // 
            // lbNomeAtivo
            // 
            this.lbNomeAtivo.AutoSize = true;
            this.lbNomeAtivo.Location = new System.Drawing.Point(288, 133);
            this.lbNomeAtivo.Name = "lbNomeAtivo";
            this.lbNomeAtivo.Size = new System.Drawing.Size(35, 13);
            this.lbNomeAtivo.TabIndex = 3;
            this.lbNomeAtivo.Text = "Nome";
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(411, 156);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(95, 26);
            this.btMenu.TabIndex = 1;
            this.btMenu.Text = "Menu Inicial";
            this.btMenu.UseVisualStyleBackColor = true;
            // 
            // btCadastrarAtivos
            // 
            this.btCadastrarAtivos.Location = new System.Drawing.Point(7, 156);
            this.btCadastrarAtivos.Name = "btCadastrarAtivos";
            this.btCadastrarAtivos.Size = new System.Drawing.Size(95, 26);
            this.btCadastrarAtivos.TabIndex = 0;
            this.btCadastrarAtivos.Text = "Cadastrar";
            this.btCadastrarAtivos.UseVisualStyleBackColor = true;
            this.btCadastrarAtivos.Click += new System.EventHandler(this.btCadastrarAtivos_Click_1);
            // 
            // idAtivos
            // 
            this.idAtivos.HeaderText = "Item No";
            this.idAtivos.Name = "idAtivos";
            // 
            // descr_ativo
            // 
            this.descr_ativo.HeaderText = "Nome";
            this.descr_ativo.Name = "descr_ativo";
            // 
            // MenuPlanoDeContasCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxGestaoRecursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPlanoDeContasCadastrar";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.MenuPlanoDeContasCadastrar_Load);
            this.gBoxGestaoRecursos.ResumeLayout(false);
            this.gBoxGestaoRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxGestaoRecursos;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeCadastroEntrada;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_conta;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRefreshAtivos;
        private System.Windows.Forms.TextBox txtIdAtivos;
        private System.Windows.Forms.Label lbIdAtivos;
        private System.Windows.Forms.Button btExcluirAtivos;
        private System.Windows.Forms.Button btAtualizarAtivos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAtivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_ativo;
        private System.Windows.Forms.TextBox txtNomeAtivos;
        private System.Windows.Forms.Label lbNomeAtivo;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btCadastrarAtivos;
    }
}