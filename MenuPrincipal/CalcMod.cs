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
    public partial class CalcMod : Form
    {
        public CalcMod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Entrada de Dados
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            //Processamento de Dados
            int resto = dividendo % divisor;
            //Resultado ou saída dos dados
            txtResto.Text = resto.ToString();
        }
    }
}
