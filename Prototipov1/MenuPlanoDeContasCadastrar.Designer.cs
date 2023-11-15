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
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeCadastroEntrada = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbTipo = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.gBoxGestaoRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.gBoxGestaoRecursos.Controls.Add(this.btMenuInicial);
            this.gBoxGestaoRecursos.Controls.Add(this.btCadastrar);
            this.gBoxGestaoRecursos.Location = new System.Drawing.Point(12, 12);
            this.gBoxGestaoRecursos.Name = "gBoxGestaoRecursos";
            this.gBoxGestaoRecursos.Size = new System.Drawing.Size(515, 283);
            this.gBoxGestaoRecursos.TabIndex = 1;
            this.gBoxGestaoRecursos.TabStop = false;
            this.gBoxGestaoRecursos.Text = "Plano de Contas";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(208, 251);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(95, 26);
            this.btExcluir.TabIndex = 17;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(107, 251);
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
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(6, 251);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 26);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
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
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída",
            "Ativo"});
            this.comboBoxTipo.Location = new System.Drawing.Point(158, 130);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(124, 21);
            this.comboBoxTipo.TabIndex = 23;
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
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(28, 130);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(73, 20);
            this.txtId.TabIndex = 25;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(309, 251);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 26);
            this.btRefresh.TabIndex = 26;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // MenuPlanoDeContasCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.gBoxGestaoRecursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPlanoDeContasCadastrar";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.MenuPlanoDeContasCadastrar_Load);
            this.gBoxGestaoRecursos.ResumeLayout(false);
            this.gBoxGestaoRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxGestaoRecursos;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeCadastroEntrada;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr_conta;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btRefresh;
    }
}