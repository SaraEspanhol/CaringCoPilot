using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace Prototipov1
{
    internal class ControleFinanceiro
    {
        private dbs db;
        private MySqlConnection con;

        public ControleFinanceiro()
        {

        }


        public void InserirDados(String data_mov, String descricao, Double valor, String doador,
                                   String descr_conta, String descr_ativo)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO mov_financeira(data_mov, descricao, valor, doador, conta_id, ativo_id) VALUES" +
                   " (?data_mov, ?descricao, ?valor, ?doador, (SELECT id FROM contas WHERE descr_conta = ?descr_conta)," +
                   " (SELECT idAtivos FROM ativos WHERE descr_ativo = ?descr_ativo))";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?doador", doador);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDados(String data_mov, String descricao, Double valor, String doador,
                                   String descr_conta, String descr_ativo)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE mov_financeira SET data_mov = ?data_mov, descricao = ?descricao, " +
                "valor = ?valor, doador = ?doador";
            query += " WHERE id = ?id" + "UPDATE contas SET tipo_conta = ?tipo_conta WHERE id = ?id" +
                "UPDATE ativos SET descr_ativo = ?descr_ativo WHERE idAtivos = ?idAtivos";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?doador", doador);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverDados(String data_mov, String descricao, Double valor, String doador,
                                   String descr_conta, String descr_ativo)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE mov_financeira SET data_mov = ?data_mov, descricao = ?descricao, " +
                "valor = ?valor, doador = ?doador";
            query += " WHERE id = ?id" + "DELETE contas SET tipo_conta = ?tipo_conta WHERE id = ?id" +
                "DELETE ativos SET descr_ativo = ?descr_ativo WHERE idAtivos = ?idAtivos";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?doador", doador);
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

