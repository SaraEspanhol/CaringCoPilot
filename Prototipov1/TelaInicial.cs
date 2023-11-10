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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

        }
            private void btEntrar_Click(object sender, EventArgs e)
            {
                this.Hide();
                TelaPerfil telaPerfil = new TelaPerfil();
                telaPerfil.ShowDialog();

            }

            private void TelaInicial_Load(object sender, EventArgs e)
            {

            }

            private void btCadastrar_Click(object sender, EventArgs e)
            {
                this.Hide();


            }
        
    }
}
