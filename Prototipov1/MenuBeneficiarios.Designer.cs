﻿namespace Prototipov1
{
    partial class MenuBeneficiarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBeneficiarios));
            this.gBoxDoacoes = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.txtOrgaoEmissor = new System.Windows.Forms.TextBox();
            this.lbEmissor2 = new System.Windows.Forms.Label();
            this.lbEmissor1 = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lbCodDoador = new System.Windows.Forms.Label();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pessoa_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgao_emissor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
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
            this.gBoxDoacoes.Controls.Add(this.txtOrgaoEmissor);
            this.gBoxDoacoes.Controls.Add(this.lbEmissor2);
            this.gBoxDoacoes.Controls.Add(this.lbEmissor1);
            this.gBoxDoacoes.Controls.Add(this.lbRG);
            this.gBoxDoacoes.Controls.Add(this.txtRG);
            this.gBoxDoacoes.Controls.Add(this.lbEmail);
            this.gBoxDoacoes.Controls.Add(this.txtEmail);
            this.gBoxDoacoes.Controls.Add(this.txtTelefone);
            this.gBoxDoacoes.Controls.Add(this.lbTelefone);
            this.gBoxDoacoes.Controls.Add(this.txtCod);
            this.gBoxDoacoes.Controls.Add(this.lbCodDoador);
            this.gBoxDoacoes.Controls.Add(this.btRelatorio);
            this.gBoxDoacoes.Controls.Add(this.btExcluir);
            this.gBoxDoacoes.Controls.Add(this.btAtualizar);
            this.gBoxDoacoes.Controls.Add(this.lbDataNascimento);
            this.gBoxDoacoes.Controls.Add(this.txtDataNasc);
            this.gBoxDoacoes.Controls.Add(this.dataGridView1);
            this.gBoxDoacoes.Controls.Add(this.txtNome);
            this.gBoxDoacoes.Controls.Add(this.lbNomeDoador);
            this.gBoxDoacoes.Controls.Add(this.btMenuInicial);
            this.gBoxDoacoes.Controls.Add(this.btCadastrar);
            this.gBoxDoacoes.Location = new System.Drawing.Point(12, 2);
            this.gBoxDoacoes.Name = "gBoxDoacoes";
            this.gBoxDoacoes.Size = new System.Drawing.Size(723, 428);
            this.gBoxDoacoes.TabIndex = 3;
            this.gBoxDoacoes.TabStop = false;
            this.gBoxDoacoes.Text = "Beneficiários";
            // 
            // btRefresh
            // 
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Location = new System.Drawing.Point(310, 394);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 28);
            this.btRefresh.TabIndex = 36;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // txtOrgaoEmissor
            // 
            this.txtOrgaoEmissor.Location = new System.Drawing.Point(655, 290);
            this.txtOrgaoEmissor.Name = "txtOrgaoEmissor";
            this.txtOrgaoEmissor.Size = new System.Drawing.Size(61, 25);
            this.txtOrgaoEmissor.TabIndex = 35;
            // 
            // lbEmissor2
            // 
            this.lbEmissor2.AutoSize = true;
            this.lbEmissor2.Location = new System.Drawing.Point(596, 297);
            this.lbEmissor2.Name = "lbEmissor2";
            this.lbEmissor2.Size = new System.Drawing.Size(48, 14);
            this.lbEmissor2.TabIndex = 34;
            this.lbEmissor2.Text = "Emissor";
            // 
            // lbEmissor1
            // 
            this.lbEmissor1.AutoSize = true;
            this.lbEmissor1.Location = new System.Drawing.Point(599, 282);
            this.lbEmissor1.Name = "lbEmissor1";
            this.lbEmissor1.Size = new System.Drawing.Size(37, 14);
            this.lbEmissor1.TabIndex = 33;
            this.lbEmissor1.Text = "Orgão";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(382, 293);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(22, 14);
            this.lbRG.TabIndex = 32;
            this.lbRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(411, 290);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(179, 25);
            this.txtRG.TabIndex = 31;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(10, 356);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 14);
            this.lbEmail.TabIndex = 30;
            this.lbEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 353);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(430, 25);
            this.txtEmail.TabIndex = 29;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(589, 353);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 25);
            this.txtTelefone.TabIndex = 28;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(534, 356);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(50, 14);
            this.lbTelefone.TabIndex = 26;
            this.lbTelefone.Text = "Telefone";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(58, 290);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(117, 25);
            this.txtCod.TabIndex = 23;
            // 
            // lbCodDoador
            // 
            this.lbCodDoador.AutoSize = true;
            this.lbCodDoador.Location = new System.Drawing.Point(12, 293);
            this.lbCodDoador.Name = "lbCodDoador";
            this.lbCodDoador.Size = new System.Drawing.Size(42, 14);
            this.lbCodDoador.TabIndex = 22;
            this.lbCodDoador.Text = "Código";
            // 
            // btRelatorio
            // 
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Location = new System.Drawing.Point(521, 394);
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
            this.btExcluir.Location = new System.Drawing.Point(209, 394);
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
            this.btAtualizar.Location = new System.Drawing.Point(108, 394);
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
            this.lbDataNascimento.Location = new System.Drawing.Point(494, 325);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(94, 14);
            this.lbDataNascimento.TabIndex = 15;
            this.lbDataNascimento.Text = "Data Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(589, 322);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(127, 25);
            this.txtDataNasc.TabIndex = 14;
            this.txtDataNasc.TextChanged += new System.EventHandler(this.txtDataNasc_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pessoa_id,
            this.nome_beneficiario,
            this.data_nasc,
            this.rg,
            this.orgao_emissor,
            this.telefone,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 258);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pessoa_id
            // 
            this.pessoa_id.HeaderText = "Item No";
            this.pessoa_id.Name = "pessoa_id";
            this.pessoa_id.Width = 50;
            // 
            // nome_beneficiario
            // 
            this.nome_beneficiario.HeaderText = "Nome";
            this.nome_beneficiario.Name = "nome_beneficiario";
            this.nome_beneficiario.Width = 150;
            // 
            // data_nasc
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.data_nasc.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_nasc.HeaderText = "Data de Nascimento";
            this.data_nasc.Name = "data_nasc";
            // 
            // rg
            // 
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            // 
            // orgao_emissor
            // 
            this.orgao_emissor.HeaderText = "Orgão Emissor";
            this.orgao_emissor.Name = "orgao_emissor";
            this.orgao_emissor.Width = 50;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 120;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 322);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(430, 25);
            this.txtNome.TabIndex = 8;
            // 
            // lbNomeDoador
            // 
            this.lbNomeDoador.AutoSize = true;
            this.lbNomeDoador.Location = new System.Drawing.Point(10, 325);
            this.lbNomeDoador.Name = "lbNomeDoador";
            this.lbNomeDoador.Size = new System.Drawing.Size(36, 14);
            this.lbNomeDoador.TabIndex = 3;
            this.lbNomeDoador.Text = "Nome";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuInicial.Location = new System.Drawing.Point(622, 394);
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
            this.btCadastrar.Location = new System.Drawing.Point(7, 394);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(95, 28);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // MenuBeneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 442);
            this.Controls.Add(this.gBoxDoacoes);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuBeneficiarios";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuBeneficiarios_FormClosing);
            this.Load += new System.EventHandler(this.MenuBeneficiarios_Load);
            this.gBoxDoacoes.ResumeLayout(false);
            this.gBoxDoacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxDoacoes;
        private System.Windows.Forms.TextBox txtOrgaoEmissor;
        private System.Windows.Forms.Label lbEmissor2;
        private System.Windows.Forms.Label lbEmissor1;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lbCodDoador;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeDoador;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoa_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_beneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgao_emissor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}