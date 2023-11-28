using MySql.Data.MySqlClient;
using Prototipov1.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipov1
{
    public partial class TelaInicial : Form
    {
        private dbs db;
        private MySqlConnection con;
        string usuario;
        string senha;

        public TelaInicial()
        {
            InitializeComponent();
            

        }
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
            bool check = CheckCadastro();
            if (check == true)
            {
                btCadastrar.Enabled = true;
            }
            else
            {
                btCadastrar.Enabled = false;
            }
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            usuario = txtLogin.Text;
            senha = txtSenha.Text;

            // Recuperar a senha e o salt do banco de dados usando o usuário
            string storedHashAndSalt = RecuperarHashAndSaltDoBancoDeDados(usuario);

            TelaInicial telaInicial = new TelaInicial();
            if (!string.IsNullOrEmpty(storedHashAndSalt) && telaInicial.VerificarCredenciais(usuario, senha, storedHashAndSalt))
            {
                MessageBox.Show("Credenciais válidas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                TelaPerfil telaPerfil = new TelaPerfil();
                telaPerfil.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Clear();
                txtSenha.Clear();
            }
        }

        public bool VerificarCredenciais(string usuario, string senha, string storedHashAndSalt)
        {
            // Verificar a senha usando o método VerifyPassword
            return HashandSalt.VerifyPassword(senha, storedHashAndSalt);

        }

        public string RecuperarHashAndSaltDoBancoDeDados(string usuario)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();

            try
            {
                con.Open();

                string query = "SELECT senha FROM ong_responsavel WHERE usuario = @usuario";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                string storedHashAndSalt = cmd.ExecuteScalar() as string;

                return storedHashAndSalt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar hash e salt do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        void btCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastroLogin cadastroLogin = new TelaCadastroLogin();
            cadastroLogin.ShowDialog();

        }



        void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                Application.Exit();
            
        }

        public bool CheckCadastro()
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();

            try
            {
                con.Open();

                string query = "SELECT usuario FROM ong_responsavel";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                string checkUsuario = cmd.ExecuteScalar() as string;

                if(checkUsuario == null)
                {
                    return true;
                }
                else
                {
                    return false;

                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao acessar o banco de dados:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
    }
}
