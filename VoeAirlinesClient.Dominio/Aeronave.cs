using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoeAirlinesClient.Dominio
{
    public class Aeronave //PascalCasing
    {
        //Atributos -dados da Aeronave
        /*private string _fabricante;
        private string _modelo;
        private string _codigo;   */
        //Opção de não iniciar valores

        //Propriedades Automáticas
        public string Fabricante { get; set; } //PascalCasing
        public string Modelo { get; set; }
        public string Codigo { get; set; }

        public Aeronave()
        {
        }

        public Aeronave(string fabricante, string modelo, string codigo) //camelCase
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
        }

        //Virtual - colocando o virtual no pai e sobreescrevendo
        public virtual string ManterAeronave()
        {
            return "A aeronave teve uma Manutenção Geral";
        }

    }
}
