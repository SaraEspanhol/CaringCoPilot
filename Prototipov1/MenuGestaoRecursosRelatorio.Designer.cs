namespace Prototipov1
{
    partial class MenuGestaoRecursosRelatorio
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
            this.gBoxRelatorioRecursos = new System.Windows.Forms.GroupBox();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.txtDataInicial = new System.Windows.Forms.TextBox();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.btExtrairRelatório = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gBoxRelatorioRecursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxRelatorioRecursos
            // 
            this.gBoxRelatorioRecursos.Controls.Add(this.richTextBox1);
            this.gBoxRelatorioRecursos.Controls.Add(this.txtDataFinal);
            this.gBoxRelatorioRecursos.Controls.Add(this.txtDataInicial);
            this.gBoxRelatorioRecursos.Controls.Add(this.lbDataFinal);
            this.gBoxRelatorioRecursos.Controls.Add(this.lbDataInicial);
            this.gBoxRelatorioRecursos.Controls.Add(this.btMenuInicial);
            this.gBoxRelatorioRecursos.Controls.Add(this.btExtrairRelatório);
            this.gBoxRelatorioRecursos.Location = new System.Drawing.Point(12, 12);
            this.gBoxRelatorioRecursos.Name = "gBoxRelatorioRecursos";
            this.gBoxRelatorioRecursos.Size = new System.Drawing.Size(515, 283);
            this.gBoxRelatorioRecursos.TabIndex = 2;
            this.gBoxRelatorioRecursos.TabStop = false;
            this.gBoxRelatorioRecursos.Text = "Gestão de Recursos - Relatório";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(209, 171);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(144, 20);
            this.txtDataFinal.TabIndex = 8;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(209, 116);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(144, 20);
            this.txtDataInicial.TabIndex = 7;
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(138, 174);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(55, 13);
            this.lbDataFinal.TabIndex = 4;
            this.lbDataFinal.Text = "Data Final";
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Location = new System.Drawing.Point(133, 116);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(60, 13);
            this.lbDataInicial.TabIndex = 2;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.Location = new System.Drawing.Point(414, 251);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(95, 26);
            this.btMenuInicial.TabIndex = 1;
            this.btMenuInicial.Text = "Menu Inicial";
            this.btMenuInicial.UseVisualStyleBackColor = true;
            // 
            // btExtrairRelatório
            // 
            this.btExtrairRelatório.Location = new System.Drawing.Point(313, 251);
            this.btExtrairRelatório.Name = "btExtrairRelatório";
            this.btExtrairRelatório.Size = new System.Drawing.Size(95, 26);
            this.btExtrairRelatório.TabIndex = 0;
            this.btExtrairRelatório.Text = "Extrair Relatório";
            this.btExtrairRelatório.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(72, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 36);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Para extrair um relatório de  entradas e saídas, é nesessário inserir uma data in" +
    "icial e uma data final. Após inserir as datas clique no botão \"Extrair Relatório" +
    "\".";
            // 
            // MenuGestaoRecursosRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.gBoxRelatorioRecursos);
            this.Name = "MenuGestaoRecursosRelatorio";
            this.Text = "Gestão de Verbas";
            this.gBoxRelatorioRecursos.ResumeLayout(false);
            this.gBoxRelatorioRecursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRelatorioRecursos;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.TextBox txtDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button btExtrairRelatório;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}