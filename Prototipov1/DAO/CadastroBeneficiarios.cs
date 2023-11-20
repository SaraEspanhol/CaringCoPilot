using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipov1.DAO
{
    internal class CadastroBeneficiarios
    {

        private dbs db;
        private MySqlConnection con;

            public CadastroBeneficiarios() 
            { 

            }

            public void InserirDadosBeneficiarios(String nome_beneficiario, String data_nasc, String rg, String orgao_emissor,
                String telefone, String email)
            {
                con = new MySqlConnection();
                db = new dbs();
                con.ConnectionString = db.getConnectionString();
                String query = "INSERT INTO beneficiarios (nome_beneficiario, data_nasc,  rg, orgao_emissor, telefone, email) VALUES";
                query += "(?nome_beneficiario, ?data_nasc, ?rg, ?orgao_emissor, ?telefone, ?email)";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome_beneficiario", nome_beneficiario);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?rg", rg);
                cmd.Parameters.AddWithValue("?orgao_emissor", orgao_emissor);
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
            public void AtualizarDadosBeneficiarios(Int32 pessoa_id, String nome_beneficiario, String data_nasc, String rg, String orgao_emissor,
                String telefone, String email)
            {
                con = new MySqlConnection();
                db = new dbs();
                con.ConnectionString = db.getConnectionString();
                String query = "UPDATE beneficiarios SET pessoa_id = ?pessoa_id, nome_beneficiario = ?nome_beneficiario, rg = ?rg, " +
                    "orgao_emissor = ?orgao_emissor, telefone = ?telefone, email = ?email, data_nasc =  ?data_nasc";
                query += " WHERE pessoa_id = ?pessoa_id";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?pessoa_id", pessoa_id);
                cmd.Parameters.AddWithValue("?nome_beneficiario", nome_beneficiario);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?rg", rg);
                cmd.Parameters.AddWithValue("?orgao_emissor", orgao_emissor);
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
            public void RemoverDadosBeneficiarios(Int32 pessoa_id, String nome_beneficiario, String data_nasc, String rg, String orgao_emissor,
                String telefone, String email)
        {
                con = new MySqlConnection();
                db = new dbs();
                con.ConnectionString = db.getConnectionString();
                String query = "DELETE FROM beneficiarios ";
                query += "WHERE pessoa_id = ?pessoa_id";
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?pessoa_id", pessoa_id);
                    cmd.Parameters.AddWithValue("?nome_beneficiario", nome_beneficiario);
                    cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                    cmd.Parameters.AddWithValue("?rg", rg);
                    cmd.Parameters.AddWithValue("?orgao_emissor", orgao_emissor);
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
