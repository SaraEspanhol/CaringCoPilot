﻿using System;
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
    public partial class MenuVoluntarioCadastro : Form
    {
        public MenuVoluntarioCadastro()
        {
            InitializeComponent();
            panelResponsavel.Enabled = false;
        }

        private void checkMenorIdade_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMenorIdade.Checked)
            {
                panelResponsavel.Enabled = true;
            }else
            {
                panelResponsavel.Enabled = false;
            }
            
        }
    }
}
