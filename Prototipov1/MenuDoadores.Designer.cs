﻿namespace Prototipov1
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
            this.tipo_doador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gBoxDoacoes.Location = new System.Drawing.Point(12, 12);
            this.gBoxDoacoes.Name = "gBoxDoacoes";
            this.gBoxDoacoes.Size = new System.Drawing.Size(763, 283);
            this.gBoxDoacoes.TabIndex = 2;
            this.gBoxDoacoes.TabStop = false;
            this.gBoxDoacoes.Text = "Doadores";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(309, 251);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 26);
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
            this.cBoxPFPJ.Location = new System.Drawing.Point(217, 154);
            this.cBoxPFPJ.Name = "cBoxPFPJ";
            this.cBoxPFPJ.Size = new System.Drawing.Size(130, 21);
            this.cBoxPFPJ.TabIndex = 32;
            // 
            // lbTipoDoador
            // 
            this.lbTipoDoador.AutoSize = true;
            this.lbTipoDoador.Location = new System.Drawing.Point(174, 158);
            this.lbTipoDoador.Name = "lbTipoDoador";
            this.lbTipoDoador.Size = new System.Drawing.Size(28, 13);
            this.lbTipoDoador.TabIndex = 31;
            this.lbTipoDoador.Text = "Tipo";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(13, 214);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 30;
            this.lbEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(450, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(622, 214);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 20);
            this.txtTelefone.TabIndex = 28;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(527, 217);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 26;
            this.lbTelefone.Text = "Telefone";
            // 
            // txtCodDoador
            // 
            this.txtCodDoador.Location = new System.Drawing.Point(59, 155);
            this.txtCodDoador.Name = "txtCodDoador";
            this.txtCodDoador.Size = new System.Drawing.Size(59, 20);
            this.txtCodDoador.TabIndex = 23;
            // 
            // lbCodDoador
            // 
            this.lbCodDoador.AutoSize = true;
            this.lbCodDoador.Location = new System.Drawing.Point(13, 158);
            this.lbCodDoador.Name = "lbCodDoador";
            this.lbCodDoador.Size = new System.Drawing.Size(40, 13);
            this.lbCodDoador.TabIndex = 22;
            this.lbCodDoador.Text = "Código";
            // 
            // txtDocDoador
            // 
            this.txtDocDoador.Location = new System.Drawing.Point(521, 155);
            this.txtDocDoador.Name = "txtDocDoador";
            this.txtDocDoador.Size = new System.Drawing.Size(228, 20);
            this.txtDocDoador.TabIndex = 21;
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(561, 251);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 26);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
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
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(527, 191);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lbDataNascimento.TabIndex = 15;
            this.lbDataNascimento.Text = "Data Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(622, 188);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(127, 20);
            this.txtDataNasc.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipo_doador,
            this.documento,
            this.nome,
            this.data_nasc,
            this.email,
            this.telefone});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 126);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Item No";
            this.id.Name = "id";
            this.id.Width = 50;
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
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // data_nasc
            // 
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
            this.txtNomeDoador.Location = new System.Drawing.Point(59, 185);
            this.txtNomeDoador.Name = "txtNomeDoador";
            this.txtNomeDoador.Size = new System.Drawing.Size(450, 20);
            this.txtNomeDoador.TabIndex = 8;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(447, 160);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(62, 13);
            this.lbDocumento.TabIndex = 5;
            this.lbDocumento.Text = "Documento";
            // 
            // lbNomeDoador
            // 
            this.lbNomeDoador.AutoSize = true;
            this.lbNomeDoador.Location = new System.Drawing.Point(13, 185);
            this.lbNomeDoador.Name = "lbNomeDoador";
            this.lbNomeDoador.Size = new System.Drawing.Size(35, 13);
            this.lbNomeDoador.TabIndex = 3;
            this.lbNomeDoador.Text = "Nome";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.Location = new System.Drawing.Point(662, 251);
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
            this.btCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuDoadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 307);
            this.Controls.Add(this.gBoxDoacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuDoadores";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doador;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.ComboBox cBoxPFPJ;
        private System.Windows.Forms.Label lbTipoDoador;
        private System.Windows.Forms.Button btRefresh;
    }
}