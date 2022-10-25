using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoeAirlinesClient.Dominio
{
    internal class Piloto
    {
        //Cite 3 características do Piloto
        public string NumeroCertificado { get; set; }
        public string Nome { get; set; }

        public string TipoAeronave { get; set; }

        //cite 3 funcionalidades do Piloto
        public string VerificaNome()
        {
            if (Nome.Equals("Rômulo"))
            {
                return "acessou";
            }
            else
            {
                return "não acessou!";
            }
        }
        public void ValidarCertificado()
        {

        }
        // Banco de Dados
        //Quais funcionalidades o piloto fará com o banco
        public string Conectar()
        {
            return null;
        }
        public string Cadastrar()
        {
            return null;
        }
        public string Exibir()
        {
            return null;
        }
        public string Alterar()
        {
            return null;
        }
        public string PesquisarPorCertificado()
        {
            return null;
        }

        public Piloto(string numeroCertificado, string nome, string tipoAeronave)
        {
            NumeroCertificado = numeroCertificado;
            Nome = nome;
            TipoAeronave = tipoAeronave;
        }
    }
}
