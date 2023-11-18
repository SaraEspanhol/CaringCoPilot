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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Xceed.Document.NET;

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


      

        private void CaringCoPilot_Load(object sender, EventArgs e)
        {


        }

        

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();

            usuario = txtLogin.Text;
            senha = txtSenha.Text;
            senha2 = txtSenha2.Text;
            nome = txtNome.Text;
            email = txtEmail.Text;
            telefone = txtTelefone.Text;
            cpf = txtCPF.Text;
            celular = txtCelular.Text;

            /*if (senha == senha2)
            {
                
            }
            else
            {
                MessageBox.Show("Senha inválida! Digite a senha conforme o campo 'Senha'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Clear();
                txtSenha2.Clear();

            }*/ 

            try
            {
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
                TelaPerfil telaPerfil = new TelaPerfil();
                telaPerfil.ShowDialog();
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

        private void btLogin_Click(object sender, EventArgs e)
        {

        }

    }


   
        
}
