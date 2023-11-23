﻿using System;
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
            // Configurar o gráfico
            chart1.ChartAreas.Add(new ChartArea("Area 1"));
            chart1.Series.Add(new Series("MinhaSerie"));

            // Conectar ao banco de dados
            db = new dbs();
            string connectionString = db.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Recuperar dados do banco de dados
                string query = "SELECT conta_id, valor FROM mov_financeira";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Preencher o gráfico com os dados do banco de dados
                        while (reader.Read())
                        {
                            int conta_id = Convert.ToInt32(reader["conta_id"]);
                            int valor = Convert.ToInt32(reader["valor"]);

                            chart1.Series["MinhaSerie"].Points.AddXY(conta_id, valor);
                        }
                    }
                }
            }
        }

        private void btEditarPerfil_Click(object sender, EventArgs e)
        {
            MenuEditarPerfil menuEditarPerfil = new MenuEditarPerfil();
            menuEditarPerfil.ShowDialog();
        }



    }        
    
}
