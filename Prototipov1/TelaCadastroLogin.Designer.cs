namespace Prototipov1
{
    partial class TelaCadastroLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroLogin));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupCadastro = new System.Windows.Forms.GroupBox();
            this.lbConfirmaSenha = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(139, 259);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(90, 30);
            this.btCadastrar.TabIndex = 11;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(139, 187);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(120, 25);
            this.txtSenha.TabIndex = 10;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(139, 156);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(120, 25);
            this.txtLogin.TabIndex = 9;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(95, 193);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 14);
            this.lbSenha.TabIndex = 8;
            this.lbSenha.Text = "Senha";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(95, 159);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(35, 14);
            this.lbLogin.TabIndex = 7;
            this.lbLogin.Text = "Login";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(18, 33);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(36, 14);
            this.lbNome.TabIndex = 15;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 25);
            this.txtNome.TabIndex = 16;
            // 
            // groupCadastro
            // 
            this.groupCadastro.Controls.Add(this.lbConfirmaSenha);
            this.groupCadastro.Controls.Add(this.txtSenha2);
            this.groupCadastro.Controls.Add(this.txtCPF);
            this.groupCadastro.Controls.Add(this.lbCPF);
            this.groupCadastro.Controls.Add(this.txtEmail);
            this.groupCadastro.Controls.Add(this.lbEmail);
            this.groupCadastro.Controls.Add(this.txtCelular);
            this.groupCadastro.Controls.Add(this.lbCelular);
            this.groupCadastro.Controls.Add(this.txtTelefone);
            this.groupCadastro.Controls.Add(this.lbTelefone);
            this.groupCadastro.Controls.Add(this.txtNome);
            this.groupCadastro.Controls.Add(this.lbNome);
            this.groupCadastro.Controls.Add(this.btCadastrar);
            this.groupCadastro.Controls.Add(this.txtSenha);
            this.groupCadastro.Controls.Add(this.txtLogin);
            this.groupCadastro.Controls.Add(this.lbSenha);
            this.groupCadastro.Controls.Add(this.lbLogin);
            this.groupCadastro.Location = new System.Drawing.Point(6, 1);
            this.groupCadastro.Name = "groupCadastro";
            this.groupCadastro.Size = new System.Drawing.Size(355, 295);
            this.groupCadastro.TabIndex = 17;
            this.groupCadastro.TabStop = false;
            this.groupCadastro.Text = "Cadastro";
            // 
            // lbConfirmaSenha
            // 
            this.lbConfirmaSenha.AutoSize = true;
            this.lbConfirmaSenha.Location = new System.Drawing.Point(38, 221);
            this.lbConfirmaSenha.Name = "lbConfirmaSenha";
            this.lbConfirmaSenha.Size = new System.Drawing.Size(95, 14);
            this.lbConfirmaSenha.TabIndex = 26;
            this.lbConfirmaSenha.Text = "Confirme a senha";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(139, 218);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(120, 25);
            this.txtSenha2.TabIndex = 25;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(59, 90);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(284, 25);
            this.txtCPF.TabIndex = 24;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(26, 96);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(29, 14);
            this.lbCPF.TabIndex = 23;
            this.lbCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 25);
            this.txtEmail.TabIndex = 22;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(18, 124);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 14);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "E-mail";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(223, 62);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(120, 25);
            this.txtCelular.TabIndex = 20;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(178, 66);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(43, 14);
            this.lbCelular.TabIndex = 19;
            this.lbCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(59, 62);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(113, 25);
            this.txtTelefone.TabIndex = 18;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(6, 66);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(50, 14);
            this.lbTelefone.TabIndex = 17;
            this.lbTelefone.Text = "Telefone";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TelaCadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 302);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupCadastro);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroLogin";
            this.Text = "CaringCoPilot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroLogin_FormClosing);
            this.Load += new System.EventHandler(this.CaringCoPilot_Load);
            this.groupCadastro.ResumeLayout(false);
            this.groupCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupCadastro;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbConfirmaSenha;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}