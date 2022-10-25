using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoeAirlinesClient.Dominio;

namespace MenuPrincipal
{
    public partial class FrmDirigivel : Form
    {
        public FrmDirigivel()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Dirigivel dirigivel = new Dirigivel();
            //SET automático
            // herança - generalização (do pai)
            dirigivel.Fabricante = "Airship do Brasil";
            dirigivel.Codigo = "ADB-1";
            //herança - especialização (do filho)
            dirigivel.RemotamenteControlado = true;

            //GET automático

            MessageBox.Show(
                $"Fabricante: {dirigivel.Fabricante} Codigo:{dirigivel.Codigo} Remotamente Controlado:{dirigivel.RemotamenteControlado}");

            //Assembly  - .exe .dll próprio software
            //Como que um software vai ter informação do software?
            AssemblyName meuAssembly = Assembly.GetExecutingAssembly().GetName();
            MessageBox.Show($"Nome : {meuAssembly.Name}");
            MessageBox.Show($"Versão : {meuAssembly.Version}");

            /*
             * A versão do software tem 4 partes:
             * <maior versão> <menor versão> <build> number> <revisao>)
             */

        }
    }
}
