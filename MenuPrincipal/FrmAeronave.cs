using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoeAirlinesClient.Dominio;

namespace MenuPrincipal
{
    public partial class FrmAeronave : Form
    {
        public FrmAeronave()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Construtor vazio ele cria uma instância do objeto
            /*Aeronave aeronave = new Aeronave(); //Construtor Vazio.?
            aeronave.AtribuirFabricante(txtFabricante.Text);//atribuo
            MessageBox.Show(aeronave.RetornaFabricante());//recuperar*/

            //cria o objeto com construtor vazio
            Aeronave aeronave = new Aeronave();//não iniciar
            //Objeto  é uma instância de uma classe
            //Minas Gerais - é uma classe (não consegue pegar)
            //Pão de Queijo - é o objeto (pegar, comer ..etc...)

            //aeronave é objeto
            //Quais as características desse objeto
            //Fabricante
            //Modelo
            //Codigo


            //set
            aeronave.Fabricante = txtFabricante.Text;//atribuindo
            aeronave.Codigo = txtCodigo.Text;
            aeronave.Modelo = txtModelo.Text;

            //get
            lblResultadoFabricante.Text = aeronave.Fabricante;//adquirindo valor
            lblResultadoCodigo.Text = aeronave.Codigo;
            lblResultadoModelo.Text = aeronave.Modelo;

           

        }
    }
}
