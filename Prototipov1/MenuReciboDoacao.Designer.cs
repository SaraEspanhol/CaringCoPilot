﻿namespace Prototipov1
{
    partial class MenuReciboDoacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuReciboDoacao));
            this.gBoxReciboDoacoes = new System.Windows.Forms.GroupBox();
            this.comboDoador = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDataRecibo = new System.Windows.Forms.TextBox();
            this.lbDataRecibo = new System.Windows.Forms.Label();
            this.txtValorRecibo = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.btRecibo = new System.Windows.Forms.Button();
            this.txtONG = new System.Windows.Forms.TextBox();
            this.lbValorRecibo = new System.Windows.Forms.Label();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.lbOrganizacao = new System.Windows.Forms.Label();
            this.lbDoador = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBoxReciboDoacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxReciboDoacoes
            // 
            this.gBoxReciboDoacoes.Controls.Add(this.comboDoador);
            this.gBoxReciboDoacoes.Controls.Add(this.txtCPF);
            this.gBoxReciboDoacoes.Controls.Add(this.txtDataRecibo);
            this.gBoxReciboDoacoes.Controls.Add(this.lbDataRecibo);
            this.gBoxReciboDoacoes.Controls.Add(this.txtValorRecibo);
            this.gBoxReciboDoacoes.Controls.Add(this.txtCNPJ);
            this.gBoxReciboDoacoes.Controls.Add(this.lbCNPJ);
            this.gBoxReciboDoacoes.Controls.Add(this.btRecibo);
            this.gBoxReciboDoacoes.Controls.Add(this.txtONG);
            this.gBoxReciboDoacoes.Controls.Add(this.lbValorRecibo);
            this.gBoxReciboDoacoes.Controls.Add(this.lbDocumento);
            this.gBoxReciboDoacoes.Controls.Add(this.lbOrganizacao);
            this.gBoxReciboDoacoes.Controls.Add(this.lbDoador);
            this.gBoxReciboDoacoes.Controls.Add(this.btMenuInicial);
            this.gBoxReciboDoacoes.Location = new System.Drawing.Point(12, 0);
            this.gBoxReciboDoacoes.Name = "gBoxReciboDoacoes";
            this.gBoxReciboDoacoes.Size = new System.Drawing.Size(308, 289);
            this.gBoxReciboDoacoes.TabIndex = 3;
            this.gBoxReciboDoacoes.TabStop = false;
            this.gBoxReciboDoacoes.Text = "Recibo Doações";
            // 
            // comboDoador
            // 
            this.comboDoador.FormattingEnabled = true;
            this.comboDoador.Location = new System.Drawing.Point(103, 90);
            this.comboDoador.Name = "comboDoador";
            this.comboDoador.Size = new System.Drawing.Size(167, 22);
            this.comboDoador.TabIndex = 38;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(103, 119);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(167, 25);
            this.txtCPF.TabIndex = 37;
            // 
            // txtDataRecibo
            // 
            this.txtDataRecibo.Location = new System.Drawing.Point(103, 147);
            this.txtDataRecibo.Name = "txtDataRecibo";
            this.txtDataRecibo.Size = new System.Drawing.Size(167, 25);
            this.txtDataRecibo.TabIndex = 35;
            // 
            // lbDataRecibo
            // 
            this.lbDataRecibo.AutoSize = true;
            this.lbDataRecibo.Location = new System.Drawing.Point(21, 150);
            this.lbDataRecibo.Name = "lbDataRecibo";
            this.lbDataRecibo.Size = new System.Drawing.Size(31, 14);
            this.lbDataRecibo.TabIndex = 34;
            this.lbDataRecibo.Text = "Data";
            // 
            // txtValorRecibo
            // 
            this.txtValorRecibo.Location = new System.Drawing.Point(103, 203);
            this.txtValorRecibo.Name = "txtValorRecibo";
            this.txtValorRecibo.Size = new System.Drawing.Size(167, 25);
            this.txtValorRecibo.TabIndex = 33;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(103, 59);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(167, 25);
            this.txtCNPJ.TabIndex = 20;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(21, 62);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(34, 14);
            this.lbCNPJ.TabIndex = 19;
            this.lbCNPJ.Text = "CNPJ";
            // 
            // btRecibo
            // 
            this.btRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecibo.Location = new System.Drawing.Point(6, 255);
            this.btRecibo.Name = "btRecibo";
            this.btRecibo.Size = new System.Drawing.Size(95, 28);
            this.btRecibo.TabIndex = 18;
            this.btRecibo.Text = "Recibo";
            this.btRecibo.UseVisualStyleBackColor = true;
            this.btRecibo.Click += new System.EventHandler(this.btRecibo_Click);
            // 
            // txtONG
            // 
            this.txtONG.Location = new System.Drawing.Point(103, 31);
            this.txtONG.Name = "txtONG";
            this.txtONG.Size = new System.Drawing.Size(167, 25);
            this.txtONG.TabIndex = 7;
            // 
            // lbValorRecibo
            // 
            this.lbValorRecibo.AutoSize = true;
            this.lbValorRecibo.Location = new System.Drawing.Point(21, 206);
            this.lbValorRecibo.Name = "lbValorRecibo";
            this.lbValorRecibo.Size = new System.Drawing.Size(49, 14);
            this.lbValorRecibo.TabIndex = 5;
            this.lbValorRecibo.Text = "Valor R$";
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(21, 122);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(64, 14);
            this.lbDocumento.TabIndex = 4;
            this.lbDocumento.Text = "Documento";
            // 
            // lbOrganizacao
            // 
            this.lbOrganizacao.AutoSize = true;
            this.lbOrganizacao.Location = new System.Drawing.Point(21, 34);
            this.lbOrganizacao.Name = "lbOrganizacao";
            this.lbOrganizacao.Size = new System.Drawing.Size(69, 14);
            this.lbOrganizacao.TabIndex = 3;
            this.lbOrganizacao.Text = "Organização";
            // 
            // lbDoador
            // 
            this.lbDoador.AutoSize = true;
            this.lbDoador.Location = new System.Drawing.Point(21, 93);
            this.lbDoador.Name = "lbDoador";
            this.lbDoador.Size = new System.Drawing.Size(43, 14);
            this.lbDoador.TabIndex = 2;
            this.lbDoador.Text = "Doador";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuInicial.Location = new System.Drawing.Point(207, 255);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(95, 28);
            this.btMenuInicial.TabIndex = 1;
            this.btMenuInicial.Text = "Menu Inicial";
            this.btMenuInicial.UseVisualStyleBackColor = true;
            this.btMenuInicial.Click += new System.EventHandler(this.btMenuInicial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 302);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuReciboDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gBoxReciboDoacoes);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuReciboDoacao";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuReciboDoacao_FormClosing);
            this.Load += new System.EventHandler(this.MenuReciboDoacao_Load);
            this.gBoxReciboDoacoes.ResumeLayout(false);
            this.gBoxReciboDoacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxReciboDoacoes;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtDataRecibo;
        private System.Windows.Forms.Label lbDataRecibo;
        private System.Windows.Forms.TextBox txtValorRecibo;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Button btRecibo;
        private System.Windows.Forms.TextBox txtONG;
        private System.Windows.Forms.Label lbValorRecibo;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.Label lbOrganizacao;
        private System.Windows.Forms.Label lbDoador;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.ComboBox comboDoador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}