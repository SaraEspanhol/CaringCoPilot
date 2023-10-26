namespace Prototipov1
{
    partial class TelaRelatorioControleFinanceiro
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
            this.gBoxRelatorio = new System.Windows.Forms.GroupBox();
            this.lbIncluir = new System.Windows.Forms.Label();
            this.checkSaida = new System.Windows.Forms.CheckBox();
            this.checkEntrada = new System.Windows.Forms.CheckBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.txtDataCadastroEntrada = new System.Windows.Forms.TextBox();
            this.lbDatas = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbAte = new System.Windows.Forms.Label();
            this.lbContas = new System.Windows.Forms.Label();
            this.comboBoxContas = new System.Windows.Forms.ComboBox();
            this.lbDoadores = new System.Windows.Forms.Label();
            this.comboBoxDoadores = new System.Windows.Forms.ComboBox();
            this.lbBeneficiarios = new System.Windows.Forms.Label();
            this.comboBoxBeneficiarios = new System.Windows.Forms.ComboBox();
            this.gBoxRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxRelatorio
            // 
            this.gBoxRelatorio.Controls.Add(this.comboBoxBeneficiarios);
            this.gBoxRelatorio.Controls.Add(this.lbBeneficiarios);
            this.gBoxRelatorio.Controls.Add(this.comboBoxDoadores);
            this.gBoxRelatorio.Controls.Add(this.lbDoadores);
            this.gBoxRelatorio.Controls.Add(this.comboBoxContas);
            this.gBoxRelatorio.Controls.Add(this.lbContas);
            this.gBoxRelatorio.Controls.Add(this.lbAte);
            this.gBoxRelatorio.Controls.Add(this.textBox1);
            this.gBoxRelatorio.Controls.Add(this.chart1);
            this.gBoxRelatorio.Controls.Add(this.lbIncluir);
            this.gBoxRelatorio.Controls.Add(this.checkSaida);
            this.gBoxRelatorio.Controls.Add(this.checkEntrada);
            this.gBoxRelatorio.Controls.Add(this.btRelatorio);
            this.gBoxRelatorio.Controls.Add(this.txtDataCadastroEntrada);
            this.gBoxRelatorio.Controls.Add(this.lbDatas);
            this.gBoxRelatorio.Controls.Add(this.btMenuInicial);
            this.gBoxRelatorio.Location = new System.Drawing.Point(12, 12);
            this.gBoxRelatorio.Name = "gBoxRelatorio";
            this.gBoxRelatorio.Size = new System.Drawing.Size(515, 283);
            this.gBoxRelatorio.TabIndex = 1;
            this.gBoxRelatorio.TabStop = false;
            this.gBoxRelatorio.Text = "Relatório";
            // 
            // lbIncluir
            // 
            this.lbIncluir.AutoSize = true;
            this.lbIncluir.Location = new System.Drawing.Point(306, 19);
            this.lbIncluir.Name = "lbIncluir";
            this.lbIncluir.Size = new System.Drawing.Size(98, 13);
            this.lbIncluir.TabIndex = 21;
            this.lbIncluir.Text = "Incluir no Relatório:";
            // 
            // checkSaida
            // 
            this.checkSaida.AutoSize = true;
            this.checkSaida.Location = new System.Drawing.Point(387, 45);
            this.checkSaida.Name = "checkSaida";
            this.checkSaida.Size = new System.Drawing.Size(55, 17);
            this.checkSaida.TabIndex = 20;
            this.checkSaida.Text = "Saída";
            this.checkSaida.UseVisualStyleBackColor = true;
            // 
            // checkEntrada
            // 
            this.checkEntrada.AutoSize = true;
            this.checkEntrada.Location = new System.Drawing.Point(309, 45);
            this.checkEntrada.Name = "checkEntrada";
            this.checkEntrada.Size = new System.Drawing.Size(63, 17);
            this.checkEntrada.TabIndex = 19;
            this.checkEntrada.Text = "Entrada";
            this.checkEntrada.UseVisualStyleBackColor = true;
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(309, 251);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 26);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Extrair";
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // txtDataCadastroEntrada
            // 
            this.txtDataCadastroEntrada.Location = new System.Drawing.Point(309, 91);
            this.txtDataCadastroEntrada.Name = "txtDataCadastroEntrada";
            this.txtDataCadastroEntrada.Size = new System.Drawing.Size(80, 20);
            this.txtDataCadastroEntrada.TabIndex = 7;
            // 
            // lbDatas
            // 
            this.lbDatas.AutoSize = true;
            this.lbDatas.Location = new System.Drawing.Point(306, 75);
            this.lbDatas.Name = "lbDatas";
            this.lbDatas.Size = new System.Drawing.Size(38, 13);
            this.lbDatas.TabIndex = 2;
            this.lbDatas.Text = "Datas:";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.Location = new System.Drawing.Point(410, 251);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(95, 26);
            this.btMenuInicial.TabIndex = 1;
            this.btMenuInicial.Text = "Menu Inicial";
            this.btMenuInicial.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(282, 248);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 23;
            // 
            // lbAte
            // 
            this.lbAte.AutoSize = true;
            this.lbAte.Location = new System.Drawing.Point(397, 94);
            this.lbAte.Name = "lbAte";
            this.lbAte.Size = new System.Drawing.Size(22, 13);
            this.lbAte.TabIndex = 24;
            this.lbAte.Text = "até";
            // 
            // lbContas
            // 
            this.lbContas.AutoSize = true;
            this.lbContas.Location = new System.Drawing.Point(308, 118);
            this.lbContas.Name = "lbContas";
            this.lbContas.Size = new System.Drawing.Size(40, 13);
            this.lbContas.TabIndex = 25;
            this.lbContas.Text = "Contas";
            // 
            // comboBoxContas
            // 
            this.comboBoxContas.FormattingEnabled = true;
            this.comboBoxContas.Location = new System.Drawing.Point(309, 134);
            this.comboBoxContas.Name = "comboBoxContas";
            this.comboBoxContas.Size = new System.Drawing.Size(196, 21);
            this.comboBoxContas.TabIndex = 26;
            // 
            // lbDoadores
            // 
            this.lbDoadores.AutoSize = true;
            this.lbDoadores.Location = new System.Drawing.Point(308, 158);
            this.lbDoadores.Name = "lbDoadores";
            this.lbDoadores.Size = new System.Drawing.Size(53, 13);
            this.lbDoadores.TabIndex = 27;
            this.lbDoadores.Text = "Doadores";
            // 
            // comboBoxDoadores
            // 
            this.comboBoxDoadores.FormattingEnabled = true;
            this.comboBoxDoadores.Location = new System.Drawing.Point(309, 174);
            this.comboBoxDoadores.Name = "comboBoxDoadores";
            this.comboBoxDoadores.Size = new System.Drawing.Size(196, 21);
            this.comboBoxDoadores.TabIndex = 28;
            // 
            // lbBeneficiarios
            // 
            this.lbBeneficiarios.AutoSize = true;
            this.lbBeneficiarios.Location = new System.Drawing.Point(308, 198);
            this.lbBeneficiarios.Name = "lbBeneficiarios";
            this.lbBeneficiarios.Size = new System.Drawing.Size(67, 13);
            this.lbBeneficiarios.TabIndex = 29;
            this.lbBeneficiarios.Text = "Beneficiários";
            // 
            // comboBoxBeneficiarios
            // 
            this.comboBoxBeneficiarios.FormattingEnabled = true;
            this.comboBoxBeneficiarios.Location = new System.Drawing.Point(309, 214);
            this.comboBoxBeneficiarios.Name = "comboBoxBeneficiarios";
            this.comboBoxBeneficiarios.Size = new System.Drawing.Size(196, 21);
            this.comboBoxBeneficiarios.TabIndex = 30;
            // 
            // TelaRelatorioControleFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.gBoxRelatorio);
            this.Name = "TelaRelatorioControleFinanceiro";
            this.Text = "CaringCoPilot";
            this.gBoxRelatorio.ResumeLayout(false);
            this.gBoxRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRelatorio;
        private System.Windows.Forms.CheckBox checkSaida;
        private System.Windows.Forms.CheckBox checkEntrada;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.TextBox txtDataCadastroEntrada;
        private System.Windows.Forms.Label lbDatas;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Label lbIncluir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbContas;
        private System.Windows.Forms.Label lbAte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxBeneficiarios;
        private System.Windows.Forms.Label lbBeneficiarios;
        private System.Windows.Forms.ComboBox comboBoxDoadores;
        private System.Windows.Forms.Label lbDoadores;
        private System.Windows.Forms.ComboBox comboBoxContas;
    }
}