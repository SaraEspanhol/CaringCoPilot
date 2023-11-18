using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipov1
{
    class PlanoDeContas
    {
        private dbs db;
        private MySqlConnection con;

        public PlanoDeContas()
        {

        }

        // CONTAS //
        public void InserirDados(string tipo_conta, string descr_conta)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO contas (tipo_conta, descr_conta) VALUES";
            query += "(?tipo_conta, ?descr_conta)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo_conta", tipo_conta);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDados(string tipo_conta, string descr_conta, int id)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE contas SET tipo_conta = ?tipo_conta, descr_conta = ?descr_conta";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo_conta", tipo_conta);
                cmd.Parameters.AddWithValue("?descr_conta", descr_conta);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverDados(string tipo_conta, int id)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM contas ";
            query += "WHERE tipo_conta = ?tipo_conta AND id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?tipo_conta", tipo_conta);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        //ATIVOS
        public void InserirDadosAtivos(string descr_ativo)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO ativos (descr_ativo) VALUES";
            query += "(?descr_ativo)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDadosAtivos(int idAtivos, string descr_ativo)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE ativos SET descr_ativo = ?descr_ativo";
            query += " WHERE idAtivos = ?idAtivos";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?idAtivos", idAtivos);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoverDadosAtivos(int idAtivos, string descr_ativo)
        {
            con = new MySqlConnection();
            db = new dbs();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM ativos ";
            query += "WHERE descr_ativo = ?descr_ativo AND idAtivos = ?idAtivos";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?idAtivos", idAtivos);
                cmd.Parameters.AddWithValue("?descr_ativo", descr_ativo);
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


