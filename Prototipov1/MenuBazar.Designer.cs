namespace Prototipov1
{
    partial class MenuBazar
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
            this.gBoxGestaoRecursos = new System.Windows.Forms.GroupBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtNomeBazar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCodBazar = new System.Windows.Forms.TextBox();
            this.txtDataVoluntario = new System.Windows.Forms.TextBox();
            this.lbNomeBazar = new System.Windows.Forms.Label();
            this.lbCodBazar = new System.Windows.Forms.Label();
            this.lbDataBazar = new System.Windows.Forms.Label();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.btCriarBazar = new System.Windows.Forms.Button();
            this.gBoxGestaoRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxGestaoRecursos
            // 
            this.gBoxGestaoRecursos.Controls.Add(this.btRelatorio);
            this.gBoxGestaoRecursos.Controls.Add(this.btExcluir);
            this.gBoxGestaoRecursos.Controls.Add(this.btConsultar);
            this.gBoxGestaoRecursos.Controls.Add(this.txtNomeBazar);
            this.gBoxGestaoRecursos.Controls.Add(this.dataGridView1);
            this.gBoxGestaoRecursos.Controls.Add(this.txtCodBazar);
            this.gBoxGestaoRecursos.Controls.Add(this.txtDataVoluntario);
            this.gBoxGestaoRecursos.Controls.Add(this.lbNomeBazar);
            this.gBoxGestaoRecursos.Controls.Add(this.lbCodBazar);
            this.gBoxGestaoRecursos.Controls.Add(this.lbDataBazar);
            this.gBoxGestaoRecursos.Controls.Add(this.btMenuInicial);
            this.gBoxGestaoRecursos.Controls.Add(this.btCriarBazar);
            this.gBoxGestaoRecursos.Location = new System.Drawing.Point(12, 12);
            this.gBoxGestaoRecursos.Name = "gBoxGestaoRecursos";
            this.gBoxGestaoRecursos.Size = new System.Drawing.Size(515, 283);
            this.gBoxGestaoRecursos.TabIndex = 2;
            this.gBoxGestaoRecursos.TabStop = false;
            this.gBoxGestaoRecursos.Text = "Bazar";
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(309, 251);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(95, 26);
            this.btRelatorio.TabIndex = 18;
            this.btRelatorio.Text = "Lista Geral";
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
            // txtNomeBazar
            // 
            this.txtNomeBazar.Location = new System.Drawing.Point(347, 215);
            this.txtNomeBazar.Name = "txtNomeBazar";
            this.txtNomeBazar.Size = new System.Drawing.Size(144, 20);
            this.txtNomeBazar.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 126);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtCodBazar
            // 
            this.txtCodBazar.Location = new System.Drawing.Point(347, 151);
            this.txtCodBazar.Name = "txtCodBazar";
            this.txtCodBazar.Size = new System.Drawing.Size(144, 20);
            this.txtCodBazar.TabIndex = 8;
            // 
            // txtDataVoluntario
            // 
            this.txtDataVoluntario.Location = new System.Drawing.Point(347, 183);
            this.txtDataVoluntario.Name = "txtDataVoluntario";
            this.txtDataVoluntario.Size = new System.Drawing.Size(144, 20);
            this.txtDataVoluntario.TabIndex = 7;
            // 
            // lbNomeBazar
            // 
            this.lbNomeBazar.AutoSize = true;
            this.lbNomeBazar.Location = new System.Drawing.Point(305, 218);
            this.lbNomeBazar.Name = "lbNomeBazar";
            this.lbNomeBazar.Size = new System.Drawing.Size(35, 13);
            this.lbNomeBazar.TabIndex = 5;
            this.lbNomeBazar.Text = "Nome";
            // 
            // lbCodBazar
            // 
            this.lbCodBazar.AutoSize = true;
            this.lbCodBazar.Location = new System.Drawing.Point(303, 154);
            this.lbCodBazar.Name = "lbCodBazar";
            this.lbCodBazar.Size = new System.Drawing.Size(40, 13);
            this.lbCodBazar.TabIndex = 3;
            this.lbCodBazar.Text = "Código";
            // 
            // lbDataBazar
            // 
            this.lbDataBazar.AutoSize = true;
            this.lbDataBazar.Location = new System.Drawing.Point(306, 186);
            this.lbDataBazar.Name = "lbDataBazar";
            this.lbDataBazar.Size = new System.Drawing.Size(30, 13);
            this.lbDataBazar.TabIndex = 2;
            this.lbDataBazar.Text = "Data";
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
            // btCriarBazar
            // 
            this.btCriarBazar.Location = new System.Drawing.Point(6, 251);
            this.btCriarBazar.Name = "btCriarBazar";
            this.btCriarBazar.Size = new System.Drawing.Size(95, 26);
            this.btCriarBazar.TabIndex = 0;
            this.btCriarBazar.Text = "Criar";
            this.btCriarBazar.UseVisualStyleBackColor = true;
            // 
            // MenuBazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.gBoxGestaoRecursos);
            this.Name = "MenuBazar";
            this.Text = "CaringCoPilot";
            this.gBoxGestaoRecursos.ResumeLayout(false);
            this.gBoxGestaoRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxGestaoRecursos;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txtNomeBazar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodBazar;
        private System.Windows.Forms.TextBox txtDataVoluntario;
        private System.Windows.Forms.Label lbNomeBazar;
        private System.Windows.Forms.Label lbCodBazar;
        private System.Windows.Forms.Label lbDataBazar;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Button btCriarBazar;
    }
}