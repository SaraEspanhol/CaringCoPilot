namespace Prototipov1
{
    partial class MenuDoadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDoadores));
            this.gBoxDoacoes = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.cBoxPFPJ = new System.Windows.Forms.ComboBox();
            this.lbTipoDoador = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtCodDoador = new System.Windows.Forms.TextBox();
            this.lbCodDoador = new System.Windows.Forms.Label();
            this.txtDocDoador = new System.Windows.Forms.TextBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeDoador = new System.Windows.Forms.TextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.lbNomeDoador = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.gBoxDoacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxDoacoes
            // 
            this.gBoxDoacoes.Controls.Add(this.btRefresh);
            this.gBoxDoacoes.Controls.Add(this.cBoxPFPJ);
            this.gBoxDoacoes.Controls.Add(this.lbTipoDoador);
            this.gBoxDoacoes.Controls.Add(this.lbEmail);
            this.gBoxDoacoes.Controls.Add(this.txtEmail);
            this.gBoxDoacoes.Controls.Add(this.txtTelefone);
            this.gBoxDoacoes.Controls.Add(this.lbTelefone);
            this.gBoxDoacoes.Controls.Add(this.txtCodDoador);
            this.gBoxDoacoes.Controls.Add(this.lbCodDoador);
            this.gBoxDoacoes.Controls.Add(this.txtDocDoador);
            this.gBoxDoacoes.Controls.Add(this.btRelatorio);
            this.gBoxDoacoes.Controls.Add(this.btExcluir);
            this.gBoxDoacoes.Controls.Add(this.btAtualizar);
            this.gBoxDoacoes.Controls.Add(this.lbDataNascimento);
            this.gBoxDoacoes.Controls.Add(this.txtDataNasc);
            this.gBoxDoacoes.Controls.Add(this.dataGridView1);
            this.gBoxDoacoes.Controls.Add(this.txtNomeDoador);
            this.gBoxDoacoes.Controls.Add(this.lbDocumento);
            this.gBoxDoacoes.Controls.Add(this.lbNomeDoador);
            this.gBoxDoacoes.Controls.Add(this.btMenuInicial);
            this.gBoxDoacoes.Controls.Add(this.btCadastrar);
            this.gBoxDoacoes.Location = new System.Drawing.Point(12, 3);
            this.gBoxDoacoes.Name = "gBoxDoacoes";
            this.gBoxDoacoes.Size = new System.Drawing.Size(763, 435);
            this.gBoxDoacoes.TabIndex = 2;
            this.gBoxDoacoes.TabStop = false;
            this.gBoxDoacoes.Text = "Doadores";
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Location = new System.Drawing.Point(308, 401);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 28);
            this.btRefresh.TabIndex = 33;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // cBoxPFPJ
            // 
            this.cBoxPFPJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPFPJ.FormattingEnabled = true;
            this.cBoxPFPJ.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.cBoxPFPJ.Location = new System.Drawing.Point(220, 300);
            this.cBoxPFPJ.Name = "cBoxPFPJ";
            this.cBoxPFPJ.Size = new System.Drawing.Size(130, 22);
            this.cBoxPFPJ.TabIndex = 32;
            // 
            // lbTipoDoador
            // 
            this.lbTipoDoador.AutoSize = true;
            this.lbTipoDoador.Location = new System.Drawing.Point(186, 305);
            this.lbTipoDoador.Name = "lbTipoDoador";
            this.lbTipoDoador.Size = new System.Drawing.Size(29, 14);
            this.lbTipoDoador.TabIndex = 31;
            this.lbTipoDoador.Text = "Tipo";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(16, 365);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 14);
            this.lbEmail.TabIndex = 30;
            this.lbEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 362);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(450, 25);
            this.txtEmail.TabIndex = 29;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(625, 365);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 25);
            this.txtTelefone.TabIndex = 28;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(530, 368);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(50, 14);
            this.lbTelefone.TabIndex = 26;
            this.lbTelefone.Text = "Telefone";
            // 
            // txtCodDoador
            // 
            this.txtCodDoador.Enabled = false;
            this.txtCodDoador.Location = new System.Drawing.Point(62, 302);
            this.txtCodDoador.Name = "txtCodDoador";
            this.txtCodDoador.Size = new System.Drawing.Size(59, 25);
            this.txtCodDoador.TabIndex = 23;
            // 
            // lbCodDoador
            // 
            this.lbCodDoador.AutoSize = true;
            this.lbCodDoador.Location = new System.Drawing.Point(16, 305);
            this.lbCodDoador.Name = "lbCodDoador";
            this.lbCodDoador.Size = new System.Drawing.Size(42, 14);
            this.lbCodDoador.TabIndex = 22;
            this.lbCodDoador.Text = "Código";
            // 
            // txtDocDoador
            // 
            this.txtDocDoador.Location = new System.Drawing.Point(524, 302);
            this.txtDocDoador.Name = "txtDocDoador";
            this.txtDocDoador.Size = new System.Drawing.Size(228, 25);
            this.txtDocDoador.TabIndex = 21;
            // 
            // btRelatorio
            // 
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Location = new System.Drawing.Point(560, 401);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 28);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(207, 401);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(95, 28);
            this.btExcluir.TabIndex = 17;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Location = new System.Drawing.Point(106, 401);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(95, 28);
            this.btAtualizar.TabIndex = 16;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(530, 340);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(94, 14);
            this.lbDataNascimento.TabIndex = 15;
            this.lbDataNascimento.Text = "Data Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(625, 337);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(127, 25);
            this.txtDataNasc.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.tipo_doador,
            this.documento,
            this.data_nasc,
            this.email,
            this.telefone});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 260);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "Item No";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // tipo_doador
            // 
            this.tipo_doador.HeaderText = "Tipo";
            this.tipo_doador.Name = "tipo_doador";
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            // 
            // data_nasc
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.data_nasc.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_nasc.HeaderText = "Data de Nascimento";
            this.data_nasc.Name = "data_nasc";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // txtNomeDoador
            // 
            this.txtNomeDoador.Location = new System.Drawing.Point(62, 334);
            this.txtNomeDoador.Name = "txtNomeDoador";
            this.txtNomeDoador.Size = new System.Drawing.Size(450, 25);
            this.txtNomeDoador.TabIndex = 8;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(450, 307);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(64, 14);
            this.lbDocumento.TabIndex = 5;
            this.lbDocumento.Text = "Documento";
            // 
            // lbNomeDoador
            // 
            this.lbNomeDoador.AutoSize = true;
            this.lbNomeDoador.Location = new System.Drawing.Point(16, 334);
            this.lbNomeDoador.Name = "lbNomeDoador";
            this.lbNomeDoador.Size = new System.Drawing.Size(36, 14);
            this.lbNomeDoador.TabIndex = 3;
            this.lbNomeDoador.Text = "Nome";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuInicial.Location = new System.Drawing.Point(661, 401);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(95, 28);
            this.btMenuInicial.TabIndex = 1;
            this.btMenuInicial.Text = "Menu Inicial";
            this.btMenuInicial.UseVisualStyleBackColor = true;
            this.btMenuInicial.Click += new System.EventHandler(this.btMenuInicial_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Location = new System.Drawing.Point(5, 401);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 28);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuDoadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 441);
            this.Controls.Add(this.gBoxDoacoes);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuDoadores";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuDoadores_FormClosing);
            this.Load += new System.EventHandler(this.MenuDoadores_Load);
            this.gBoxDoacoes.ResumeLayout(false);
            this.gBoxDoacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxDoacoes;
        private System.Windows.Forms.TextBox txtDocDoador;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNomeDoador;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.Label lbNomeDoador;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txtCodDoador;
        private System.Windows.Forms.Label lbCodDoador;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.ComboBox cBoxPFPJ;
        private System.Windows.Forms.Label lbTipoDoador;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doador;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    }
}