
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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


        public void InserirDados(Int32 ong_id, String data_mov, String descricao, Double valor, String nome,
                                   String descr_conta, String descr_ativo)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO mov_financeira(ong_id, data_mov, descricao, valor, doador_id, conta_id, ativo_id) VALUES" +
                   " (1, ?data_mov, ?descricao, ?valor, (SELECT id FROM doadores WHERE nome = ?nome), (SELECT id FROM contas WHERE descr_conta = ?descr_conta)," +
                   " (SELECT idAtivos FROM ativos WHERE descr_ativo = ?descr_ativo))";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?ong_id", ong_id);
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDados(Int32 id, Int32 ong_id, String data_mov, String descricao, Int32 conta_id, String descr_conta, Int32 ativo_id,
                                String descr_ativo, Double valor, Int32 doador_id, String nome)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE mov_financeira SET data_mov = ?data_mov, descricao = ?descricao, " +
                "valor = ?valor, ativo_id = (SELECT idAtivos FROM ativos WHERE descr_ativo = ?descr_ativo)," +
                "conta_id = (SELECT id FROM contas WHERE descr_conta = ?descr_conta)," +
                "doador_id = (SELECT id FROM doadores WHERE nome = ?nome) WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?ong_id", ong_id);
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?conta_id", conta_id);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.Parameters.AddWithValue("?ativo_id", ativo_id);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?doador_id", doador_id);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverDados(Int32 id, Int32 ong_id, String data_mov, String descricao, Int32 conta_id, String descr_conta, Int32 ativo_id,
                                String descr_ativo, Double valor, Int32 doador_id, String nome)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM mov_financeira WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.Parameters.AddWithValue("?ong_id", ong_id);
                cmd.Parameters.AddWithValue("?data_mov", data_mov);
                cmd.Parameters.AddWithValue("?descricao", descricao);
                cmd.Parameters.AddWithValue("?conta_id", conta_id);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.Parameters.AddWithValue("?ativo_id", ativo_id);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.Parameters.AddWithValue("?valor", valor);
                cmd.Parameters.AddWithValue("?doador_id", doador_id);
                cmd.Parameters.AddWithValue("?nome", nome);
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

