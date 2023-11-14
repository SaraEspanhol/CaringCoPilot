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

namespace Prototipov1
{
    public partial class TelaCadastroLogin : Form
    {
       
        
        
        private const string connectionString = "server=127.0.0.1:3306;User Id=root;password='@We071120';database=sakila";
        

       
        
  
        
        
        public TelaCadastroLogin()
        {
            InitializeComponent();
            
        }

       

        private void CaringCoPilot_Load(object sender, EventArgs e)
        {


        }    


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtLogin.Text;
            string senha = txtSenha.Text;

            if (CadastrarUsuario(nomeUsuario, senha))
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário. Verifique os dados e tente novamente.");
            }
            this.Hide();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
        }

        private bool CadastrarUsuario(string nomeUsuario, string senha)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO usuarios (NomeUsuario, Senha) VALUES (@NomeUsuario, @Senha)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                return false;
            }
        }
        void btLogin_Click(object sender, EventArgs e)
        {
                this.Hide();
                TelaInicial telaInicial = new TelaInicial();
                telaInicial.ShowDialog();
        }
        
    }
}
