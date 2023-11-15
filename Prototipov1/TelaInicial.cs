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
        public TelaInicial()
        {
            InitializeComponent();
            
        }
        private void TelaInicial_Load(object sender, EventArgs e)
        {


        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }
            /*string nomeUsuario = txtLogin.Text;
            string senha = txtSenha.Text;

            if (EfetuarLogin(nomeUsuario, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos. Tente novamente.");
            }
            
        }
        private bool EfetuarLogin(string nomeUsuario, string senha)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM usuarios WHERE NomeUsuario = @NomeUsuario AND Senha = @Senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar login: " + ex.Message);
                return false;
            }
        }*/
        void btCadastrar_Click(object sender, EventArgs e)
        {
                this.Hide();
                TelaCadastroLogin cadastroLogin = new TelaCadastroLogin();
                cadastroLogin.ShowDialog();

        }

        void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
