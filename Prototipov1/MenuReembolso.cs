
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Xceed.Words.NET;
using Word = Microsoft.Office.Interop.Word;
using Aspose.Words;
using Aspose.Words.Saving;


namespace Prototipov1
{
    public partial class MenuReembolso : Form
    {
        public string Nome, Ong, Descr_Gasto1, Descr_Gasto2, Descr_Gasto3, Descr_Gasto4,
                      Descr_Gasto5, Descr_Gasto6, Descr_Gasto7, Descr_Gasto8, Data;

        

        public double Valor_Gasto1, Valor_Gasto2, Valor_Gasto3, Valor_Gasto4,
                      Valor_Gasto5, Valor_Gasto6, Valor_Gasto7, Valor_Gasto8, Valor_total;

        public MenuReembolso()
        {
            InitializeComponent();
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }

       
        public void New()
        {

            Nome = txtNome.Text;
            Ong = txtONG.Text;
            Descr_Gasto1 = txtDescricaoReembolso.Text;
            Descr_Gasto2 = txtDescricaoReembolso2.Text;
            Descr_Gasto3 = txtDescricaoReembolso3.Text;
            Descr_Gasto4 = txtDescricaoReembolso4.Text;
            Descr_Gasto5 = txtDescricaoReembolso5.Text;
            Data = txtDataReembolso.Text;
            Valor_Gasto1 = Convert.ToDouble(txtValorPago1.Text);
            Valor_Gasto2 = Convert.ToDouble(txtValorPago2.Text); 
            Valor_Gasto3 = Convert.ToDouble(txtValorPago3.Text); 
            Valor_Gasto4 = Convert.ToDouble(txtValorPago4.Text); 
            Valor_Gasto5 = Convert.ToDouble(txtValorPago5.Text);
            Valor_total = Convert.ToDouble(txtValorPagoTotal.Text);
        }
       
        private void btRelatorio_Click(object sender, EventArgs e)
        {
            CriarDocumentoWord();

        }

        static void CriarDocumentoWord()
        {
            // Carregar documento
            Document doc = new Document("Document.docx");
            DocumentBuilder builder = new DocumentBuilder(doc);

            // Acesse o parágrafo
            var paragraph = doc.Sections[0].Body.Paragraphs[0].Runs[0];
            paragraph.Text = "This is updated text";
            // Salve o documento

            doc.Save("Document_updated.docx");
            Console.WriteLine("Documento Word gerado com sucesso.");
        }









    }
}

