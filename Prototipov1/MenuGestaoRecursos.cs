﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Prototipov1
{
    public partial class MenuGestaoRecursos : Form
    {
        private MySqlConnection con;
        private dbs db;
        private ControleFinanceiroVO cruds;
        private Int32 catchRowIndex;

        public MenuGestaoRecursos()
        {
            InitializeComponent();
            ComboBoxConta();
            ComboBoxAtivo();
            

        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherComboBoxConta()
        {
            db = new dbs();
            string connectionString = db.getConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                try
                {
                    conn.Open();

                    string query = "SELECT descr_conta FROM contas";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            cBoxContaCadastroEntrada.Items.Clear();


                            while (reader.Read())
                            {
                                cBoxContaCadastroEntrada.Items.Add(reader["descr_conta"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox Conta: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void ComboBoxConta()
        {
            PreencherComboBoxConta();
        }

        private void PreencherComboBoxAtivo()
        {
            db = new dbs();
            string connectionString = db.getConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                try
                {
                    conn.Open();

                    string query = "SELECT descr_ativo FROM ativos";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            cBoxLocalCadastroEntrada.Items.Clear();


                            while (reader.Read())
                            {
                                cBoxLocalCadastroEntrada.Items.Add(reader["descr_ativo"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox Ativo: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void ComboBoxAtivo()
        {
            PreencherComboBoxAtivo();
        }

        private void carregaDadosFinanceiro()
        {
            db = new dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = db.getConnectionString();
            string query = "SELECT mov_financeira.id, mov_financeira.ong_id, mov_financeira.data_mov, mov_financeira.descricao," +
                            " mov_financeira.valor, mov_financeira.conta_id, " +
                            " mov_financeira.ativo_id, contas.descr_conta, ativos.descr_ativo, contas.tipo_conta" +
                            " FROM mov_financeira " +
                            " JOIN ong ON mov_financeira.ong_id = ong.id " +
                            " JOIN contas ON mov_financeira.conta_id = contas.id " +
                            " JOIN ativos ON mov_financeira.ativo_id = ativos.idAtivos ";
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
                                dataTable.Rows[i]["ong_id"],
                                dataTable.Rows[i]["data_mov"],
                                dataTable.Rows[i]["descricao"],
                                dataTable.Rows[i]["conta_id"],
                                dataTable.Rows[i]["tipo_conta"],
                                dataTable.Rows[i]["descr_conta"],
                                dataTable.Rows[i]["ativo_id"],
                                dataTable.Rows[i]["descr_ativo"],
                                dataTable.Rows[i]["valor"]
                            );
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }

        private void MenuGestaoRecursos_Load(object sender, EventArgs e)
        {
            carregaDadosFinanceiro();
            ComboBoxConta();
            ComboBoxAtivo();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cruds = new ControleFinanceiroVO();
                cruds.data_mov = txtDataCadastroEntrada.Text;
                cruds.descricao = txtDescricao.Text;
                cruds.tipo_conta = txtTipoConta.Text;
                cruds.descr_conta = cBoxContaCadastroEntrada.Text;
                cruds.descr_ativo = cBoxLocalCadastroEntrada.Text;
                cruds.valor = Convert.ToDouble(txtValor.Text);
                cruds.InserirFinanceiro();
                dataGridView1.Rows.Add(null, null, txtDataCadastroEntrada.Text, txtDescricao.Text, null, cBoxContaCadastroEntrada.Text, null,
                    cBoxLocalCadastroEntrada.Text, txtValor.Text);
                txtId.Clear();
                txtDataCadastroEntrada.Clear();
                txtDescricao.Clear();
                cBoxContaCadastroEntrada.Items.Clear();
                cBoxLocalCadastroEntrada.Items.Clear();
                txtValor.Clear();
                MessageBox.Show("Cadastro realizado com sucesso!");
                btRefresh_Click(this, new EventArgs());
                ComboBoxConta();
                ComboBoxAtivo();
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message, "Erro!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                cruds = new ControleFinanceiroVO();
                cruds.id = Convert.ToInt32(txtId.Text);
                cruds.data_mov = txtDataCadastroEntrada.Text;
                cruds.descricao = txtDescricao.Text;
                cruds.tipo_conta = txtTipoConta.Text;
                cruds.conta_id = Convert.ToInt32(txtIdConta.Text);
                cruds.descr_conta = cBoxContaCadastroEntrada.Text;
                cruds.ativo_id = Convert.ToInt32(txtIdAtivo.Text);
                cruds.descr_ativo = cBoxLocalCadastroEntrada.Text;
                cruds.valor = Convert.ToDouble(txtValor.Text);
                cruds.AtualizarFinanceiro();
                dataGridView1[0, catchRowIndex].Value = txtId.Text;
                dataGridView1[1, catchRowIndex].Value = txtOngId.Text;
                dataGridView1[2, catchRowIndex].Value = txtDataCadastroEntrada.Text;
                dataGridView1[3, catchRowIndex].Value = txtDescricao.Text;
                dataGridView1[4, catchRowIndex].Value = txtIdConta.Text;
                dataGridView1[5, catchRowIndex].Value = txtTipoConta.Text;
                dataGridView1[6, catchRowIndex].Value = cBoxContaCadastroEntrada.Text;
                dataGridView1[7, catchRowIndex].Value = txtIdAtivo.Text;
                dataGridView1[8, catchRowIndex].Value = cBoxLocalCadastroEntrada.Text;
                dataGridView1[9, catchRowIndex].Value = txtValor.Text;
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtId.Clear();
                txtOngId.Clear();
                txtDataCadastroEntrada.Clear();
                txtDescricao.Clear();
                txtIdConta.Clear();
                txtTipoConta.Clear();
                cBoxContaCadastroEntrada.Items.Clear();
                txtIdAtivo.Clear();
                cBoxLocalCadastroEntrada.Items.Clear();
                txtValor.Clear();
                MessageBox.Show("Atualização realizada com sucesso!");
                btRefresh_Click(this, new EventArgs());
                ComboBoxConta();
                ComboBoxAtivo();

            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message, "Erro!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                cruds = new ControleFinanceiroVO();
                cruds.id = Convert.ToInt32(txtId.Text);
                cruds.data_mov = txtDataCadastroEntrada.Text;
                cruds.descricao = txtDescricao.Text;
                cruds.conta_id = Convert.ToInt32(txtIdConta.Text);
                cruds.descr_conta = cBoxContaCadastroEntrada.Text;
                cruds.ativo_id = Convert.ToInt32(txtIdAtivo.Text);
                cruds.descr_ativo = cBoxLocalCadastroEntrada.Text;
                cruds.valor = Convert.ToDouble(txtValor.Text);
                cruds.RemoverFinanceiro();
                dataGridView1.Rows.RemoveAt(catchRowIndex);
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtId.Clear();
                txtOngId.Clear();
                txtDataCadastroEntrada.Clear();
                txtDescricao.Clear();
                txtIdConta.Clear();
                txtTipoConta.Clear();
                cBoxContaCadastroEntrada.Items.Clear();
                txtIdAtivo.Clear();
                cBoxLocalCadastroEntrada.Items.Clear();
                txtValor.Clear();
                MessageBox.Show("Atualização realizada com sucesso!");
                btRefresh_Click(this, new EventArgs());
                ComboBoxConta();
                ComboBoxAtivo();
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
                txtId.Text = Convert.ToString(row.Cells[0].Value);
                txtOngId.Text = row.Cells[1].Value.ToString();

                // Converte diretamente para DateTime e formata
                DateTime data = (DateTime)row.Cells[2].Value;
                txtDataCadastroEntrada.Text = data.ToString("dd/MM/yyyy");
                txtDescricao.Text = row.Cells[3].Value.ToString();
                txtIdConta.Text = Convert.ToString(row.Cells[4].Value);
                txtTipoConta.Text = row.Cells[5].Value.ToString();
                cBoxContaCadastroEntrada.Text = row.Cells[6].Value.ToString();
                txtIdAtivo.Text = Convert.ToString(row.Cells[7].Value);
                cBoxLocalCadastroEntrada.Text = row.Cells[8].Value.ToString();
                txtValor.Text = row.Cells[9].Value.ToString();
            }
            btAtualizar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            carregaDadosFinanceiro();
            txtId.Clear();
            txtOngId.Clear();
            txtDataCadastroEntrada.Clear();
            txtDescricao.Clear();
            txtIdConta.Clear();
            txtTipoConta.Clear();
            cBoxContaCadastroEntrada.Items.Clear();
            txtIdAtivo.Clear();
            cBoxLocalCadastroEntrada.Items.Clear();
            txtValor.Clear();
            ComboBoxConta();
            ComboBoxAtivo();

        }

        private void checkDoacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            void ExportarParaExcel(DataGridView dataGridView1)
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Não há dados para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                // Adiciona cabeçalhos ao Excel a partir das colunas do DataGridView
                for (int col = 1; col <= dataGridView1.Columns.Count; col++)
                {
                    worksheet.Cells[1, col] = dataGridView1.Columns[col - 1].HeaderText;
                }

                // Adiciona os dados ao Excel
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1] = dataGridView1.Rows[row].Cells[col].Value;
                    }
                }

                // Salva o arquivo e limpa os recursos
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Arquivo Excel (*.xlsx)|*.xlsx|Todos os Arquivos (*.*)|*.*",
                    FileName = "dados_excel"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);

                    MessageBox.Show("Dados exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    workbook.Close(false);
                    excelApp.Quit();

                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);
                }
            }
            ExportarParaExcel(dataGridView1);
        }

        private void cBoxContaCadastroEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdentificaTipoConta(cBoxContaCadastroEntrada.Text);
        }

        public void IdentificaTipoConta(String descr_conta)
        {
            db = new dbs();
            string connectionString = db.getConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT tipo_conta FROM contas WHERE descr_conta = ?descr_conta";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?descr_conta", descr_conta);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtTipoConta.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Tipo de conta não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher TextBox Tipo Conta: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void MenuGestaoRecursos_FormClosing(object sender, FormClosingEventArgs e)
        {
  
               

        }
    }
}
