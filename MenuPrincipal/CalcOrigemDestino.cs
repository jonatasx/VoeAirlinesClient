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
    public partial class CalcOrigemDestino : Form
    {
        public CalcOrigemDestino()
        {
            InitializeComponent();
        }

        private void CalcOrigemDestino_Load(object sender, EventArgs e)
        {
            ///trabalhando com data curta
            lblDataHoje.Text = $"Hoje é {DateTime.Now.ToShortDateString()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TimeSpan é uma estrutura top
            string descricao = txtDescricao.Text;
            TimeSpan qtdeDias = DateTime.Now.Date - dtpDataFabricacao.Value;
     
            int idadeAeronave = qtdeDias.Days / 365;

            //Lógica do lblQtdeAnos

            if (idadeAeronave > 0)
            {
                lblQtdeAnos.Text = idadeAeronave.ToString();
            }
            else
            {
                lblQtdeAnos.Text = "Aeronave não completou 1 ano";
            }

            //Lógica do Destino Aposentadoria
            if (idadeAeronave >= 20)

            
            if(idadeAeronave >= 20)

            {
                lblDestinoAposentadoria.Text = "A Aeronave deve ser aposentada";
            }
            else
            {
                lblDestinoAposentadoria.Text = "Aeronave na Ativa";
            }
        }

      
    }

}




