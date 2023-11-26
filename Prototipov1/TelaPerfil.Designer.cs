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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPerfil));
            this.gBoxPerfil = new System.Windows.Forms.GroupBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbNomePerfil = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mesAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mes_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contagem_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSair = new System.Windows.Forms.Button();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btControleFinanceiro = new System.Windows.Forms.Button();
            this.btPlanoDeContas = new System.Windows.Forms.Button();
            this.btReembolso = new System.Windows.Forms.Button();
            this.btDoadores = new System.Windows.Forms.Button();
            this.btRecibo = new System.Windows.Forms.Button();
            this.btBeneficiarios = new System.Windows.Forms.Button();
            this.gBoxPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxPerfil
            // 
            this.gBoxPerfil.Controls.Add(this.Chart1);
            this.gBoxPerfil.Controls.Add(this.lbNomePerfil);
            this.gBoxPerfil.Controls.Add(this.dataGridView1);
            this.gBoxPerfil.Controls.Add(this.dataGridView2);
            this.gBoxPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gBoxPerfil.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPerfil.Location = new System.Drawing.Point(153, 42);
            this.gBoxPerfil.Name = "gBoxPerfil";
            this.gBoxPerfil.Size = new System.Drawing.Size(378, 278);
            this.gBoxPerfil.TabIndex = 0;
            this.gBoxPerfil.TabStop = false;
            // 
            // Chart1
            // 
            chartArea1.Area3DStyle.Inclination = 45;
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(16, 20);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Entradas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Saidas";
            this.Chart1.Series.Add(series1);
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(343, 252);
            this.Chart1.TabIndex = 6;
            this.Chart1.TabStop = false;
            this.Chart1.Text = "Movimentações";
            title1.Name = "Title01";
            title1.Text = "Movimentações";
            this.Chart1.Titles.Add(title1);
            this.Chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbNomePerfil
            // 
            this.lbNomePerfil.AutoSize = true;
            this.lbNomePerfil.Location = new System.Drawing.Point(79, 28);
            this.lbNomePerfil.Name = "lbNomePerfil";
            this.lbNomePerfil.Size = new System.Drawing.Size(0, 14);
            this.lbNomePerfil.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesAno,
            this.Contagem,
            this.valor_total});
            this.dataGridView1.Location = new System.Drawing.Point(16, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 138);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mesAno
            // 
            this.mesAno.HeaderText = "Mês/Ano";
            this.mesAno.Name = "mesAno";
            // 
            // Contagem
            // 
            this.Contagem.HeaderText = "Contagem";
            this.Contagem.Name = "Contagem";
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor";
            this.valor_total.Name = "valor_total";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mes_Ano,
            this.contagem_,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(16, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(236, 138);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Visible = false;
            // 
            // mes_Ano
            // 
            this.mes_Ano.HeaderText = "Mês/Ano";
            this.mes_Ano.Name = "mes_Ano";
            // 
            // contagem_
            // 
            this.contagem_.HeaderText = "Contagem";
            this.contagem_.Name = "contagem_";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valor_total";
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Location = new System.Drawing.Point(464, 341);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(65, 24);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeRecursosToolStripMenuItem,
            this.voluntáriosToolStripMenuItem,
            this.doaçõesToolStripMenuItem,
            this.doaçõesToolStripMenuItem1,
            this.beneficiáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // gestãoDeRecursosToolStripMenuItem
            // 
            this.gestãoDeRecursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleFinanceiroToolStripMenuItem,
            this.reembolsoDeDespesasToolStripMenuItem,
            this.planoDeContasToolStripMenuItem1});
            this.gestãoDeRecursosToolStripMenuItem.Name = "gestãoDeRecursosToolStripMenuItem";
            this.gestãoDeRecursosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestãoDeRecursosToolStripMenuItem.Text = "Gestão de Recursos";
            // 
            // controleFinanceiroToolStripMenuItem
            // 
            this.controleFinanceiroToolStripMenuItem.Name = "controleFinanceiroToolStripMenuItem";
            this.controleFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.controleFinanceiroToolStripMenuItem.Text = "Controle Financeiro";
            this.controleFinanceiroToolStripMenuItem.Click += new System.EventHandler(this.controleFinanceiroToolStripMenuItem_Click_1);
            // 
            // reembolsoDeDespesasToolStripMenuItem
            // 
            this.reembolsoDeDespesasToolStripMenuItem.Name = "reembolsoDeDespesasToolStripMenuItem";
            this.reembolsoDeDespesasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.reembolsoDeDespesasToolStripMenuItem.Text = "Reembolso de Despesas";
            this.reembolsoDeDespesasToolStripMenuItem.Click += new System.EventHandler(this.reembolsoDeDespesasToolStripMenuItem_Click);
            // 
            // planoDeContasToolStripMenuItem1
            // 
            this.planoDeContasToolStripMenuItem1.Name = "planoDeContasToolStripMenuItem1";
            this.planoDeContasToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
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
            this.voluntáriosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.voluntáriosToolStripMenuItem.Text = "Voluntários";
            this.voluntáriosToolStripMenuItem.Visible = false;
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // atualizaçãoCadastroToolStripMenuItem
            // 
            this.atualizaçãoCadastroToolStripMenuItem.Name = "atualizaçãoCadastroToolStripMenuItem";
            this.atualizaçãoCadastroToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.atualizaçãoCadastroToolStripMenuItem.Text = "Atividades";
            this.atualizaçãoCadastroToolStripMenuItem.Click += new System.EventHandler(this.atualizaçãoCadastroToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            this.doaçõesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.doaçõesToolStripMenuItem.Text = "Estoque";
            this.doaçõesToolStripMenuItem.Visible = false;
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doaçãoToolStripMenuItem,
            this.compraToolStripMenuItem});
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.doaçãoToolStripMenuItem.Text = "Doação";
            this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // saídasToolStripMenuItem1
            // 
            this.saídasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doaçãoToolStripMenuItem1,
            this.bazarToolStripMenuItem1});
            this.saídasToolStripMenuItem1.Name = "saídasToolStripMenuItem1";
            this.saídasToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.saídasToolStripMenuItem1.Text = "Saídas";
            // 
            // doaçãoToolStripMenuItem1
            // 
            this.doaçãoToolStripMenuItem1.Name = "doaçãoToolStripMenuItem1";
            this.doaçãoToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.doaçãoToolStripMenuItem1.Text = "Doação";
            this.doaçãoToolStripMenuItem1.Click += new System.EventHandler(this.doaçãoToolStripMenuItem1_Click);
            // 
            // bazarToolStripMenuItem1
            // 
            this.bazarToolStripMenuItem1.Name = "bazarToolStripMenuItem1";
            this.bazarToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.bazarToolStripMenuItem1.Text = "Bazar";
            this.bazarToolStripMenuItem1.Click += new System.EventHandler(this.bazarToolStripMenuItem1_Click);
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de Estoque";
            this.controleDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.controleDeEstoqueToolStripMenuItem_Click);
            // 
            // doaçõesToolStripMenuItem1
            // 
            this.doaçõesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDoadoresToolStripMenuItem,
            this.gerarRebiboToolStripMenuItem});
            this.doaçõesToolStripMenuItem1.Name = "doaçõesToolStripMenuItem1";
            this.doaçõesToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.doaçõesToolStripMenuItem1.Text = "Doações";
            // 
            // cadastroDoadoresToolStripMenuItem
            // 
            this.cadastroDoadoresToolStripMenuItem.Name = "cadastroDoadoresToolStripMenuItem";
            this.cadastroDoadoresToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastroDoadoresToolStripMenuItem.Text = "Cadastro Doadores";
            this.cadastroDoadoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDoadoresToolStripMenuItem_Click_1);
            // 
            // gerarRebiboToolStripMenuItem
            // 
            this.gerarRebiboToolStripMenuItem.Name = "gerarRebiboToolStripMenuItem";
            this.gerarRebiboToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gerarRebiboToolStripMenuItem.Text = "Gerar Rebibo";
            this.gerarRebiboToolStripMenuItem.Click += new System.EventHandler(this.gerarRebiboToolStripMenuItem_Click);
            // 
            // beneficiáriosToolStripMenuItem
            // 
            this.beneficiáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.beneficiáriosToolStripMenuItem.Name = "beneficiáriosToolStripMenuItem";
            this.beneficiáriosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.beneficiáriosToolStripMenuItem.Text = "Beneficiários";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.cadastroToolStripMenuItem1.Text = "Gestão de Beneficiários";
            this.cadastroToolStripMenuItem1.Click += new System.EventHandler(this.cadastroToolStripMenuItem1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 381);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btControleFinanceiro
            // 
            this.btControleFinanceiro.BackColor = System.Drawing.SystemColors.Control;
            this.btControleFinanceiro.FlatAppearance.BorderSize = 0;
            this.btControleFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btControleFinanceiro.Font = new System.Drawing.Font("Yu Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btControleFinanceiro.ForeColor = System.Drawing.SystemColors.Control;
            this.btControleFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btControleFinanceiro.Image")));
            this.btControleFinanceiro.Location = new System.Drawing.Point(19, 3);
            this.btControleFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.btControleFinanceiro.Name = "btControleFinanceiro";
            this.btControleFinanceiro.Size = new System.Drawing.Size(96, 59);
            this.btControleFinanceiro.TabIndex = 11;
            this.btControleFinanceiro.Text = "Financeiro";
            this.btControleFinanceiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btControleFinanceiro.UseVisualStyleBackColor = false;
            this.btControleFinanceiro.Click += new System.EventHandler(this.btControleFinanceiro_Click);
            // 
            // btPlanoDeContas
            // 
            this.btPlanoDeContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlanoDeContas.Font = new System.Drawing.Font("Yu Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlanoDeContas.ForeColor = System.Drawing.SystemColors.Control;
            this.btPlanoDeContas.Image = ((System.Drawing.Image)(resources.GetObject("btPlanoDeContas.Image")));
            this.btPlanoDeContas.Location = new System.Drawing.Point(19, 68);
            this.btPlanoDeContas.Margin = new System.Windows.Forms.Padding(0);
            this.btPlanoDeContas.Name = "btPlanoDeContas";
            this.btPlanoDeContas.Size = new System.Drawing.Size(96, 59);
            this.btPlanoDeContas.TabIndex = 12;
            this.btPlanoDeContas.Text = "Plano de Contas";
            this.btPlanoDeContas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPlanoDeContas.UseVisualStyleBackColor = true;
            this.btPlanoDeContas.Click += new System.EventHandler(this.btPlanoDeContas_Click);
            // 
            // btReembolso
            // 
            this.btReembolso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReembolso.Font = new System.Drawing.Font("Yu Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReembolso.ForeColor = System.Drawing.SystemColors.Control;
            this.btReembolso.Image = ((System.Drawing.Image)(resources.GetObject("btReembolso.Image")));
            this.btReembolso.Location = new System.Drawing.Point(19, 130);
            this.btReembolso.Margin = new System.Windows.Forms.Padding(0);
            this.btReembolso.Name = "btReembolso";
            this.btReembolso.Size = new System.Drawing.Size(96, 59);
            this.btReembolso.TabIndex = 13;
            this.btReembolso.Text = "Reembolso";
            this.btReembolso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReembolso.UseVisualStyleBackColor = true;
            this.btReembolso.Click += new System.EventHandler(this.btReembolso_Click);
            // 
            // btDoadores
            // 
            this.btDoadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDoadores.Font = new System.Drawing.Font("Yu Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoadores.ForeColor = System.Drawing.SystemColors.Control;
            this.btDoadores.Image = ((System.Drawing.Image)(resources.GetObject("btDoadores.Image")));
            this.btDoadores.Location = new System.Drawing.Point(19, 192);
            this.btDoadores.Margin = new System.Windows.Forms.Padding(0);
            this.btDoadores.Name = "btDoadores";
            this.btDoadores.Size = new System.Drawing.Size(96, 59);
            this.btDoadores.TabIndex = 14;
            this.btDoadores.Text = "Doadores";
            this.btDoadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDoadores.UseVisualStyleBackColor = true;
            this.btDoadores.Click += new System.EventHandler(this.btDoadores_Click);
            // 
            // btRecibo
            // 
            this.btRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecibo.Font = new System.Drawing.Font("Yu Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecibo.ForeColor = System.Drawing.SystemColors.Control;
            this.btRecibo.Image = ((System.Drawing.Image)(resources.GetObject("btRecibo.Image")));
            this.btRecibo.Location = new System.Drawing.Point(19, 253);
            this.btRecibo.Margin = new System.Windows.Forms.Padding(0);
            this.btRecibo.Name = "btRecibo";
            this.btRecibo.Size = new System.Drawing.Size(96, 59);
            this.btRecibo.TabIndex = 15;
            this.btRecibo.Text = "Recibo";
            this.btRecibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRecibo.UseVisualStyleBackColor = true;
            this.btRecibo.Click += new System.EventHandler(this.btRecibo_Click);
            // 
            // btBeneficiarios
            // 
            this.btBeneficiarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBeneficiarios.Font = new System.Drawing.Font("Yu Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBeneficiarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btBeneficiarios.Image = ((System.Drawing.Image)(resources.GetObject("btBeneficiarios.Image")));
            this.btBeneficiarios.Location = new System.Drawing.Point(19, 314);
            this.btBeneficiarios.Margin = new System.Windows.Forms.Padding(0);
            this.btBeneficiarios.Name = "btBeneficiarios";
            this.btBeneficiarios.Size = new System.Drawing.Size(96, 59);
            this.btBeneficiarios.TabIndex = 16;
            this.btBeneficiarios.Text = "Beneficiários";
            this.btBeneficiarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBeneficiarios.UseVisualStyleBackColor = true;
            this.btBeneficiarios.Click += new System.EventHandler(this.btBeneficiarios_Click);
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 377);
            this.Controls.Add(this.btBeneficiarios);
            this.Controls.Add(this.btRecibo);
            this.Controls.Add(this.btDoadores);
            this.Controls.Add(this.btReembolso);
            this.Controls.Add(this.btPlanoDeContas);
            this.Controls.Add(this.btControleFinanceiro);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gBoxPerfil);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaPerfil";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.TelaPerfil_Load);
            this.gBoxPerfil.ResumeLayout(false);
            this.gBoxPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes_Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn contagem_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btControleFinanceiro;
        private System.Windows.Forms.Button btPlanoDeContas;
        private System.Windows.Forms.Button btReembolso;
        private System.Windows.Forms.Button btDoadores;
        private System.Windows.Forms.Button btRecibo;
        private System.Windows.Forms.Button btBeneficiarios;
    }
}