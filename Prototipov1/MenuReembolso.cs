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
    public partial class MenuReembolso : Form
    {
        public MenuReembolso()
        {
            InitializeComponent();
        }

        private void btMenuInicial_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil();
            telaPerfil.ShowDialog();
        }
    }
}
