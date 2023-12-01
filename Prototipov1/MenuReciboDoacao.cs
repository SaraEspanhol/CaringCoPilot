using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace Prototipov1
{
    public partial class MenuReciboDoacao : Form
    {
        private dbs db;
        public MenuReciboDoacao()
        {
            InitializeComponent();
            
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuReciboDoacao_Load(object sender, EventArgs e)
        {
            ComboBoxDoadores();
            ComboBoxCodDoador();
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

                            comboDoador.Items.Clear();


                            while (reader.Read())
                            {
                                comboDoador.Items.Add(reader["nome"].ToString());
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

       

        private void ComboBoxCodDoador()
        {
            
        }

        private void btRecibo_Click(object sender, EventArgs e)
        {
            PreencherArquivoWord(txtONG.Text, txtCNPJ.Text, comboDoador.Text, txtCPF.Text,
            txtValorRecibo.Text, txtDataRecibo.Text);
        }

        private void PreencherArquivoWord(string Ong, string Cnpj, string doador, string documento, 
            string valor, string data)
        {

            // Caminho para o modelo do documento Word (template)
            string templatePath = @"C:\Users\jpesp\Downloads\recibo\recibo_base.docx";

            // Caminho para o arquivo Word de saída
            string outputPath = @"C:\Users\jpesp\Downloads\recibo\recibo.docx";

            // Crie uma instância do Word e abra o modelo
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Open(templatePath);

            // Substitua os marcadores de espaço reservado pelos valores dos TextBoxes
            SubstituirMarcador(doc, "<ONG>", Ong);
            SubstituirMarcador(doc, "<CNPJ>", Cnpj);
            SubstituirMarcador(doc, "<VALOR>", valor);
            SubstituirMarcador(doc, "<DOADOR>", doador);
            SubstituirMarcador(doc, "<DOCUMENTO>", documento);
            SubstituirMarcador(doc, "<DATA>", data);
            

            // Salve o documento preenchido e limpe os recursos
            doc.SaveAs2(outputPath);
            doc.Close();
            wordApp.Quit();

            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(wordApp);

            MessageBox.Show($"Documento Word preenchido e salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SubstituirMarcador(Word.Document doc, string marcador, string valor)
        {
            Word.Range range = doc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: marcador, ReplaceWith: valor);
        }

        private void MenuReciboDoacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                
            
        }
    }
}
