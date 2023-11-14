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
            this.cBoxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeCadastroEntrada = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gBoxGestaoRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxGestaoRecursos
            // 
            this.gBoxGestaoRecursos.Controls.Add(this.cBoxTipo);
            this.gBoxGestaoRecursos.Controls.Add(this.label1);
            this.gBoxGestaoRecursos.Controls.Add(this.btRelatorio);
            this.gBoxGestaoRecursos.Controls.Add(this.btExcluir);
            this.gBoxGestaoRecursos.Controls.Add(this.btConsultar);
            this.gBoxGestaoRecursos.Controls.Add(this.dataGridView1);
            this.gBoxGestaoRecursos.Controls.Add(this.txtNome);
            this.gBoxGestaoRecursos.Controls.Add(this.lbNomeCadastroEntrada);
            this.gBoxGestaoRecursos.Controls.Add(this.btMenuInicial);
            this.gBoxGestaoRecursos.Controls.Add(this.button1);
            this.gBoxGestaoRecursos.Location = new System.Drawing.Point(12, 12);
            this.gBoxGestaoRecursos.Name = "gBoxGestaoRecursos";
            this.gBoxGestaoRecursos.Size = new System.Drawing.Size(515, 283);
            this.gBoxGestaoRecursos.TabIndex = 1;
            this.gBoxGestaoRecursos.TabStop = false;
            this.gBoxGestaoRecursos.Text = "Plano de Contas";
            // 
            // cBoxTipo
            // 
            this.cBoxTipo.FormattingEnabled = true;
            this.cBoxTipo.Location = new System.Drawing.Point(89, 164);
            this.cBoxTipo.Name = "cBoxTipo";
            this.cBoxTipo.Size = new System.Drawing.Size(144, 21);
            this.cBoxTipo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo";
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(309, 251);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 26);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(208, 251);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(95, 26);
            this.btExcluir.TabIndex = 17;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(107, 251);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(95, 26);
            this.btConsultar.TabIndex = 16;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 126);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(333, 165);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lbNomeCadastroEntrada
            // 
            this.lbNomeCadastroEntrada.AutoSize = true;
            this.lbNomeCadastroEntrada.Location = new System.Drawing.Point(281, 168);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
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
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.gBoxGestaoRecursos.ResumeLayout(false);
            this.gBoxGestaoRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxGestaoRecursos;
        private System.Windows.Forms.ComboBox cBoxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeCadastroEntrada;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button button1;
    }
}