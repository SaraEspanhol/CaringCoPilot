﻿using MySql.Data.MySqlClient;
using Prototipov1.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipov1
{
    public partial class MenuDoadores : Form
    {
        private dbs db;
        private CadastroDoadoresVO cruds;
        private Int32 catchRowIndex;

        public MenuDoadores()
        {
            InitializeComponent();
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }

        private void carregaDadosDoadores()
        {
            db = new dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = db.getConnectionString();
            string query = "SELECT * FROM doadores";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(
                                dataTable.Rows[i]["id"],
                                dataTable.Rows[i]["tipo_doador"],
                                dataTable.Rows[i]["documento"],
                                dataTable.Rows[i]["nome"],
                                dataTable.Rows[i]["data_nasc"],
                                dataTable.Rows[i]["email"],
                                dataTable.Rows[i]["telefone"]); ;
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }

        private void MenuDoadores_Load(object sender, EventArgs e)
        {
            carregaDadosDoadores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cruds = new CadastroDoadoresVO();
                cruds.tipo_doador = cBoxPFPJ.Text;
                cruds.documento = txtDocDoador.Text;
                cruds.nome = txtNomeDoador.Text;
                cruds.data_nasc = txtDataNasc.Text;
                cruds.email = txtEmail.Text;
                cruds.telefone = txtTelefone.Text;
                cruds.InserirDoadores();
                dataGridView1.Rows.Add(null, cBoxPFPJ.Text, txtDocDoador.Text, txtNomeDoador.Text,
                    txtDataNasc.Text, txtEmail.Text, txtTelefone.Text);
                cBoxPFPJ.Items.Clear();
                txtDocDoador.Clear();
                txtNomeDoador.Clear();
                txtDataNasc.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            cruds = new CadastroDoadoresVO();
            try
            {
                cruds.id = Convert.ToInt32(txtCodDoador.Text);
                cruds.tipo_doador = cBoxPFPJ.Text;
                cruds.documento = txtDocDoador.Text;
                cruds.nome = txtNomeDoador.Text;
                cruds.data_nasc = txtDataNasc.Text;
                cruds.email = txtEmail.Text;
                cruds.telefone = txtTelefone.Text;
                cruds.AtualizarDoadores();
                dataGridView1[0, catchRowIndex].Value = txtCodDoador.Text;
                dataGridView1[1, catchRowIndex].Value = cBoxPFPJ.Text;
                dataGridView1[2, catchRowIndex].Value = txtDocDoador.Text;
                dataGridView1[3, catchRowIndex].Value = txtNomeDoador.Text;
                dataGridView1[4, catchRowIndex].Value = txtDataNasc.Text;
                dataGridView1[5, catchRowIndex].Value = txtEmail.Text;
                dataGridView1[6, catchRowIndex].Value = txtTelefone.Text;
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtCodDoador.Clear();
                cBoxPFPJ.Items.Clear();
                txtDocDoador.Clear();
                txtNomeDoador.Clear();
                txtDataNasc.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            cruds = new CadastroDoadoresVO();
            try
            {
                cruds.id = Convert.ToInt32(txtCodDoador.Text);
                cruds.tipo_doador = cBoxPFPJ.Text;
                cruds.documento = txtDocDoador.Text;
                cruds.nome = txtNomeDoador.Text;
                cruds.data_nasc = txtDataNasc.Text;
                cruds.email = txtEmail.Text;
                cruds.telefone = txtTelefone.Text;
                cruds.RemoverDoadores();
                dataGridView1.Rows.RemoveAt(catchRowIndex);
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtCodDoador.Clear();
                cBoxPFPJ.Items.Clear();
                txtDocDoador.Clear();
                txtNomeDoador.Clear();
                txtDataNasc.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtCodDoador.Text = Convert.ToString(row.Cells[0].Value);
                cBoxPFPJ.Text = row.Cells[1].Value.ToString();
                txtDocDoador.Text = row.Cells[2].Value.ToString();
                txtNomeDoador.Text = row.Cells[3].Value.ToString();
                txtDataNasc.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtTelefone.Text = row.Cells[6].Value.ToString();
                
            }
            btAtualizar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            carregaDadosDoadores();
            this.Refresh();
        }
    }
}
