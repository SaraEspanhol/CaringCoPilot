using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipov1.DAO
{
    internal class CadastroDoadores
    {
        private dbs db;
        private MySqlConnection con;

        public CadastroDoadores()
        {

        }

        public void InserirDadosDoadores(String tipo_doador, String documento, String nome,
            String data_nasc, String telefone, String email)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO doadores (tipo_doador, documento, nome, data_nasc, telefone, email) VALUES";
            query += "(?tipo_doador, ?documento, ?nome, ?data_nasc, ?telefone, ?email)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo_doador", tipo_doador);
                cmd.Parameters.AddWithValue("?documento", documento);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDadosDoadores(String tipo_doador, String documento, String nome,
            String data_nasc, String telefone, String email)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE doadores SET tipo_doador = ?tipo_doador, documento = ?documento, " +
                "nome = ?nome, data_nasc = ?data_nasc, telefone = ?telefone, email =  ?email";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo_doador", tipo_doador);
                cmd.Parameters.AddWithValue("?documento", documento);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverDadosDoadores(String tipo_doador, String documento, String nome,
            String data_nasc, String telefone, String email)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM doadores ";
            query += "WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo_doador", tipo_doador);
                cmd.Parameters.AddWithValue("?documento", documento);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
