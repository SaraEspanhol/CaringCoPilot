using MySql.Data.MySqlClient;
using OfficeOpenXml;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipov1
{
    public partial class MenuGestaoRecursos : Form
    {
        private dbs db;
        private ControleFinanceiroVO cruds;
        private Int32 catchRowIndex;

        public MenuGestaoRecursos()
        {
            InitializeComponent();
            ComboBoxDoadores();
            ComboBoxConta();
            ComboBoxAtivo();
            comboBoxNomeDoador.Enabled = false;
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }



        private void PreencherComboBoxDoadores()
        {
            db = new dbs();
            string connectionString = db.getConnectionString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                try
                {
                    conn.Open();

                    string query = "SELECT nome FROM doadores";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            comboBoxNomeDoador.Items.Clear();


                            while (reader.Read())
                            {
                                comboBoxNomeDoador.Items.Add(reader["nome"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ComboBox Doadores: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void ComboBoxDoadores()
        {
            PreencherComboBoxDoadores();
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
            string query = "SELECT mov_financeira.id, mov_financeira.data_mov, mov_financeira.descricao," +
                            " mov_financeira.valor, mov_financeira.doador_id, mov_financeira.conta_id, " +
                            " mov_financeira.ativo_id, contas.descr_conta, ativos.descr_ativo, doadores.nome " +
                            " FROM mov_financeira " +
                            " JOIN contas ON mov_financeira.conta_id = contas.id " +
                            " JOIN ativos ON mov_financeira.ativo_id = ativos.idAtivos " +
                            " JOIN doadores ON mov_financeira.doador_id = doadores.id";
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
                                dataTable.Rows[i]["data_mov"],
                                dataTable.Rows[i]["descricao"],
                                dataTable.Rows[i]["conta_id"],
                                dataTable.Rows[i]["descr_conta"],
                                dataTable.Rows[i]["ativo_id"],
                                dataTable.Rows[i]["descr_ativo"],
                                dataTable.Rows[i]["valor"],
                                dataTable.Rows[i]["doador_id"],
                                dataTable.Rows[i]["nome"]
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
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cruds = new ControleFinanceiroVO();
                cruds.data_mov = txtDataCadastroEntrada.Text;
                cruds.descricao = txtDescricao.Text;
                cruds.descr_conta = cBoxContaCadastroEntrada.Text;
                cruds.descr_ativo = cBoxLocalCadastroEntrada.Text;
                cruds.valor = Convert.ToDouble(txtValor.Text);
                cruds.doador = comboBoxNomeDoador.Text;
                cruds.InserirFinanceiro();
                dataGridView1.Rows.Add(null, txtDataCadastroEntrada.Text, txtDescricao.Text, null, cBoxContaCadastroEntrada.Text, null,
                    cBoxLocalCadastroEntrada.Text, txtValor.Text, null, comboBoxNomeDoador.Text);
                txtId.Clear();
                txtDataCadastroEntrada.Clear();
                txtDescricao.Clear();
                cBoxContaCadastroEntrada.Items.Clear();
                cBoxLocalCadastroEntrada.Items.Clear();
                txtValor.Clear();
                comboBoxNomeDoador.Items.Clear();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            cruds = new ControleFinanceiroVO();
            try
            {

                cruds.data_mov = txtDataCadastroEntrada.Text;
                cruds.descricao = txtDescricao.Text;
                cruds.descr_conta = cBoxContaCadastroEntrada.Text;
                cruds.descr_ativo = cBoxLocalCadastroEntrada.Text;
                cruds.valor = Convert.ToDouble(txtValor.Text);
                cruds.doador = comboBoxNomeDoador.Text;
                cruds.AtualizarFinanceiro();
                dataGridView1[0, catchRowIndex].Value = txtId.Text;
                dataGridView1[1, catchRowIndex].Value = txtDataCadastroEntrada.Text;
                dataGridView1[2, catchRowIndex].Value = txtDescricao.Text;
                dataGridView1[3, catchRowIndex].Value = cBoxContaCadastroEntrada.Text;
                dataGridView1[4, catchRowIndex].Value = cBoxLocalCadastroEntrada.Text;
                dataGridView1[5, catchRowIndex].Value = txtValor.Text;
                dataGridView1[6, catchRowIndex].Value = comboBoxNomeDoador.Text;
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtId.Clear();
                txtDataCadastroEntrada.Clear();
                txtDescricao.Clear();
                cBoxContaCadastroEntrada.Items.Clear();
                cBoxLocalCadastroEntrada.Items.Clear();
                txtValor.Clear();
                comboBoxNomeDoador.Items.Clear();


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            cruds = new ControleFinanceiroVO();
            try
            {
                cruds.data_mov = txtDataCadastroEntrada.Text;
                cruds.descricao = txtDescricao.Text;
                cruds.descr_conta = cBoxContaCadastroEntrada.Text;
                cruds.descr_ativo = cBoxLocalCadastroEntrada.Text;
                cruds.valor = Convert.ToDouble(txtValor.Text);
                cruds.doador = comboBoxNomeDoador.Text;
                cruds.RemoverFinanceiro();
                dataGridView1.Rows.RemoveAt(catchRowIndex);
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtId.Clear();
                txtDataCadastroEntrada.Clear();
                txtDescricao.Clear();
                cBoxContaCadastroEntrada.Items.Clear();
                cBoxLocalCadastroEntrada.Items.Clear();
                txtValor.Clear();
                comboBoxNomeDoador.Items.Clear();

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
                txtDataCadastroEntrada.Text = row.Cells[1].Value.ToString();
                txtDescricao.Text = row.Cells[2].Value.ToString();
                txtIdConta.Text = Convert.ToString(row.Cells[3].Value);
                cBoxContaCadastroEntrada.Text = row.Cells[4].Value.ToString();
                txtIdAtivo.Text = Convert.ToString(row.Cells[5].Value);
                cBoxLocalCadastroEntrada.Text = row.Cells[6].Value.ToString();
                txtValor.Text = row.Cells[7].Value.ToString();
                txtIdDoador.Text = Convert.ToString(row.Cells[8].Value);
                comboBoxNomeDoador.Text = row.Cells[9].Value.ToString();


            }
            btAtualizar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            carregaDadosFinanceiro();
            this.Refresh();
        }

        private void checkDoacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDoacao.Checked)
            {
                comboBoxNomeDoador.Enabled = true;
            }
            else
            {
                comboBoxNomeDoador.Enabled = false;
            }
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            void ExportarParaExcel()
            {
                db = new dbs();
                

                string connectionString = db.getConnectionString();
                string query = "SELECT * FROM mov_financeira";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                dataAdapter.Fill(dataTable);

                                using (ExcelPackage excelPackage = new ExcelPackage())
                                {
                                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Dados");
                                    worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                                    excelPackage.SaveAs(new System.IO.FileInfo("C:\\Users\\jpesp\\Downloads\\relatorio"));
                                }
                            }
                        }
                    }

                    Console.WriteLine("Exportação concluída com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro durante a exportação: " + ex.Message);
                }
            }

            ExportarParaExcel();
        }

    }
}
