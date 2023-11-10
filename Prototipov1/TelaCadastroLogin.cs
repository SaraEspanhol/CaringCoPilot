using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipov1
{
    public partial class CaringCoPilot : Form
    {
        public CaringCoPilot()
        {
            InitializeComponent();
        }

       
        private void CaringCoPilot_Load(object sender, EventArgs e)
        {


        }    


        public void CadastrarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string nomeUsuario, senha, codAdm;

            nomeUsuario = txtLogin.Text;
                
           // Verifica se o nome de usuário já está em uso
             if (usuarios.Exists(u => u.NomeUsuario == nomeUsuario))
              {
                  MessageBox.Show("Este nome de usuário já está em uso. Escolha outro.");
                  return;
              }

            senha = txtSenha.Text;

            if (VerificarSenha(senha) == true)
            {
                
            }
            else
            {
                MessageBox.Show("Senha inválida! A senha deve conter pelo menos um número, um caracter especial, uma letra maiúscula e 8 caracteres.");
            }

            codAdm = txtCodAdm.Text;

            if (codAdm == "123456")
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Código do Administrador Incorreto! Favor fornecer o código correto para criação do login");
            }

           // Adiciona o usuário à lista
             usuarios.Add(new Usuario { NomeUsuario = nomeUsuario, Senha = senha });

        }

        static bool VerificarSenha(string senha)
        {
            // Verifica se a senha tem pelo menos uma letra maiúscula
            if (!senha.Any(char.IsUpper))
            {

                return false;
            }

            // Verifica se a senha tem pelo menos um caractere especial
            if (!senha.Any(c => char.IsPunctuation(c) || char.IsSymbol(c)))
            {

                return false;
            }

            // Verifica se a senha tem pelo menos um número
            if (!senha.Any(char.IsDigit))
            {

                return false;
            }

            // Verifica se a senha tem pelo menos oito caracteres (ou outro comprimento desejado)
            if (senha.Length < 8)
            {

                return false;
            }

            return true;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }
    }
}
