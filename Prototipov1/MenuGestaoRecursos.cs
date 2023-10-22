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
    public partial class MenuGestaoRecursos : Form
    {
        public MenuGestaoRecursos()
        {
            InitializeComponent();
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            TelaRelatorioControleFinanceiro telaRelatorioControleFinanceiro = new TelaRelatorioControleFinanceiro();
            telaRelatorioControleFinanceiro.ShowDialog();
        }
    }
}
