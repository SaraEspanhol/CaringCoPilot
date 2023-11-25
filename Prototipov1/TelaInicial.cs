using MySql.Data.MySqlClient;
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


        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            usuario = txtLogin.Text;
            senha = txtSenha.Text;
            TelaInicial telaInicial = new TelaInicial();
            if (telaInicial.VerificarCredenciais(usuario, senha))
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

        public bool VerificarCredenciais(string usuario, string senha)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();

            try
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM ong_responsavel WHERE usuario = @usuario AND senha = @senha";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha); // Lembre-se de usar hash para comparar senhas

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar credenciais: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
    }
}
