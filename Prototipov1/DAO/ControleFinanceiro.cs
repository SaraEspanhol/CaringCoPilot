using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipov1
{
    internal class ControleFinanceiro
    {
        private dbs db;
        private MySqlConnection con;

        public ControleFinanceiro()
        {

        }


        public void InserirDados( string data_mov, string descricao, string nome_conta, string nome_ativo, double valor, string nome_doador)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO mov_financeira (data_mov, descricao, nome_conta, nome_ativo, valor, nome_doador) VALUES";
            query += "(?data_mov, ?descricao, ?nome_conta, ?nome_ativo, ?valor, ?nome_doador)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?nome_conta", nome_conta);
                cmd.Parameters.AddWithValue("?nome_ativo", nome_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?nome_doador", nome_doador);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDados(string data_mov, string descricao, string nome_conta, string nome_ativo, double valor, string nome_doador)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE mov_financeira SET data_mov = ?data_mov, descricao = ?descricao, nome_conta = ?nome_conta, nome_ativo = ?nome_ativo, valor = ?valor, nome_doador = ?nome_doador";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?nome_conta", nome_conta);
                cmd.Parameters.AddWithValue("?nome_ativo", nome_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?nome_doador", nome_doador);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverDados(string data_mov, string descricao, string nome_conta, string nome_ativo, double valor, string nome_doador)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM mov_financeira data_mov = ?data_mov, descricao = ?descricao, nome_conta = ?nome_conta, nome_ativo = ?nome_ativo, valor = ?valor, nome_doador = ?nome_doador\"";
            query += "WHERE ong_id = ?ong_id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?nome_conta", nome_conta);
                cmd.Parameters.AddWithValue("?nome_ativo", nome_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?nome_doador", nome_doador);
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

