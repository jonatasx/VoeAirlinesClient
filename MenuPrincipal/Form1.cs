using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pesquisarWebApiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitação Iniciada...", "API VoeAirlines", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calculadoraMODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalcMod().Show();
        }
    }
}
