using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Prototipov1.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Prototipov1
{

    public partial class TelaCadastroLogin : Form
    {
        string usuario;
        string senha;
        string senha2;
        string nome;
        string email;
        string telefone;
        string cpf;
        string celular;

        private dbs db;
        private MySqlConnection con;


        public TelaCadastroLogin()
        {
            InitializeComponent();
            
        }

        private void CaringCoPilot_Load(object sender, EventArgs e) { }
        

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
                

            try
            {
                usuario = txtLogin.Text;
                senha = txtSenha.Text;
                senha2 = txtSenha2.Text;
                nome = txtNome.Text;
                email = validaEmail(txtEmail.Text);
                telefone = validaTelefone(txtTelefone.Text);
                cpf = txtCPF.Text;
                celular = validaTelefone(txtCelular.Text);
                string salt;

                senha = HashandSalt.HashPassword(senha, senha2, out salt);
                
                con.Open();

                string query = "INSERT INTO ong_responsavel (nome, email, telefone, cpf, celular, usuario, senha) " +
                               "VALUES  (@nome, @email, @telefone, @cpf, @celular, @usuario, @senha)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                TelaInicial telaInicial = new TelaInicial();
                telaInicial.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private string validaEmail(string email)
        {
            if (Validacoes.IsValidEmail(email))
            {
                return email;
            }
            else
            {
                string textoErro = String.Format("Insira um e-mail válido!");
                throw new ArgumentException(textoErro);
            }
        }

        private string validaTelefone(string telefone)
        {
            if (Validacoes.IsValidTelefone(telefone))
            {
                return telefone;
            }
            else
            {
                string textoErro = String.Format("Insira um telefone válido!");
                throw new ArgumentException(textoErro);
            }
        }

        private void btLogin_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string numerosApenas = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());

            if (numerosApenas.Length > 0)
            {
                if (numerosApenas.Length <= 2)
                {
                    txtTelefone.Text = $"({numerosApenas}";
                }
                else if (numerosApenas.Length <= 6)
                {
                    txtTelefone.Text = $"({numerosApenas.Substring(0, 2)}) {numerosApenas.Substring(2)}";
                }
                else
                {
                    txtTelefone.Text = $"({numerosApenas.Substring(0, 2)}) {numerosApenas.Substring(2, 4)}-{numerosApenas.Substring(6)}";
                }
            }

            txtTelefone.SelectionStart = txtTelefone.Text.Length;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            string numerosApenas = new string(txtCelular.Text.Where(char.IsDigit).ToArray());

            if (numerosApenas.Length > 0)
            {
                if (numerosApenas.Length <= 2)
                {
                    txtCelular.Text = $"({numerosApenas}";
                }
                else if (numerosApenas.Length <= 6)
                {
                    txtCelular.Text = $"({numerosApenas.Substring(0, 2)}) {numerosApenas.Substring(2)}";
                }
                else
                {
                    txtCelular.Text = $"({numerosApenas.Substring(0, 2)}) {numerosApenas.Substring(2, 4)}-{numerosApenas.Substring(6)}";
                }
            }
            txtCelular.SelectionStart = txtCelular.Text.Length;
        }
    }
}
