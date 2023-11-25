using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Prototipov1
{
    public partial class TelaPerfil : Form
    {
        private dbs db;

        public TelaPerfil()
        {
            InitializeComponent();

        }

        private void cadastrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuGestaoRecursos menuGestaoRecursos = new MenuGestaoRecursos();
            menuGestaoRecursos.ShowDialog();
        }

        private void reembolsoDeDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuReembolso menuReembolso = new MenuReembolso();
            menuReembolso.ShowDialog();
        }

        private void planoDeContasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuPlanoDeContasCadastrar menuPlanoDeContas = new MenuPlanoDeContasCadastrar();
            menuPlanoDeContas.ShowDialog();
        }

        private void gerarReciboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuReciboDoacao menuReciboDoacao = new MenuReciboDoacao();
            menuReciboDoacao.ShowDialog();
        }

        private void cadastrarVoluntárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVoluntáriosAtividades menuVoluntários = new MenuVoluntáriosAtividades();
            menuVoluntários.ShowDialog();
        }

        private void cadastrarDoaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEntrada menuEntrada = new MenuEntrada();
            menuEntrada.ShowDialog();
        }



        private void lançarDoaçõesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuSaidaDoacoes menuSaidaDoacoes = new MenuSaidaDoacoes();
            menuSaidaDoacoes.ShowDialog();
        }

        private void cadastrarBazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBazar menuBazar = new MenuBazar();
            menuBazar.ShowDialog();

        }

        private void lançarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuSaidaBazar menuSaidaBazar = new MenuSaidaBazar();
            menuSaidaBazar.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuDoadores menuDoadores = new MenuDoadores();
            menuDoadores.ShowDialog();
        }

        private void controleFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuGestaoRecursos menuGestaoRecursos = new MenuGestaoRecursos();
            menuGestaoRecursos.ShowDialog();
        }

        private void cadastroDoadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuDoadores menuDoadores = new MenuDoadores();
            menuDoadores.ShowDialog();
        }

        private void cadastroDoadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuDoadores menuDoadores = new MenuDoadores();
            menuDoadores.ShowDialog();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEntradaDoacoes menuEntradaDoacoes = new MenuEntradaDoacoes();
            menuEntradaDoacoes.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEntrada menuEntrada = new MenuEntrada();
            menuEntrada.ShowDialog();
        }

        private void doaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuSaidaDoacoes menuSaidaDoacoes = new MenuSaidaDoacoes();
            menuSaidaDoacoes.ShowDialog();
        }

        private void bazarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuSaidaBazar menuSaidaBazar = new MenuSaidaBazar();
            menuSaidaBazar.ShowDialog();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEstoque menuEstoque = new MenuEstoque();
            menuEstoque.ShowDialog();
        }

        private void gerarRebiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuReciboDoacao menuReciboDoacao = new MenuReciboDoacao();
            menuReciboDoacao.ShowDialog();
        }

        private void controleFinanceiroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuGestaoRecursos menuGestaoRecursos = new MenuGestaoRecursos();
            menuGestaoRecursos.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVoluntarioCadastro menuVoluntarioCadastro = new MenuVoluntarioCadastro();
            menuVoluntarioCadastro.ShowDialog();
        }

        private void atualizaçãoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVoluntáriosAtividades menuVoluntáriosAtualizarCadastro = new MenuVoluntáriosAtividades();
            menuVoluntáriosAtualizarCadastro.ShowDialog();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVoluntarioRelatorio menuVoluntarioRelatorio = new MenuVoluntarioRelatorio();
            menuVoluntarioRelatorio.ShowDialog();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuBeneficiarios menuBeneficiarios = new MenuBeneficiarios();
            menuBeneficiarios.ShowDialog();
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            carregaDadosFinanceiro();
            PreencherGrafico();
        }

        private void btEditarPerfil_Click(object sender, EventArgs e)
        {
            MenuEditarPerfil menuEditarPerfil = new MenuEditarPerfil();
            menuEditarPerfil.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            MenuGestaoRecursos menuGestaoRecursos = new MenuGestaoRecursos();  
            menuGestaoRecursos.ShowDialog();
        }
        private void PreencherGrafico()
        {
            // Limpar dados existentes no gráfico
            Chart1.Series.Clear();

            // Adicionar uma série ao gráfico
            Series serie = new Series("Entradas");
            serie.ChartType = SeriesChartType.Column; // Ou outro tipo de gráfico desejado

            // Preencher dados da série com dados do DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Certifique-se de que a célula não está vazia
                if (row.Cells[0].Value != null && row.Cells[2].Value != null)
                {
                    // Adicionar ponto de dados à série
                    string xValue = row.Cells[2].Value.ToString();
                    string yValue = row.Cells[0].Value.ToString();
                    serie.Points.AddXY(xValue, yValue);
                }
            }

            // Adicionar a série ao gráfico
            Chart1.Series.Add(serie);

            // Personalizar o gráfico conforme necessário
            Chart1.ChartAreas[0].AxisX.Title = "Valores";
            Chart1.ChartAreas[0].AxisY.Title = "Data";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carregaDadosFinanceiro()
        {
            db = new dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = db.getConnectionString();
            string query = "SELECT mf.data_mov, mf.descricao, mf.valor, SUM(mf.valor) OVER(ORDER BY mf.data_mov) AS saldo_acumulado " +
                "FROM mov_financeira mf WHERE mf.ong_id = 1";
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
                                dataTable.Rows[i]["data_mov"],
                                dataTable.Rows[i]["descricao"],
                                dataTable.Rows[i]["valor"],
                                dataTable.Rows[i]["saldo_acumulado"]
                                
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
    }        
    
}
