
using Microsoft.Office.Interop.Excel;
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
    public partial class MenuReembolso : Form
    {
        public string Nome;
        public string Ong;
        public string Descr_Gasto1;
        public string Descr_Gasto2;
        public string Descr_Gasto3;
        public string Descr_Gasto4;
        public string Descr_Gasto5;
        public string Data;
        public string Valor_Gasto1;
        public string Valor_Gasto2;
        public string Valor_Gasto3;
        public string Valor_Gasto4;
        public string Valor_Gasto5;
        public string Valor_total;

        private void MenuReembolso_Load(object sender, EventArgs e)
        {

        }



        public MenuReembolso()
        {
            InitializeComponent();
            
        }
    

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
       
        private void btRelatorio_Click(object sender, EventArgs e)
        {
            
            PreencherArquivoWord(txtNome.Text, txtONG.Text, txtDescricaoReembolso.Text, txtDescricaoReembolso2.Text,
                txtDescricaoReembolso3.Text, txtDescricaoReembolso4.Text, txtDescricaoReembolso5.Text, txtDataReembolso.Text,
                txtValorPago1.Text, txtValorPago2.Text, txtValorPago3.Text, txtValorPago4.Text, txtValorPago5.Text, 
                txtValorPagoTotal.Text);
            

        }

         private void PreencherArquivoWord(string Nome, string Ong, string Descr_Gasto1, string Descr_Gasto2, string Descr_Gasto3,
         string Descr_Gasto4, string Descr_Gasto5, string Data, string Valor_Gasto1, string Valor_Gasto2, string Valor_Gasto3,
         string Valor_Gasto4, string Valor_Gasto5, string Valor_total)
         { 
        
            // Caminho para o modelo do documento Word (template)
            string templatePath = @"C:\Users\jpesp\Downloads\reembolso\reembolso_base.docx";

            // Caminho para o arquivo Word de saída
            string outputPath = @"C:\Users\jpesp\Downloads\reembolso\Reembolso.docx";

            // Crie uma instância do Word e abra o modelo
            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Open(templatePath);

        // Substitua os marcadores de espaço reservado pelos valores dos TextBoxes
            SubstituirMarcador(doc, "<NOME>", Nome);
            SubstituirMarcador(doc, "<ONG>", Ong);
            SubstituirMarcador(doc, "<Descr_Gasto1>", Descr_Gasto1);
            SubstituirMarcador(doc, "<Descr_Gasto2>", Descr_Gasto2);
            SubstituirMarcador(doc, "<Descr_Gasto3>", Descr_Gasto3);
            SubstituirMarcador(doc, "<Descr_Gasto4>", Descr_Gasto4);
            SubstituirMarcador(doc, "<Descr_Gasto5>", Descr_Gasto5);
            SubstituirMarcador(doc, "<Valor_Gasto1>", Valor_Gasto1);
            SubstituirMarcador(doc, "<Valor_Gasto2>", Valor_Gasto2);
            SubstituirMarcador(doc, "<Valor_Gasto3>", Valor_Gasto3);
            SubstituirMarcador(doc, "<Valor_Gasto4>", Valor_Gasto4);
            SubstituirMarcador(doc, "<Valor_Gasto5>", Valor_Gasto5);
            SubstituirMarcador(doc, "<Data>", Data);
            SubstituirMarcador(doc, "<Valor_total>", Valor_total);

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

        private void gBoxGestaoRecursos_Enter(object sender, EventArgs e)
        {

        }

        private void MenuReembolso_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                
            
        }
    }









}


