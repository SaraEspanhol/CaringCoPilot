using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipov1
{
    public partial class MenuPlanoDeContasCadastrar : Form
    {
        private dbs db;
        private PlanoDeContasVO cruds;
        private Int32 catchRowIndex;
        public MenuPlanoDeContasCadastrar()
        {
            InitializeComponent();
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }

        private void carregaDados()
        {
            db = new dbs();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = db.getConnectionString();
            string query = "SELECT * FROM contas";
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
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2]);
                        }
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            } // end using
        }

        private void MenuPlanoDeContasCadastrar_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cruds = new PlanoDeContasVO();
                cruds.descr_conta = txtNome.Text;
                cruds.tipo_conta = comboBoxTipo.Text;
                cruds.Inserir();
                dataGridView1.Rows.Add(null, comboBoxTipo.Text, txtNome.Text);
                txtNome.Clear();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            
            cruds = new PlanoDeContasVO();
            try
            {
                
                cruds.tipo_conta = comboBoxTipo.Text;
                cruds.descr_conta = txtNome.Text;
                cruds.id = Convert.ToInt32(txtId.Text);
                cruds.Atualizar();
                dataGridView1[0, catchRowIndex].Value = txtId.Text;
                dataGridView1[1, catchRowIndex].Value = comboBoxTipo.Text;
                dataGridView1[2, catchRowIndex].Value = txtNome.Text;
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtId.Clear();
                txtNome.Clear();
                comboBoxTipo.Items.Clear();


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            cruds = new PlanoDeContasVO();
            try
            {
                cruds.tipo_conta = comboBoxTipo.Text;
                cruds.descr_conta = txtNome.Text;
                cruds.id = Convert.ToInt32(txtId.Text);
                cruds.Remover();
                dataGridView1.Rows.RemoveAt(catchRowIndex);
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
                txtId.Clear();
                txtNome.Clear();
                comboBoxTipo.Items.Clear();

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
                comboBoxTipo.Text = row.Cells[1].Value.ToString();
                txtNome.Text = row.Cells[2].Value.ToString();
                
            }
            btAtualizar.Enabled = true;
            btExcluir.Enabled = true;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            carregaDados();
            this.Refresh();

        }
    }
    
}
