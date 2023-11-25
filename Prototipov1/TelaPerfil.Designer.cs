namespace Prototipov1
{
    partial class TelaPerfil
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPerfil));
            this.gBoxPerfil = new System.Windows.Forms.GroupBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btEditarPerfil = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbNomePerfil = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestãoDeRecursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reembolsoDeDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeContasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voluntáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bazarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDoadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRebiboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beneficiáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_mov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo_acumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxPerfil
            // 
            this.gBoxPerfil.Controls.Add(this.dataGridView1);
            this.gBoxPerfil.Controls.Add(this.Chart1);
            this.gBoxPerfil.Controls.Add(this.btEditarPerfil);
            this.gBoxPerfil.Controls.Add(this.btSair);
            this.gBoxPerfil.Controls.Add(this.lbNomePerfil);
            this.gBoxPerfil.Location = new System.Drawing.Point(12, 36);
            this.gBoxPerfil.Name = "gBoxPerfil";
            this.gBoxPerfil.Size = new System.Drawing.Size(711, 276);
            this.gBoxPerfil.TabIndex = 0;
            this.gBoxPerfil.TabStop = false;
            this.gBoxPerfil.Text = "Perfil";
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(6, 19);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Entradas";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(348, 220);
            this.Chart1.TabIndex = 6;
            this.Chart1.Text = "Movimentações";
            title1.Name = "Title01";
            title1.Text = "Movimentações";
            this.Chart1.Titles.Add(title1);
            this.Chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btEditarPerfil
            // 
            this.btEditarPerfil.Location = new System.Drawing.Point(533, 245);
            this.btEditarPerfil.Name = "btEditarPerfil";
            this.btEditarPerfil.Size = new System.Drawing.Size(92, 22);
            this.btEditarPerfil.TabIndex = 4;
            this.btEditarPerfil.Text = "Editar Perfil";
            this.btEditarPerfil.UseVisualStyleBackColor = true;
            this.btEditarPerfil.Click += new System.EventHandler(this.btEditarPerfil_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(640, 245);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(65, 22);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbNomePerfil
            // 
            this.lbNomePerfil.AutoSize = true;
            this.lbNomePerfil.Location = new System.Drawing.Point(79, 26);
            this.lbNomePerfil.Name = "lbNomePerfil";
            this.lbNomePerfil.Size = new System.Drawing.Size(0, 13);
            this.lbNomePerfil.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeRecursosToolStripMenuItem,
            this.voluntáriosToolStripMenuItem,
            this.doaçõesToolStripMenuItem,
            this.doaçõesToolStripMenuItem1,
            this.beneficiáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestãoDeRecursosToolStripMenuItem
            // 
            this.gestãoDeRecursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleFinanceiroToolStripMenuItem,
            this.reembolsoDeDespesasToolStripMenuItem,
            this.planoDeContasToolStripMenuItem1});
            this.gestãoDeRecursosToolStripMenuItem.Name = "gestãoDeRecursosToolStripMenuItem";
            this.gestãoDeRecursosToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.gestãoDeRecursosToolStripMenuItem.Text = "Gestão de Recursos";
            // 
            // controleFinanceiroToolStripMenuItem
            // 
            this.controleFinanceiroToolStripMenuItem.Name = "controleFinanceiroToolStripMenuItem";
            this.controleFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.controleFinanceiroToolStripMenuItem.Text = "Controle Financeiro";
            this.controleFinanceiroToolStripMenuItem.Click += new System.EventHandler(this.controleFinanceiroToolStripMenuItem_Click_1);
            // 
            // reembolsoDeDespesasToolStripMenuItem
            // 
            this.reembolsoDeDespesasToolStripMenuItem.Name = "reembolsoDeDespesasToolStripMenuItem";
            this.reembolsoDeDespesasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.reembolsoDeDespesasToolStripMenuItem.Text = "Reembolso de Despesas";
            this.reembolsoDeDespesasToolStripMenuItem.Click += new System.EventHandler(this.reembolsoDeDespesasToolStripMenuItem_Click);
            // 
            // planoDeContasToolStripMenuItem1
            // 
            this.planoDeContasToolStripMenuItem1.Name = "planoDeContasToolStripMenuItem1";
            this.planoDeContasToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.planoDeContasToolStripMenuItem1.Text = "Plano de Contas";
            this.planoDeContasToolStripMenuItem1.Click += new System.EventHandler(this.planoDeContasToolStripMenuItem1_Click);
            // 
            // voluntáriosToolStripMenuItem
            // 
            this.voluntáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.atualizaçãoCadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.voluntáriosToolStripMenuItem.Name = "voluntáriosToolStripMenuItem";
            this.voluntáriosToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.voluntáriosToolStripMenuItem.Text = "Voluntários";
            this.voluntáriosToolStripMenuItem.Visible = false;
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // atualizaçãoCadastroToolStripMenuItem
            // 
            this.atualizaçãoCadastroToolStripMenuItem.Name = "atualizaçãoCadastroToolStripMenuItem";
            this.atualizaçãoCadastroToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.atualizaçãoCadastroToolStripMenuItem.Text = "Atividades";
            this.atualizaçãoCadastroToolStripMenuItem.Click += new System.EventHandler(this.atualizaçãoCadastroToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // doaçõesToolStripMenuItem
            // 
            this.doaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.saídasToolStripMenuItem1,
            this.controleDeEstoqueToolStripMenuItem});
            this.doaçõesToolStripMenuItem.Name = "doaçõesToolStripMenuItem";
            this.doaçõesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.doaçõesToolStripMenuItem.Text = "Estoque";
            this.doaçõesToolStripMenuItem.Visible = false;
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doaçãoToolStripMenuItem,
            this.compraToolStripMenuItem});
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.doaçãoToolStripMenuItem.Text = "Doação";
            this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // saídasToolStripMenuItem1
            // 
            this.saídasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doaçãoToolStripMenuItem1,
            this.bazarToolStripMenuItem1});
            this.saídasToolStripMenuItem1.Name = "saídasToolStripMenuItem1";
            this.saídasToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.saídasToolStripMenuItem1.Text = "Saídas";
            // 
            // doaçãoToolStripMenuItem1
            // 
            this.doaçãoToolStripMenuItem1.Name = "doaçãoToolStripMenuItem1";
            this.doaçãoToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.doaçãoToolStripMenuItem1.Text = "Doação";
            this.doaçãoToolStripMenuItem1.Click += new System.EventHandler(this.doaçãoToolStripMenuItem1_Click);
            // 
            // bazarToolStripMenuItem1
            // 
            this.bazarToolStripMenuItem1.Name = "bazarToolStripMenuItem1";
            this.bazarToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.bazarToolStripMenuItem1.Text = "Bazar";
            this.bazarToolStripMenuItem1.Click += new System.EventHandler(this.bazarToolStripMenuItem1_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // doaçõesToolStripMenuItem1
            // 
            this.doaçõesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDoadoresToolStripMenuItem,
            this.gerarRebiboToolStripMenuItem});
            this.doaçõesToolStripMenuItem1.Name = "doaçõesToolStripMenuItem1";
            this.doaçõesToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.doaçõesToolStripMenuItem1.Text = "Doações";
            // 
            // cadastroDoadoresToolStripMenuItem
            // 
            this.cadastroDoadoresToolStripMenuItem.Name = "cadastroDoadoresToolStripMenuItem";
            this.cadastroDoadoresToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cadastroDoadoresToolStripMenuItem.Text = "Cadastro Doadores";
            this.cadastroDoadoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDoadoresToolStripMenuItem_Click_1);
            // 
            // gerarRebiboToolStripMenuItem
            // 
            this.gerarRebiboToolStripMenuItem.Name = "gerarRebiboToolStripMenuItem";
            this.gerarRebiboToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gerarRebiboToolStripMenuItem.Text = "Gerar Rebibo";
            this.gerarRebiboToolStripMenuItem.Click += new System.EventHandler(this.gerarRebiboToolStripMenuItem_Click);
            // 
            // beneficiáriosToolStripMenuItem
            // 
            this.beneficiáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.beneficiáriosToolStripMenuItem.Name = "beneficiáriosToolStripMenuItem";
            this.beneficiáriosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.beneficiáriosToolStripMenuItem.Text = "Beneficiários";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.cadastroToolStripMenuItem1.Text = "Gestão de Beneficiários";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_mov,
            this.descricao,
            this.valor,
            this.saldo_acumulado});
            this.dataGridView1.Location = new System.Drawing.Point(360, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 220);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // saldo_acumulado
            // 
            this.saldo_acumulado.HeaderText = "Valor Total";
            this.saldo_acumulado.Name = "saldo_acumulado";
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 316);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gBoxPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPerfil";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.TelaPerfil_Load);
            this.gBoxPerfil.ResumeLayout(false);
            this.gBoxPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxPerfil;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbNomePerfil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeRecursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reembolsoDeDespesasToolStripMenuItem;
        private System.Windows.Forms.Button btEditarPerfil;
        private System.Windows.Forms.ToolStripMenuItem voluntáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeContasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controleFinanceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDoadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bazarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarRebiboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beneficiáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_mov;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo_acumulado;
    }
}