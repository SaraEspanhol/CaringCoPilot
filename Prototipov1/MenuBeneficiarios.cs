using MySql.Data.MySqlClient;
using Prototipov1.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Prototipov1
{
    public partial class MenuBeneficiarios : Form
    {
        private dbs db;
        private CadastroBeneficiariosVO cruds;
        private Int32 catchRowIndex;

        public MenuBeneficiarios()
        {
            InitializeComponent();
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregaDadosBeneficiarios()
        {
            db = new dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = db.getConnectionString();
            string query = "SELECT * FROM beneficiarios";
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
                                dataTable.Rows[i]["pessoa_id"],
                                dataTable.Rows[i]["nome_beneficiario"],
                                dataTable.Rows[i]["data_nasc"],
                                dataTable.Rows[i]["rg"],
                                dataTable.Rows[i]["orgao_emissor"],
                                dataTable.Rows[i]["telefone"],
                                dataTable.Rows[i]["email"]);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } 
        }

        private void MenuBeneficiarios_Load(object sender, EventArgs e)
        {
            carregaDadosBeneficiarios();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cruds = new CadastroBeneficiariosVO();
                cruds.nome_beneficiario = txtNome.Text;
                cruds.data_nasc = txtDataNasc.Text;
                cruds.rg = txtRG.Text;
                cruds.orgao_emissor = txtOrgaoEmissor.Text;
                cruds.telefone = txtTelefone.Text;
                cruds.email = txtEmail.Text;


                cruds.InserirBeneficiarios();
                dataGridView1.Rows.Add(null, txtNome.Text, txtDataNasc.Text, txtRG.Text,
                    txtOrgaoEmissor.Text, txtTelefone.Text, txtEmail.Text);
                txtNome.Clear();
                txtDataNasc.Clear();
                txtRG.Clear();
                txtOrgaoEmissor.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                MessageBox.Show("Cadastro realizado com sucesso!");
                btRefresh_Click(this, new EventArgs());
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
            cruds = new CadastroBeneficiariosVO();
            try
            {
                cruds.pessoa_id = Convert.ToInt32(txtCod.Text);
                cruds.nome_beneficiario = txtNome.Text;
                cruds.data_nasc = txtDataNasc.Text;
                cruds.rg = txtRG.Text;
                cruds.orgao_emissor = txtOrgaoEmissor.Text;
                cruds.telefone = txtTelefone.Text;
                cruds.email = txtEmail.Text;
                cruds.AtualizarBeneficiarios();
                dataGridView1[0, catchRowIndex].Value = txtCod.Text;
                dataGridView1[1, catchRowIndex].Value = txtNome.Text;
                dataGridView1[2, catchRowIndex].Value = txtDataNasc.Text;
                dataGridView1[3, catchRowIndex].Value = txtRG.Text;
                dataGridView1[4, catchRowIndex].Value = txtOrgaoEmissor.Text;
                dataGridView1[5, catchRowIndex].Value = txtTelefone.Text;
                dataGridView1[6, catchRowIndex].Value = txtEmail.Text;
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtCod.Clear();
                txtNome.Clear();
                txtDataNasc.Clear();
                txtRG.Clear();
                txtOrgaoEmissor.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                btRefresh_Click(this, new EventArgs());

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
            cruds = new CadastroBeneficiariosVO();
            try
            {
                cruds.pessoa_id = Convert.ToInt32(txtCod.Text);
                cruds.nome_beneficiario = txtNome.Text;
                cruds.data_nasc = txtDataNasc.Text;
                cruds.rg = txtRG.Text;
                cruds.orgao_emissor = txtOrgaoEmissor.Text;
                cruds.telefone = txtTelefone.Text;
                cruds.email = txtEmail.Text;
                cruds.RemoverBeneficiarios();
                dataGridView1.Rows.RemoveAt(catchRowIndex);
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtCod.Clear();
                txtNome.Clear();
                txtDataNasc.Clear();
                txtRG.Clear();
                txtOrgaoEmissor.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                btRefresh_Click(this, new EventArgs());

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            catchRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtCod.Text = Convert.ToString(row.Cells[0].Value);
                txtNome.Text = row.Cells[1].Value.ToString();
                // Converte diretamente para DateTime e formata
                DateTime data = (DateTime)row.Cells[2].Value;
                txtDataNasc.Text = data.ToString("dd/MM/yyyy");
                txtRG.Text = row.Cells[3].Value.ToString();
                txtOrgaoEmissor.Text = row.Cells[4].Value.ToString();
                txtTelefone.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
            }
            btAtualizar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            carregaDadosBeneficiarios();
            this.Refresh();
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

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string numerosApenas = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());

            if (numerosApenas.Length > 0)
            {
                if (numerosApenas.Length <= 2)
                {
                    txtTelefone.Text = $"({numerosApenas}";
                }
                else if (numerosApenas.Length <= 6)
                {
                    txtTelefone.Text = $"({numerosApenas.Substring(0, 2)}) {numerosApenas.Substring(2)}";
                }
                else
                {
                    txtTelefone.Text = $"({numerosApenas.Substring(0, 2)}) {numerosApenas.Substring(2, 4)}-{numerosApenas.Substring(6)}";
                }
            }

            txtTelefone.SelectionStart = txtTelefone.Text.Length;
        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MenuBeneficiarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
